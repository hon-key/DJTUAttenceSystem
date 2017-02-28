using HelperSpace;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace DJTUAttenceSystem.Model {
    [Serializable]
    public class Record {
        public enum RType {
            attendance,
            late,
            absenteeism,
            sickLeave,
            businessLeave,
        }
        public RType type;
        public int weight;
        public Record(RType type,int weight) {
            this.type = type;
            this.weight = weight;
        }
        public string recordString() {
            string result;
            switch (type) {
                case RType.attendance:result = "出勤"; break;
                case RType.late: result = "迟到"; break;
                case RType.absenteeism: result = "旷课";break;
                case RType.sickLeave:result = "病假";break;
                case RType.businessLeave:result = "事假"; break;
                default:result = "未知"; break;
            }
            return result;
        }
        public Color recordColor{
            get {
                Color color = Color.Empty;
                switch (type) {
                    case Record.RType.attendance: color = Color.ForestGreen; break;
                    case Record.RType.absenteeism: color = Color.DarkRed; break;
                    case Record.RType.businessLeave:
                    case Record.RType.sickLeave: color = Color.DimGray; break;
                    default: break;
                }
                return color;
            }
        }
    }
    [Serializable]
    public class checkType {
        public string typeName = "unkown";
        public Color typeColor;
        public int weight = 0;
        public checkType(string typeName,int weight) {
            this.typeName = typeName;this.weight = weight;
        }
    }
    #region/* ----- 学生考勤类 ----- */
    [Serializable]
    public class StuAttandance : IComparable {
        public string UUID;
        public DateTime date = DateTime.Now;
        public Record record = null;
        public int CompareTo(object obj) {
            int flag = 0;
            try {
                StuAttandance stu = (StuAttandance)obj;
                flag = DateTime.Compare(this.date, stu.date);
            } catch (Exception ex) { throw new Exception("比较异常",ex.InnerException); }
            return flag;
        }
        public override string ToString() {
            return string.Format("StuAttandance:[{0},{1}]", this.date.ToString(), this.record);
        }
        public StuAttandance(SubAttandance subAtt,Record record) {
            date = subAtt.date;
            UUID = subAtt.UUID;
            this.record = record;
        }
    }
    [Serializable]
    public class StuExtra {
        public string UUID;
        public string name = "unkown";
        public checkType result = null;
        public StuExtra(subExtra subE) {
            UUID = subE.UUID;
        }
        public StuExtra(subExtra subE,string value) {
            UUID = subE.UUID;
            this.name = subE.name;
            this.result = subE[value];
        }
        public override string ToString() {
            return string.Format("StuExtra:[{0},{1},weight:{2}]",this.name,this.result.typeName);
        }
    }
    #endregion

    #region /* ----- 科目考勤类 ----- */
    [Serializable]
    public class SubAttandance : IComparable {
        public string UUID = Guid.NewGuid().ToString();
        public DateTime date = DateTime.Now;
        public SubAttandance(DateTime date) {
            this.date = date;
        }
        public int CompareTo(object obj) {
            int flag = 0;
            try {
                SubAttandance sub = (SubAttandance)obj;
                flag = DateTime.Compare(this.date, sub.date);
            } catch (Exception ex) {throw new Exception("比较异常",ex.InnerException); }
            return flag;
        }
        public override string ToString() {
            return string.Format("SubAttandance:[{0}]", date.ToString());
        }
    }
    [Serializable]
    public class subExtra {
        public string UUID = Guid.NewGuid().ToString();
        public string name = "unkown";
        private ArrayList checkTypes = new ArrayList();
        public subExtra() {
            checkTypes.Add(new checkType("及格", 1));
            checkTypes.Add(new checkType("不及格", 0));
        }
        public subExtra(string name,params checkType[] ps) {
            this.name = name;
            if (ps != null) {
                foreach (checkType tp in ps) {
                    this.checkTypes.Add(tp);
                }
            } else {
                checkTypes.Add(new checkType("及格", 1));
                checkTypes.Add(new checkType("不及格", 0));
            }
        }
        public ArrayList getAllCheckType() {
            return ArrayList.ReadOnly(checkTypes);
        }
        public checkType getMaxWeightCheckType() {
            checkType maxType = null;
            int weight = -1;
            foreach (checkType type in checkTypes) {
                if (type.weight > weight) {
                    maxType = type;
                    weight = maxType.weight;
                }
            }
            if (weight == -1) 
                throw new NullReferenceException("找不到checkType");
            return maxType;
        }
        public void addCheckType(checkType tp) {
            checkTypes.Add(tp);
        }
        public void removeCheckType(checkType tp) {
            if (checkTypes.Contains(tp)) {
                checkTypes.Remove(tp);
            }
        }
        public override string ToString() {
            return string.Format("subExtra:{0}", name);
        }
        public checkType this[string name] {
            get {
                foreach (checkType type in checkTypes) {
                    if (type.typeName.Equals(name)) {
                        return type;
                    }
                }
                throw new NullReferenceException();
            }
        }
    }
    #endregion

    #region /* ----- 专业类 ----- */
    [Serializable]
    public class Major {
        public string name = "unkown";
        public string grade = "unkown";
        public string _class = "unkown";
        public Major (string name,string grade,string _class) {
            this.name = name;
            this.grade = grade;
            this._class = _class;
        }
    }
    #endregion

    #region /* ----- 学生类 ----- */
    public enum Sex {
        male,
        female
    }
    public enum CourseAttribute {
        required,
        optional,

    }
    public enum ExamMethod {
        unconfirmed,
        other
    }
    public enum ExamAttribute {
        normal,
        other
    }
    [Serializable]
    public class Student : IComparable {
        #region [ ----- Property ----- ]
        public string name = "unkown";
        public Sex sex = Sex.male;
        public string id = "unkown";
        public Major major;
        public CourseAttribute courseAttribute = CourseAttribute.required;
        public ExamMethod examMethod = ExamMethod.unconfirmed;
        public ExamAttribute examAttribute = ExamAttribute.normal;
        public bool isExamDelay = false;
        public string score;
        private ArrayList stuAttandances = new ArrayList();
        public ArrayList stuExtras = new ArrayList();
        #endregion
        public Student(string name,Sex sex, string id) {
            this.name = name;
            this.sex = sex;
            this.id = id;
            stuAttandances = new ArrayList();
            courseAttribute = CourseAttribute.required;
            examMethod = ExamMethod.unconfirmed;
            examAttribute = ExamAttribute.normal;
        }
        public Student(string name,Sex sex,string id,Major major) {
            this.name = name;
            this.sex = sex;
            this.id = id;
            this.major = major;
            stuAttandances = new ArrayList();
            courseAttribute = CourseAttribute.required;
            examMethod = ExamMethod.unconfirmed;
            examAttribute = ExamAttribute.normal;
        }
        public string getValuebyName(string name) {
            switch (name) {
                case "学号":return id;
                case "姓名":return this.name;
                case "性别":return sexToString();
                case "专业":return major.name;
                case "年级":return major.grade;
                case "班级":return major._class;
                case "成绩":return score;
                case "选课属性":return courseAttributeToString();
                case "考核方式":return examMethodToString();
                case "考试性质":return examAttributeToString();
                case "是否缓考":return isExamDelayToString();
                default:return null;
            }
        }
        #region [ ----- stuAttandance ----- ]
        public void addAttandance(StuAttandance att) {
            stuAttandances.Add(att);
            stuAttandances.Sort();
        }
        public void removeAttandance(string UUID) {
            StuAttandance aim = getAttandance(UUID);
            if (aim != null) {
                stuAttandances.Remove(aim);
            }
        }
        public StuAttandance getAttandance(string id) {
            foreach (StuAttandance stuAtt in stuAttandances) {
                if (stuAtt.UUID.Equals(id)) {
                    return stuAtt;
                }
            }
            return null;
        }
        public ArrayList allStuAttandances() {
            return ArrayList.ReadOnly(this.stuAttandances);
        }
        public bool isFullAttandance {
            get {
                if (stuAttandances.Count == 0) {
                    return false;
                }
                foreach (StuAttandance stuAtt in stuAttandances) {
                    if (stuAtt.record.type != Record.RType.attendance) {
                        return false;
                    }
                }
                return true;
            }
        }
        #endregion
        #region [ ----- stuExtra ----- ]
        public ArrayList allStuExtras() {
            return ArrayList.ReadOnly(stuExtras);
        }
        public void addStuExtra(StuExtra stuExt) {
            stuExtras.Add(stuExt);
        }
        public StuExtra getStuExtra(string UUID) {
            foreach (StuExtra stuExt in stuExtras) {
                if (stuExt.UUID.Equals(UUID)) {
                    return stuExt;
                }
            }
            return null;
        }
        public void  removeStuExtra(string UUID) {
            StuExtra stuExt = getStuExtra(UUID);
            if (stuExt != null) {
                stuExtras.Remove(stuExt);
            }
        }
        #endregion

        public int CompareTo(object obj) {
            int flag = 0;
            try {
                Student stu = (Student)obj;
                UInt64 thisId = UInt64.Parse(this.id);
                UInt64 objId = UInt64.Parse(stu.id);
                flag = thisId.CompareTo(objId);
            } catch (Exception ex) {
                throw new Exception("比较异常",ex.InnerException);
            }
            return flag;
        }
        #region [ ----- enum Method ----- ]
        public override string ToString() {
            return string.Format("[{0},{1},{2}]", this.name, this.sex, this.id);
        }
        public string sexToString() {
            if (sex == Sex.male) {
                return "男";
            }else {
                return "女";
            }
        }
        public static Sex stringToSex(string value) {
            if (value.Equals("男")) {
                return Sex.male;
            }else if (value.Equals("女")) {
                return Sex.female;
            }else {
                throw new Exception("不是预期的参数值");
            }
        }
        public string courseAttributeToString() {
            if (courseAttribute == CourseAttribute.required) {
                return "必修";
            } else {
                return "选修";
            }
        }
        public static CourseAttribute stringToCourseAttribute(string value) {
            if (value.Equals("选修")) {
                return CourseAttribute.optional;
            } else if (value.Equals("必修")) {
                return CourseAttribute.required;
            } else {
                return CourseAttribute.required;
            }
        }
        public string examMethodToString() {
            if (examMethod == ExamMethod.other) {
                return "其他";
            }else {
                return "未确定";
            }
        }
        public static ExamMethod stringToExamMethod(string value) {
            if (value.Equals("其他")) {
                return ExamMethod.other;
            } else if (value.Equals("未确定")) {
                return ExamMethod.unconfirmed;
            } else {
                return ExamMethod.other;
            }
        }
        public string examAttributeToString() {
            if (examAttribute == ExamAttribute.normal) {
                return "正常考试";
            }else {
                return "其他";
            }
        }
        public static ExamAttribute stringToExamAttribute(string value) {
            if (value.Equals("其他")) {
                return ExamAttribute.other;
            } else if (value.Equals("正常考试")) {
                return ExamAttribute.normal;
            } else {
                return ExamAttribute.other;
            }
        }
        public string isExamDelayToString() {
            if (isExamDelay) {
                return "缓考";
            } else {
                return "非缓考";
            }
        }
        public static bool stringToIsExamDelay(string value) {
            if (value.Equals("缓考")) {
                return true;
            } else if (value.Equals("非缓考")) {
                return false;
            } else {
                return false;
            }
        }
        #endregion

    }
    #endregion

    #region /* ----- 课程类 ----- */
    [Serializable]
    public class StuList {
        public string UUID = Guid.NewGuid().ToString();
        public string name = "ukown";
        public ArrayList students = new ArrayList();
        public void addStudent(Student stu) {
            students.Add(stu);
            students.Sort();
        }
        public void appendStudents(StuList list) {
            foreach (Student stu in list.allStudents()) {
                if (!containsStudent(stu)) {
                    addStudent(stu);
                }
            }
        }
        public void removeStudent(string id) {
            Student aim = this[id];
            if (aim != null) { students.Remove(aim); } 
            else { Console.WriteLine("【移除学生】{0}:学生id：{1}不存在！", this.name, id); }
        }
        public bool containsStudent(Student stu) {
            if (this[stu.id] != null) {
                return true;
            }
            return false;
        }
        public void clear() {
            students.Clear();
        }
        public ArrayList allStudents() {
            students.Sort();
            return ArrayList.ReadOnly(students);
        }
        public Student this[string id] {
            get {
                foreach (Student stu in students) {
                    if (stu.id.Equals(id)) { return stu; }
                }
                return null;
            }
        }
    }
    [Serializable]
    public class Course {
        public string name = "unkown";
        public string id = "unkown";
        public string remark = "unkown";
        private ArrayList records = new ArrayList();
        private ArrayList stuLists = new ArrayList();
        private ArrayList subAttandances = new ArrayList();
        private ArrayList subExtras = new ArrayList();

        public Course(string name, string id,string remark,params Record[] records) {
            this.name = name;
            this.id = id;
            this.remark = remark;
            if (records != null) {
                foreach (Record re in records) {
                    this.records.Add(re);
                }
            } else {
                this.records.Add(new Record(Record.RType.attendance, 2));
                this.records.Add(new Record(Record.RType.absenteeism, 0));
                this.records.Add(new Record(Record.RType.businessLeave, 0));
                this.records.Add(new Record(Record.RType.late, 1));
                this.records.Add(new Record(Record.RType.sickLeave, 0));
            }
        }
        public ArrayList getAllRecords() {
            return ArrayList.ReadOnly(records);
        }
        public Record getRecord(string value) {
            foreach (Record record in records) {
                if (record.recordString().Equals(value)) {
                    return record;
                }
            }
            return null;
        }
        public Record getRecord(Record.RType type) {
            foreach (Record record in records) {
                if (record.type == type) {
                    return record;
                }
            }
            return null;
        }
        public ArrayList allExtras() {
            return ArrayList.ReadOnly(subExtras);
        }
        public void addExtra(subExtra subExt) {
            subExtras.Add(subExt);
        }
        public void removeExtra(string uuid) {
            subExtra subExt = null;
            foreach (subExtra item in subExtras) {
                if (item.UUID.Equals(uuid)) {
                    subExt = item;
                }
            }
            if (subExt != null) {
                subExtras.Remove(subExt);
            }
        }
        public subExtra getExtra(string UUID) {
            foreach (subExtra item in subExtras) {
                if (item.UUID.Equals(UUID)) {
                    return item;
                }
            }
            return null;
        }
        public bool containsExtra(string name) {
            foreach (subExtra item in subExtras) {
                if (item.name.Equals(name)) {
                    return true;
                }
            }
            return false;
        }
        public void addSubAttandance(SubAttandance att) {
            subAttandances.Add(att);
            subAttandances.Sort();
        }
        public void removeAttandance(string UUID) {
            SubAttandance subAtt = getSubAttandance(UUID);
            if (subAtt != null) {
                subAttandances.Remove(subAtt);
            }
        }
        public SubAttandance getSubAttandance(string UUID) {
            foreach (SubAttandance item in subAttandances) {
                if (item.UUID.Equals(UUID)) {
                    return item;
                }
            }
            return null;
        }
        public ArrayList allSubAttandances() {
            subAttandances.Sort();
            return ArrayList.ReadOnly(subAttandances);
        }
        
        public void addStuList(StuList stuList) {
            stuLists.Add(stuList);
        }
        public bool containsStuList(string id) {
            foreach (StuList list in stuLists) {
                if (list.UUID.Equals(id)) {
                    return true;
                }
            }
            return false;
        }
        public bool containsStuListByName(string name) {
            foreach (StuList list in stuLists) {
                if (list.name.Equals(name)) {
                    return true;
                }
            }
            return false;
        }
        public StuList removeStuList(string id) {
            StuList aimList = null;
            foreach (StuList list in stuLists) {
                if (list.UUID.Equals(id)) {
                    aimList = list;
                }
            }
            if (aimList != null) {
                stuLists.Remove(aimList);
            }
            return aimList;
        }
        public ArrayList allStulist() {
            return ArrayList.ReadOnly(stuLists);
        }
        public StuList getStuList(string id) {
            foreach (StuList list in stuLists) {
                if (list.UUID.Equals(id)) {
                    return list;
                }
            }
            return null;
        }
        public StuList getStuListByName(string name) {
            foreach (StuList list in stuLists) {
                if (list.name.Equals(name)) {
                    return list;
                }
            }
            throw new NullReferenceException("stuList不存在");
        }
    }
    #endregion

    #region  /* ----- 考勤库类 ----- */
    [Serializable]
    public class AttandanceLibrary {
        public string UUID = Guid.NewGuid().ToString();
        public string name = "unkown";
        public string remarks = "unkown";
        public DateTime lastModified = DateTime.Now;
        private ArrayList Courses = new ArrayList();
        public string password = null;
        public AttandanceLibrary(string name,string remarks) {
            this.name = name;
            this.remarks = remarks;
        }
        public ArrayList allCourses() {
            return ArrayList.ReadOnly(this.Courses);
        }
        public void addCourse(Course course) {
            Courses.Add(course);
        }
        public void removeCourse(Course course) {
            Courses.Remove(course);

        }
        public bool containsCourse(string id) {
            Course cs = this[id];
            if (cs != null) {
                return true;
            } else {
                return false;
            }
        }
        public Course this[string id] {
            get {
                foreach (Course course in this.Courses) {
                    if (course.id.Equals(id)) {
                        return course;
                    }
                }
                return null;
            }
            set {
                if (!(value is Course) && value != null) {
                    return;
                }
                Course course = this[id];
                if (course != null) {
                    this.Courses.Remove(course);
                }
                this.Courses.Add(value);
            }
        }

    }
    #endregion
    [Serializable]
    class CustomLibrary {
        public AttandanceLibrary libObj;
        public string path;
        private CustomLibrary() { }
        public static CustomLibrary createLibrary(AttandanceLibrary lib,string path) {
            CustomLibrary cb = new CustomLibrary();
            cb.libObj = lib;
            cb.path = path;
            return cb;
        }
    }
    [Serializable]
    class DJTUBinary {
        public ArrayList collections;
        public CustomLibrary customizeLibrary = null;
        public bool isCustomize = false;
        public DJTUBinary() {
            collections = new ArrayList();
        }

        public void addLib(AttandanceLibrary lib) {
            collections.Add(lib);
        }
        public void removeLib(string id) {
            AttandanceLibrary lib = this[id];
            if (lib != null) {
                collections.Remove(lib);
            }
        }
        public bool containsLibrary(AttandanceLibrary lib) {
            if (this[lib.UUID] != null) {
                return true; 
            }
            return false;
        }
        public AttandanceLibrary this[string id] {
            get {
                if (isCustomize) {
                    if (customizeLibrary.libObj.UUID.Equals(id)) {
                        return customizeLibrary.libObj;
                    }
                    return null;
                } else {
                    return libraryFromCollections(id);
                }
            }
        }
        private AttandanceLibrary libraryFromCollections(string id) {
            foreach (AttandanceLibrary item in collections) {
                if (item.UUID.Equals(id)) {
                    return item;
                }
            }
            return null;
        }
        /* ----- Save ----- */
        public void save() {
            if (isCustomize) {
                saveWithPath(customizeLibrary.path, customizeLibrary.libObj);
            }else {
                saveWithPath("lib.bin",this);
            }
        }
        private void saveWithPath(string path,object obj) {
            try {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = coverOldLibsFile(path);
                bf.Serialize(fs, obj);
                fs.Close();
            } catch {
                throw new FileSaveException("存档序列化失败，请重试");
            }
        }
        private FileStream coverOldLibsFile(string path) {
            try {
                return new FileStream(path, FileMode.Truncate);
            } catch {
                return null;
            }
        }
        /* ----- init ----- */
        public static DJTUBinary initFromLocal() {
            DJTUBinary libs;
            FileStream file;
            try {
                file = OpenLocalFile();
                libs = deserialize(ref file);
                file.Close();
                return libs;
            } catch(OpenFileException) {
                file = createFile();
                libs = new DJTUBinary();
                serializeLibsToFile(ref libs,ref file);
                file.Close();
                return libs;
            } catch(DeserializeException e) { exitProgram(e.Message); }
            catch(CreateFileException e)    { exitProgram(e.Message); }
            catch (SerializeException e)    { exitProgram(e.Message); }
            return null;
        }
        private static FileStream OpenLocalFile() {
            try {
                return new FileStream("lib.bin", FileMode.Open);
            } catch {
                throw new OpenFileException("文件打开失败");
            }
        }
        private static DJTUBinary deserialize(ref FileStream file) {
            try {
                BinaryFormatter bf = new BinaryFormatter();
                return bf.Deserialize(file) as DJTUBinary;
            } catch {
                throw new DeserializeException("无法正确读取存档，建议删除lib.bin文件，再重试");
            }
        }
        private static FileStream createFile() {
            try {
                return new FileStream("lib.bin", FileMode.Create);
            } catch {
                throw new CreateFileException("无法创建lib.bin文件,请重试");
            }
        }
        private static void serializeLibsToFile(ref DJTUBinary libs,ref FileStream file) {
            try {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, libs);
            } catch {
                throw new SerializeException("存档初始化写入失败，建议重启程序");
            }
        }
        private static void exitProgram(string str) {
            MessageBox.Show(str);
            Environment.Exit(0);
        }

        public class FileSaveException : ApplicationException {
            public FileSaveException(string message) : base(message) {

            }
        }
        public class OpenFileException : ApplicationException {
            public OpenFileException(string message) : base(message) {

            }
        }
        public class CreateFileException : ApplicationException {
            public CreateFileException(string message) : base(message) {

            }
        }
        public class DeserializeException : ApplicationException {
            public DeserializeException(string message) : base(message) {

            }
        }
        public class SerializeException : ApplicationException {
            public SerializeException(string message) : base(message) {

            }
        }
    }

}
