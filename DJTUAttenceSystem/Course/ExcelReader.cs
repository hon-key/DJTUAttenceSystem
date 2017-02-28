using DJTUAttenceSystem.Model;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;


namespace DJTUAttenceSystem.Course {
    class ExcelReader {
        public static int headerRowIndex = 1;
        public static int listSheetIndex = 0;
        IWorkbook Excel;
        ISheet sheet;
        IRow header;
        private ExcelReader() {

        }
        public static ExcelReader createReader(string path) {
            ExcelReader reader = new ExcelReader();
            reader.openExcel(path);
            return reader;
        }
        private void openExcel(string path) {
            Excel = parse(path);
            sheet = Excel.GetSheetAt(listSheetIndex);
            header = sheet.GetRow(headerRowIndex);
            if (header == null || !TextOfColumnIndex(header, 0).Equals("学号"))
                throw new ExcelOpenFailedException("列标题读取错误");
        }
        private IWorkbook parse(string path) {
            try {
                return creatBookWithType(bookType.xlsExcel, path);
            } catch (NPOI.POIFS.FileSystem.OfficeXmlFileException) {
                return creatBookWithType(bookType.xlsxExcel, path);
            }
        }
        enum bookType {xlsExcel = 0,xlsxExcel = 1}
        private IWorkbook creatBookWithType(bookType type,string path) {
            try {
                FileStream file;
                IWorkbook book;
                file = new FileStream(path, FileMode.Open, FileAccess.Read);
                if ((type == bookType.xlsExcel))
                    book = new HSSFWorkbook(file);
                else
                    book = new XSSFWorkbook(file);
                if (book.GetSheetAt(listSheetIndex) == null)
                    throw new ExcelOpenFailedException("Excel不是可读取的学生名单");
                return book;
            } catch {
                throw new ExcelOpenFailedException("Excel文件无法读取");
            }
        }

        public StuList appendStudentsToList(StuList stuList) {
            try {
                StuList exceptList = new StuList();
                for (int i = 2; i <= sheet.LastRowNum; i++) {
                    IRow row = sheet.GetRow(i);
                    Student stu = studentFromRow(row);
                    if (stu == null) continue;
                    if (!stuList.containsStudent(stu)) {
                        stuList.addStudent(stu);
                    } else {
                        exceptList.addStudent(stu);
                    }
                }
                return exceptList;
            } 
            catch { throw new StudentParseException("名单解析失败"); }
        }
        public List<StuList> stuListsClassifyByClass() {
            List<StuList> list = new List<StuList>();
            StuList exceptList = new StuList();
            exceptList.name = "未知班级";
            for (int i = 2; i <= sheet.LastRowNum; i++) {
                IRow row = sheet.GetRow(i);
                Student stu = studentFromRow(row);
                if (stu == null) continue;
                if (stu.major._class.Equals("")) {
                    exceptList.addStudent(stu);
                    continue;
                }
                StuList stuList = getStuListFromCurrentList(ref list, stu.major._class);
                stuList.addStudent(stu);
            }
            if (exceptList.allStudents().Count != 0)
                list.Add(exceptList);
            return list;
        }
        private StuList getStuListFromCurrentList(ref List<StuList> list,string _class) {
            StuList stuList = null;
            foreach (StuList item in list) {
                if (item.name.Equals(_class)) {
                    stuList = item;
                }
            }
            if (stuList == null) {
                stuList = new StuList();
                stuList.name = _class;
                list.Add(stuList);
            }
            return stuList;
        }
        private Student studentFromRow(IRow row) {
            Student stu = new Student(cellString(row, "姓名"), 
                Student.stringToSex(cellString(row, "性别")), 
                cellString(row, "学号"), 
                new Major(cellString(row, "专业"), cellString(row, "年级"), cellString(row, "班级")));
            stu.courseAttribute = Student.stringToCourseAttribute(cellString(row, "选课属性"));
            stu.examMethod = Student.stringToExamMethod(cellString(row, "考核方式"));
            stu.examAttribute = Student.stringToExamAttribute(cellString(row, "考试性质"));
            stu.isExamDelay = Student.stringToIsExamDelay(cellString(row, "是否缓考"));
            stu.score = cellString(row, "成绩");
            if (stu.id == null) {return null;}
            return stu;
        }
        private string cellString(IRow row,string headerTitle) {
            return TextOfColumnIndex(row, ColumnIndexOfRowValue(header, headerTitle));
        }
        private string TextOfColumnIndex(IRow row,int index) {
            ICell cell = row.GetCell(index);
            if (cell.CellType == CellType.Numeric)
                return "" + cell.NumericCellValue;
            else
                return cell.StringCellValue.Replace(" ", "");
        }
        private int ColumnIndexOfRowValue(IRow row,string value) {
            foreach (ICell cell in row.Cells) {
                string cellValue = cell.StringCellValue.Replace(" ", "");
                if (cellValue.Equals(value)) {
                    return cell.ColumnIndex;
                }
            }
            throw new NonContainsException("行不存在相应地值");
        }

        public class NonContainsException : ApplicationException {
            public NonContainsException(string message) : base(message) {

            }
        }
        public class ExcelOpenFailedException : ApplicationException {
            public ExcelOpenFailedException(string message):base(message) {

            }
        }
        public class StudentParseException : ApplicationException {
            public StudentParseException(string message) : base(message) {

            }
        }

    }
}
