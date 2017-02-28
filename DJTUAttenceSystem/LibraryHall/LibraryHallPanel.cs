using System;
using System.Drawing;
using System.Windows.Forms;
using HelperSpace;
using DJTUAttenceSystem.Model;
using DJTUAttenceSystem.Course;

namespace DJTUAttenceSystem.LibraryHall {
    public partial class LibraryHallPanel : UserControl {
        public string libraryUUID;
        public AttandanceLibrary libraryRef {
            get {
                return GlobalStation.shareInstance.librarys[libraryUUID];
            }
        }
        private static Color fillColor = Helper.getColorByAddBri(Helper.ToColor(Helper.deepColor), +0.05f);
        public LibraryHallPanel() {
            InitializeComponent();
            configureEvent();
            configureColor();
            configureTableView();
            remarkLabel.txBox.ReadOnly = true;
        }
        /* ----- configuration ----- */
        private void configureTableView() {
            hkTableView1.mode = HKTableViewMode.horizental;
            hkTableView1.horizental_ResizeForEveryCell = contentInit_CellResize;
        }
        private void configureEvent() {
            Resize += resize;
            Load += LibraryHallPanel_Load;
        }
        private void configureColor() {
            topPanel.BackColor = fillColor;
            deleteButton.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            exportButton.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            addButton.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            backButton.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            editButton.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            remarkLabel.txBox.BackColor = fillColor;
        }
        private void LibraryHallPanel_Load(object sender, EventArgs e) {
            contentInit();
        }
        /* ----- Relate to content ----- */
        public void contentInit() {
            contentInit_initLibInfo();
            hkTableView1.clear();
            foreach (Model.Course course in libraryRef.allCourses()) {
                contentInit_addTableViewCell(course);
            }
            hkTableView1.HKTableView_Resize(null, null);
        }
        private void contentInit_initLibInfo() {
            title.contentText = libraryRef.name;
            remarkLabel.text = libraryRef.remarks;
        }
        private void contentInit_addTableViewCell(Model.Course course) {
            CourseCell cell = new CourseCell(course.name, course.remark);
            cell.tableView = hkTableView1;
            cell.libHall = this;
            cell.courseId = course.id;
            hkTableView1.add(cell);
        }
        private void contentInit_CellResize(Panel panel,Control control) {
            panel.Width = control.Width + 80;
            control.Height = panel.Height - 80;
            control.Location = new Point(panel.Width / 2 - control.Width / 2, panel.Height / 2 - control.Height / 2);
        }
        /* ----- Relate to Layout ----- */
        public void resize(object sender,EventArgs e) {
            Dock = DockStyle.Fill;
            layoutTitle();
            layoutRemark();
            layoutAddPanel();
        }
        private void layoutTitle() {
            title.Location = new Point(titlePicture.Width, topPanel.Height / 2 - title.Height / 2);
        }
        private void layoutRemark() {
            remarkPanel.Height = 150;
            remarkLabel.Height = 130;
            remarkLabel.Width = remarkPanel.Width - 80;
            remarkLabel.Location = new Point(remarkPanel.Width / 2 - remarkLabel.Width / 2,
                remarkPanel.Height / 2 - remarkLabel.Height / 2);
        }
        private void layoutAddPanel() {
            if (isAddPanelInControls()) {
                AddPanel addPanel = (AddPanel)Controls.Find("addPanel", false)[0];
                addPanel.Location = new Point(addButton.Location.X - 15, addButton.Location.Y + addButton.Height + 2);
            }
        }
        /* ----- Relate to addPanel ----- */
        private void addButton_Click(object sender, EventArgs e) {
            if (!isAddPanelInControls()) {
                includeAddPanel();
            } else {
                removeAddPanel();
            }
        }
        private void includeAddPanel() {
            AddPanel addPanel = new AddPanel();
            addPanel.Name = "addPanel";
            addPanel.add("创建课程", Color.ForestGreen, addPanel_createCourseBtn_Click);
            addPanel.add("导入课程", Color.OrangeRed, addPanel_importCourseBtn_Click);
            addPanel.addToParent(this);
            addPanel.Location = new Point(addButton.Location.X - 15, addButton.Location.Y + addButton.Height + 2);
            addPanel.Size = new Size(addButton.Width + 30, 130);
        }
        private void removeAddPanel() {
            AddPanel addPanel = (AddPanel)Controls.Find("addPanel",false)[0];
            addPanel.removeFromParent();
        }
        private bool isAddPanelInControls() {
            if (Controls.Find("addPanel", false).Length == 0) {
                return false;
            } else {
                return true;
            }
        }
        private void addPanel_createCourseBtn_Click(string title) {
            CourseEdit ce = new CourseEdit();
            ce.Dock = DockStyle.Fill;
            ce.close = course_create_back;
            ce.yes = course_create_yes;
            GlobalStation.shareInstance.entrance.showPanel(ce);
        }
        private void addPanel_importCourseBtn_Click(string title) {
            try {
                string path = HKOpenFileDialog.selectFile(HKDialogFilter.Course);
                Model.Course course = FileSerilizeOpener<Model.Course>.open(path);
                AttandanceLibrary lib = libraryRef;
                if (!lib.containsCourse(course.id)) {
                    lib.addCourse(course);
                } else {
                    overwriteOrCreateNew(lib, course);
                }
                GlobalStation.shareInstance.librarySave(delegate () {
                    contentInit();
                }, null);
            }catch(HKOpenFileDialog.CancelOpenFileException e) {
                Console.WriteLine(e.Message);
            }catch(FileSerilizeOpener<Model.Course>.FileOpenException e) {
                HKConfirmForm.showConfirmForm(e.Message);
            }
        }
        private void overwriteOrCreateNew(AttandanceLibrary lib, Model.Course course) {
            HKConfirmForm form = new HKConfirmForm();
            form.title = "已存在该课程Id，是否覆盖？";
            if (form.showConfirm() == true) {
                lib.removeCourse(lib[course.id]);
                lib.addCourse(course);
            } else {
                course.id = Guid.NewGuid().ToString();
                lib.addCourse(course);
            }
        }
        /* ----- Course Create ----- */
        public void course_create_back() {
            Console.WriteLine("course_create_back");
            LibraryHallPanel lhp = new LibraryHallPanel();
            lhp.libraryUUID = libraryUUID;
            GlobalStation.shareInstance.entrance.showPanel(lhp);
        }
        public void course_create_yes(NewCourseInfo courseInfo) {
            if (!libraryRef.containsCourse(courseInfo.id)) {
                showCourseHall(courseInfo);
            } else {
                HKConfirmForm.showConfirmForm("该课程号已经存在，请更改课程号");
            }
        }
        private void showCourseHall(NewCourseInfo courseInfo) {
            Record[] records = produceRecordsArray(courseInfo.weight);
            Model.Course course = createAndSaveCourse(courseInfo,records);
            if (course != null) {
                displayCourseHall(course);
            } else {
                HKConfirmForm.showConfirmForm("课程存储失败，请重新尝试");
            }
        }
        private Record[] produceRecordsArray(NewWeight weight) {
            Record attRecord = new Record(Record.RType.attendance, weight.attendance);
            Record lateRecord = new Record(Record.RType.late, weight.late);
            Record sickRecord = new Record(Record.RType.sickLeave, weight.sickLeave);
            Record busRecord = new Record(Record.RType.businessLeave, weight.businessLeave);
            Record absRecord = new Record(Record.RType.absenteeism, weight.absenteeism);
            Record[] records = { attRecord, lateRecord, sickRecord, busRecord, absRecord };
            return records;
        }
        private Model.Course createAndSaveCourse(NewCourseInfo courseInfo,Record[] records) {
            Model.Course course = new Model.Course(courseInfo.name, courseInfo.id, courseInfo.remark, records);
            libraryRef.addCourse(course);
            GlobalStation.shareInstance.librarySave(delegate () {
            }, delegate () {
                libraryRef.removeCourse(course);
                course = null;
            });
            return course;
        }
        public void displayCourseHall(Model.Course course) {
            CourseHall hall = new CourseHall();
            hall.libraryUUID = libraryUUID;
            hall.CourseId = course.id;
            GlobalStation.shareInstance.entrance.showPanel(hall);
        }
        /* ----- Other Event ----- */
        private void backButton_Click(object sender, EventArgs e) {
            Login l = new Login();
            GlobalStation.shareInstance.entrance.showPanel(l);
        }
        private void editButton_Click(object sender, EventArgs e) {
            LibraryEditForm lbEdit = new LibraryEditForm();
            lbEdit.libHall = this;
            lbEdit.ShowDialog();
        }
        private void exportButton_Click(object sender, EventArgs e) {
            try {
                string path = HKSaveFileDialog.saveTo(HKDialogFilter.Library);
                FileSerializeStorage<AttandanceLibrary>.save(libraryRef, path);
                HKConfirmForm.showConfirmForm("导出成功");
            }catch(HKSaveFileDialog.CancelSaveFileException) {
            }catch(FileSerializeStorage<AttandanceLibrary>.FileSaveException ex) {
                HKConfirmForm.showConfirmForm(ex.Message);
            }
        }
        private void deleteButton_Click(object sender, EventArgs e) {
            HKConfirmForm form = new HKConfirmForm();
            form.title = "确定要删除？";
            if (form.showConfirm() == true) {
                AttandanceLibrary lib = GlobalStation.shareInstance.librarys[libraryUUID];
                GlobalStation.shareInstance.librarys.removeLib(lib.UUID);
                GlobalStation.shareInstance.librarySave(delegate() {
                    backButton_Click(null, null);
                }, delegate () {
                    GlobalStation.shareInstance.librarys.addLib(lib);
                });
                
            }
        }
    }
}
