using System;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUAttenceSystem.Model;
using System.IO;

namespace DJTUAttenceSystem.Course {
    class ExcelExporter {
        
        IWorkbook Excel;
        ISheet sheet;
        IRow header;
        ICellStyle headerCellStyle;
        ICellStyle rowCellStyle;
        Model.Course course;
        List<StuList> lists;
        public string path = null;
        private Dictionary<string, int> indexOfHeaderColumn = new Dictionary<string, int>() {
            {"学号",0},{"姓名",1},{"性别",2},{"专业",3},{"年级",4},{"班级",5},
            {"选课属性",6},{"考核方式",7},{"考试性质",8},{"是否缓考",9},{"成绩",10}
        };
        private ExcelExporter() { }
        public static ExcelExporter createExporter(List<StuList> lists,Model.Course course,string path) {
            try {
                ExcelExporter exporter = new ExcelExporter();
                exporter.lists = lists;
                exporter.course = course;
                exporter.path = path;
                exporter.init();
                return exporter;
            } catch {
                throw new ParseException("文件解析失败");
            }
        }
        private void init() {
            string suffix = path.Substring(path.Length - 5);
            if (suffix.Equals(".xlsx")) {
                Excel = new XSSFWorkbook();
            } else {
                Excel = new HSSFWorkbook();
            }
            sheet = Excel.CreateSheet("Sheet1");
            header = sheet.CreateRow(0);
            initCellStyle();
            initHeader();
            initRows();
            renameHeader();
            resizeColumn();
        }
        private void initCellStyle() {
            headerCellStyle = Excel.CreateCellStyle();
            headerCellStyle.BorderBottom = BorderStyle.Thin;
            headerCellStyle.BorderLeft = BorderStyle.Thin;
            headerCellStyle.BorderRight = BorderStyle.Thin;
            headerCellStyle.BorderTop = BorderStyle.Thin;
            headerCellStyle.Alignment = HorizontalAlignment.Center;
            //字体
            IFont headerfont = Excel.CreateFont();
            headerfont.Boldweight = (short)FontBoldWeight.Bold;
            headerCellStyle.SetFont(headerfont);

            rowCellStyle = Excel.CreateCellStyle();

            //为避免日期格式被Excel自动替换，所以设定 format 为 『@』 表示一率当成text來看
            rowCellStyle.DataFormat = HSSFDataFormat.GetBuiltinFormat("@");
        }
        private void initHeader() {
            int columnCount = 0;
            foreach (string key in indexOfHeaderColumn.Keys) {
                ICell cell = header.CreateCell(indexOfHeaderColumn[key]);
                cell.SetCellValue(key);
                cell.CellStyle = headerCellStyle;
                columnCount++;
            }
            foreach (SubAttandance subAtt in course.allSubAttandances()) {
                ICell cell = header.CreateCell(columnCount);
                cell.CellStyle = headerCellStyle;
                cell.SetCellValue(subAtt.UUID);
                cell.CellStyle = headerCellStyle;
                columnCount++;
            }
            foreach (subExtra subExt in course.allExtras()) {
                ICell cell = header.CreateCell(columnCount);
                cell.SetCellValue(subExt.UUID);
                cell.CellStyle = headerCellStyle;
                columnCount++;
            }
        }
        private void initRows() {
            int rowIndex = 1;
            foreach (StuList stuList in lists) {
                foreach (Student student in stuList.allStudents()) {
                    IRow row = sheet.CreateRow(rowIndex);
                    createBaseCell(row,student);
                    createAttandanceCell(row, student);
                    createExtraCell(row, student);
                    rowIndex++;
                }
            }
        }
        private void createBaseCell(IRow row,Student stu) {
            foreach (string key in indexOfHeaderColumn.Keys) {
                ICell cell = row.CreateCell(indexOfHeaderColumn[key]);
                cell.CellStyle = rowCellStyle;
                cell.SetCellValue(stu.getValuebyName(key));
            }
        }
        private void createAttandanceCell(IRow row,Student stu) {
            foreach (StuAttandance stuAtt in stu.allStuAttandances()) {
                ICell cell = createCellByUUID(row, stuAtt.UUID);
                cell.SetCellValue(stuAtt.record.recordString());
            }
        }
        private void createExtraCell(IRow row,Student stu) {
            foreach (StuExtra stuExt in stu.allStuExtras()) {
                ICell cell = createCellByUUID(row,stuExt.UUID);
                if (cell != null)
                    cell.SetCellValue(stuExt.result.typeName);
            }
        }
        private ICell createCellByUUID(IRow row,string UUID) {
            ICell headerCell = findHeaderCellByUUID(UUID);
            ICell cell = row.CreateCell(headerCell.ColumnIndex);
            cell.CellStyle = rowCellStyle;
            return cell;
        }
        private ICell findHeaderCellByUUID(string UUID) {
            foreach (ICell cell in header.Cells) {
                if (cell.StringCellValue.Equals(UUID)) {
                    return cell;
                }
            }
            return null;
        }
        private void renameHeader() {
            foreach (SubAttandance subAtt in course.allSubAttandances()) {
                ICell headerCell = findHeaderCellByUUID(subAtt.UUID);
                if (headerCell != null)
                    headerCell.SetCellValue(subAtt.date.ToString("m"));
            }
            foreach (subExtra subExt in course.allExtras()) {
                ICell headerCell = findHeaderCellByUUID(subExt.UUID);
                if (headerCell != null) {
                    headerCell.SetCellValue(subExt.name);
                }
            }
        }
        private void resizeColumn() {
            for (int i = 0; i < sheet.GetRow(0).LastCellNum; i++) {
                sheet.AutoSizeColumn(i);
            }
        }

        public void export() {
            try {
                FileStream file = new FileStream(path, FileMode.Create);
                Excel.Write(file);
                file.Close();
            } catch {
                throw new ExportException("文件保存失败，请重试");
            }
        }

        public class ParseException : ApplicationException {
            public ParseException(string message) : base(message) {

            }
        }
        public class ExportException : ApplicationException {
            public ExportException(string message) : base(message) {

            }
        }
    }
}
