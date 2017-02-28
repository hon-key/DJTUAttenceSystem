using System;
using HelperSpace;
using System.Windows.Forms;
using System.Drawing;
using DJTUAttenceSystem.Model;
using System.Collections;
using System.Collections.Generic;

namespace DJTUAttenceSystem.Course {
    public enum mainGridCellIndex {
        delete = 0,Name,id,sex,major,grade,_class,courseAttribute,examMethod,examAttribute,isExamDelay,score,subAttStartIndex
    }
    public enum HallMode {
        editMode,
        freedomMode,
        orderMode,
        randomMode,
    }
    public partial class CourseHall : UserControl {
        public int subExtraStartIndex;
        public HallMode mode = HallMode.editMode;
        public string libraryUUID;
        public string CourseId;
        public Model.Course courseRef {
            get {
                AttandanceLibrary lib = GlobalStation.shareInstance.librarys[libraryUUID];
                return lib[CourseId];
            }
        }
        public int fixedRowIndex = 0;
        private int mainGridCurrentScrollPosition;
        private int mainGridCurrentRowIndex;
        private bool mainGrid_isRightMenuStripEnable = true;
        private AttandanceTask attandanceTask;
        private static Color backgroundColor = Helper.getColorByAddBri(Helper.ToColor(Helper.normalColor), -0.05f);
        private static Color deepBackgroundColor = Helper.ToColor(Helper.deepColor);
        private static Color selectionColor = Helper.getColorByAddBri(Helper.ToColor(Helper.normalColor), -0.15f);
        private static Color containerColor = Helper.getColorByAddBri(Helper.ToColor(Helper.normalColor), -0.08f);
        public CourseHall() {
            InitializeComponent();
            this.Load += CourseHall_Load;
            configureLayout();
            configureBar();
            configureDataGridView();
            configureTabsControl();
            changeToEditMode("编辑模式");
        }
        private void CourseHall_Load(object sender, EventArgs e) {
            initGeneralContent();
            initTabsContent();
            initTableViewContent();
        }

        #region /* ----- Configuration ----- */
        private void configureLayout() {
            Dock = DockStyle.Fill;
            Resize += resize;
        }
        private void configureBar() {
            bar.BackColor = Helper.getColorByAddBri(Helper.ToColor(Helper.normalColor), -0.05f);
            bar_deleteBtn.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            bar_settingBtn.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            bar_modeBtn.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            bar_backBtn.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
        }
        private void configureDataGridView() {
            mainGridBorderPanel.BackColor = deepBackgroundColor;
            mainGrid.BackgroundColor = backgroundColor;
            mainGrid.ColumnHeadersDefaultCellStyle.BackColor = backgroundColor;
            mainGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = selectionColor;
            mainGrid.RowHeadersDefaultCellStyle.BackColor = mainGrid.BackgroundColor;
            mainGrid.RowHeadersDefaultCellStyle.SelectionBackColor = selectionColor;
            mainGrid.DefaultCellStyle.BackColor = backgroundColor;
            mainGrid.DefaultCellStyle.SelectionBackColor = selectionColor;
            mainGrid.CellClick += MainGrid_CellClick;
            mainGrid.CellBeginEdit += MainGrid_CellBeginEdit;
            mainGrid.CellMouseMove += fixRowSelection_InOrderAndRandomMode;
        }
        private void configureTabsControl() {
            tabs.borderColor = deepBackgroundColor;
            tabs.containerBackColor = backgroundColor;
            tabs.mouseOverColor = Color.ForestGreen;
            tabs.setTabHandler(tabsBtn_Click);
            tabs.rightClick = tabBtnMenuMethod;
        }
        public void initGeneralContent() {
            courseTitle.contentText = courseRef.name;
            
        }
        public void initTabsContent() {
            tabs.clearAllTabs();
            foreach (StuList stuList in courseRef.allStulist()) {
                tabs.addNewTab(stuList.name,stuList.UUID);
            }
        }
        public void initTableViewContent() {
            mainGridCurrentScrollPosition = mainGrid.HorizontalScrollingOffset;
            if (mainGrid.CurrentRow != null) {
                mainGridCurrentRowIndex = mainGrid.CurrentRow.Index;
            }
            clearContent();
            Model.Course course = courseRef;
            init_subAttandanceColumn(course);
            init_subExtraColumn(course);
            string StuListUUID = SelectedStuListUUID;
            StuList stuList = course.getStuList(StuListUUID);
            if (stuList != null) {
                init_rows(course, stuList);
            }
            startCellValueChanged();
            mainGrid.HorizontalScrollingOffset = mainGridCurrentScrollPosition;
            setSeletedRow(mainGridCurrentRowIndex);
        }
        private void clearContent() {
            mainGrid.Rows.Clear();
            int maxIndex = (int)(mainGridCellIndex.score) + 1;
            while (mainGrid.Columns.Count != maxIndex) {
                mainGrid.Columns.Remove(mainGrid.Columns[maxIndex]);
            }
            stopCellValueChanged();

        }
        private void init_subAttandanceColumn(Model.Course course) {
            foreach (SubAttandance subAtt in course.allSubAttandances()) {
                mainGrid.Columns.Add(init_createColumn(subAtt));
            }
        }
        private void init_subExtraColumn(Model.Course course) {
            subExtraStartIndex = mainGrid.Columns.Count;
            foreach (subExtra extra in course.allExtras()) {
                mainGrid.Columns.Add(init_createColumn(extra));
            }
        }
        public DataGridViewComboBoxColumn init_createColumn(subExtra extra) {
            DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
            setComboBoxColumnStyle(column);
            column.HeaderText = extra.name;
            column.Name = extra.UUID;
            column.ContextMenuStrip = HKMenuStrip.createRightMenu(
                new HKMenuStrip.ItemStruct("修改考勤记录标题", modifyExtraTitle, column),
                new HKMenuStrip.ItemStruct("删除该列考勤记录", confirmToExtraDelete, column));
            setComboBoxColumnContent(column, extra);
            return column;
        }
        public DataGridViewComboBoxColumn init_createColumn(SubAttandance subAtt) {
            Model.Course course = courseRef;
            string title = subAtt.date.ToString("m");
            DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
            setComboBoxColumnStyle(column);
            column.HeaderText = title;
            column.Name = subAtt.UUID;
            column.ContextMenuStrip = HKMenuStrip.createRightMenu(
                new HKMenuStrip.ItemStruct("删除该列考勤记录", confirmToAttandaceDelete, column));
            foreach (Record record in course.getAllRecords()) {
                column.Items.Add(record.recordString());
            }
            return column;
        }
        private void setComboBoxColumnStyle(DataGridViewComboBoxColumn column) {
            column.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            column.FlatStyle = FlatStyle.Flat;
        }
        private void setComboBoxColumnContent(DataGridViewComboBoxColumn column,subExtra extra) {
            foreach (checkType type in extra.getAllCheckType()) {
                column.Items.Add(type.typeName);
            }
        }
        private void init_rows(Model.Course course,StuList stuList) {
            foreach (Student stu in stuList.allStudents()) {
                int newRowIndex = mainGrid.Rows.Add();
                DataGridViewRow newRow = mainGrid.Rows[newRowIndex];
                init_rows_baseAttributeInit(newRow, stu);
                init_rows_attandanceInit(newRow, course.allSubAttandances(), stu);
                init_rows_extrasInit(newRow, course.allExtras(), stu);
            }
        }
        private void init_rows_baseAttributeInit(DataGridViewRow newRow,Student stu) {
            newRow.Height = 25;
            cell(newRow, mainGridCellIndex.Name).Value = stu.name;
            cell(newRow, mainGridCellIndex.id).Value = stu.id;
            cell(newRow, mainGridCellIndex.sex).Value = stu.sexToString();
            cell(newRow, mainGridCellIndex.major).Value = stu.major.name;
            cell(newRow, mainGridCellIndex.grade).Value = stu.major.grade;
            cell(newRow, mainGridCellIndex._class).Value = stu.major._class;
            cell(newRow, mainGridCellIndex.courseAttribute).Value = stu.courseAttributeToString();
            cell(newRow, mainGridCellIndex.examMethod).Value = stu.examMethodToString();
            cell(newRow, mainGridCellIndex.examAttribute).Value = stu.examAttributeToString();
            cell(newRow, mainGridCellIndex.isExamDelay).Value = stu.isExamDelayToString();
            cell(newRow, mainGridCellIndex.score).Value = stu.score;
        }
        private void init_rows_attandanceInit(DataGridViewRow newRow,ArrayList subAtts,Student stu) {
            foreach (SubAttandance subAtt in subAtts) {
                StuAttandance stuAtt = stu.getAttandance(subAtt.UUID);
                if (stuAtt != null) {
                    int CellIndex = getColumnIndexByName(subAtt.UUID);
                    newRow.Cells[CellIndex].Value = stuAtt.record.recordString();
                    Color cellColor = stuAtt.record.recordColor;
                    newRow.Cells[CellIndex].Style.BackColor = 
                        (cellColor != Color.Empty) ? cellColor : backgroundColor;
                }
            }
        }
        private void init_rows_extrasInit(DataGridViewRow newRow,ArrayList extras,Student stu) {
            foreach (subExtra subExt in extras) {
                StuExtra stuExt = stu.getStuExtra(subExt.UUID);
                if (stuExt != null) {
                    int cellIndex = getColumnIndexByName(subExt.UUID);
                    newRow.Cells[cellIndex].Value = stuExt.result.typeName;
                    Color cellColor = stuExt.result.typeColor;
                    newRow.Cells[cellIndex].Style.BackColor =
                        (cellColor != Color.Empty) ? cellColor : backgroundColor;

                }
            }
        }
        #endregion

        #region /* ----- Layout ----- */
        public void resize(object sender, EventArgs e) {
            layoutBar();
            layoutMainGridPanel();
            layoutDataGridView();
            layoutTabsControl();
            layoutBottom();
            layoutAttandanceTaskPanel();
        }
        private void layoutBar() {
            courseTitle.Location = new Point(20, bar.Height / 2 - courseTitle.Height / 2);
        }
        private void layoutMainGridPanel() {
            mainGridBorderPanel.Location = new Point(100, 100);
            mainGridBorderPanel.Width = mainPanel.Width - 200; mainGridBorderPanel.Height = mainPanel.Height - 200;

            mainGrid_addRowBtn.Location = new Point(mainGridBorderPanel.Location.X - mainGrid_addRowBtn.Width,
                mainGridBorderPanel.Location.Y + mainGridBorderPanel.Height - mainGrid_addRowBtn.Height + 10);
            mainGrid_extraAddBtn.Location =
                new Point(mainGridBorderPanel.Location.X + mainGridBorderPanel.Width, mainGridBorderPanel.Location.Y - 10);
        }
        private void layoutDataGridView() {
            mainGrid.Location = new Point(2, 2);
            mainGrid.Width = mainGridBorderPanel.Width - 4;
            mainGrid.Height = mainGridBorderPanel.Height - 4;
        }
        private void layoutTabsControl() {
            tabs.Location = new Point(mainGridBorderPanel.Location.X, mainGridBorderPanel.Location.Y - tabs.Height - 5);
            tabs.Width = mainGridBorderPanel.Width;
            tabs.Height = 30;
            tabs_addBtn.Location = new Point(tabs.Location.X - tabs_addBtn.Width, tabs.Location.Y);
        }
        private void layoutBottom() {
            modeLabel.Location = new Point(10, 10);
            excelExport.Location = new Point(mainPanel.Width - excelExport.Width, mainPanel.Height - excelExport.Height);
            excelImport.Location = new Point(excelExport.Location.X - scoreCalBtn.Width, excelExport.Location.Y);
            scoreCalBtn.Location = new Point(excelImport.Location.X - scoreCalBtn.Width, excelImport.Location.Y);
            reportBtn.Location = new Point(scoreCalBtn.Location.X - reportBtn.Width, scoreCalBtn.Location.Y);
        }
        private void layoutAttandanceTaskPanel() {
            if (attandanceTask != null) {
                attandanceTask.operationPanel.Location = new Point(
                        mainGridBorderPanel.Location.X + mainGridBorderPanel.Width / 2 - attandanceTask.operationPanel.Width / 2,
                        mainGridBorderPanel.Location.Y + mainGridBorderPanel.Height + 5);
            }
        }
        #endregion

        private void bar_backBtn_Click(object sender, EventArgs e) {
            if (attandanceTask != null) { attandanceTask.cancel();}
            LibraryHall.LibraryHallPanel hall = new LibraryHall.LibraryHallPanel();
            hall.libraryUUID = libraryUUID;
            GlobalStation.shareInstance.entrance.showPanel(hall);
        }
        private void bar_settingBtn_Click(object sender, EventArgs e) {
            CourseHallEditForm.showForm(this);
        }
        private void bar_deleteBtn_Click(object sender, EventArgs e) {
            AttandanceLibrary lib = GlobalStation.shareInstance.librarys[libraryUUID];
            Model.Course course = courseRef;
            HKConfirmForm form = new HKConfirmForm();
            form.title = string.Format("确定要删除课程《{0}》?", course.name);
            if (form.showConfirm() != true) return;
            if (lib.containsCourse(course.id)) {
                lib.removeCourse(course);
            }
            GlobalStation.shareInstance.librarySave(delegate () {
                bar_backBtn_Click(null, null);
            }, delegate () {
                lib.addCourse(course);
            });
        }
        /* ----- Cell Operation ----- */
        private void MainGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) {return;}
            string columnName = mainGrid.Columns[e.ColumnIndex].HeaderText;
            if (e.ColumnIndex == (int)mainGridCellIndex.delete) {
                confirmToStudentDelete(e.RowIndex);
            }
        }
        private void confirmToStudentDelete(int rowIndex) {
            mainGrid.Rows[rowIndex].Selected = true;
            HKConfirmForm confirm = new HKConfirmForm();
            confirm.title = string.Format("是否删除 {0}", getRowValue(rowIndex,mainGridCellIndex.Name));
            if (confirm.showConfirm() == true) {
                deleteStudent(rowIndex);
            }
        }
        private void deleteStudent(int rowIndex) {
            StuList stuList = null;
            Student stu = null;
            string studentId = getRowValue(rowIndex, mainGridCellIndex.id);
            Model.Course course = courseRef;
            string stuListId = SelectedStuListUUID;
            stuList = course.getStuList(stuListId);
            stu = stuList[studentId];
            stuList.removeStudent(studentId);
            GlobalStation.shareInstance.librarySave(delegate () {
                mainGrid.Rows.Remove(mainGrid.Rows[rowIndex]);
            }, delegate () {
                stuList.addStudent(stu);
            });
        }
        private void confirmToAttandaceDelete(string itemText, object userData) {
            HKConfirmForm confirmForm = new HKConfirmForm();
            confirmForm.title = "是否删除考勤记录：" + itemText;
            if (confirmForm.showConfirm() == true) {
                DataGridViewColumn column = (DataGridViewColumn)userData;
                deleteAttandance(column.Name);
            }
        }
        private void deleteAttandance(string attandanceUUID) {
            Model.Course course = courseRef;
            foreach (StuList stuList in course.allStulist()) {
                foreach (Student stu in stuList.allStudents()) {
                    stu.removeAttandance(attandanceUUID);
                }
            }
            course.removeAttandance(attandanceUUID);
            GlobalStation.shareInstance.librarySave(delegate () {
                mainGrid.Columns.Remove(mainGrid.Columns[attandanceUUID]);
            }, delegate () {
                GlobalStation.shareInstance.librarysInit();
            });
        }
        private void confirmToExtraDelete(string itemText, object userData) {
            DataGridViewColumn column = (DataGridViewColumn)userData;
            HKConfirmForm confirmForm = new HKConfirmForm();
            confirmForm.title = "是否删除考勤记录：" + column.HeaderText;
            if (confirmForm.showConfirm() == true) {
                deleteExtra(column.Name);
            }
            
        }
        private void deleteExtra(string extraUUID) {
            Model.Course course = courseRef;
            foreach (StuList stuList in course.allStulist()) {
                foreach (Student stu in stuList.allStudents()) {
                    stu.removeStuExtra(extraUUID);
                }
            }
            course.removeExtra(extraUUID);
            GlobalStation.shareInstance.librarySave(delegate () {
                mainGrid.Columns.Remove(mainGrid.Columns[extraUUID]);
            }, delegate () {
                GlobalStation.shareInstance.librarysInit();
            });
        }
        private void modifyExtraTitle(string itemText, object userData) {
            DataGridViewColumn column = userData as DataGridViewColumn;
            InputResult result = HKTextInputForm.showInputform("修改标题", column.HeaderText);
            subExtra subExt = null;
            string oldTitle = null;
            if (result.confirm) {
                string extraUUID = column.Name;
                subExt = courseRef.getExtra(extraUUID);
                oldTitle = subExt.name;
                subExt.name = result.input;
                GlobalStation.shareInstance.librarySave(delegate () {
                    stopCellValueChanged();
                    column.HeaderText = result.input;
                    startCellValueChanged();
                }, delegate () {
                    subExt.name = oldTitle;
                });
            }
        }
        private void fixRowSelection_InOrderAndRandomMode(object sender, DataGridViewCellMouseEventArgs e) {
            if (mode == HallMode.orderMode || mode == HallMode.randomMode) {
                setSeletedRow(fixedRowIndex);
            }
        }
        /* ----- Cell modification ----- */
        private string editingStudentId = null;
        private void MainGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {
            editingStudentId = getRowValue(e.RowIndex, mainGridCellIndex.id);
        }
        private void MainGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            Model.Course course = courseRef;
            StuList stuList = course.getStuList(SelectedStuListUUID);
            
            if (e.ColumnIndex < (int)mainGridCellIndex.subAttStartIndex) {
                mainGridCellIndex index = (mainGridCellIndex)e.ColumnIndex;
                string value = getRowValue(e.RowIndex, index);
                changeBaseAttribute(stuList, index, value);
            } else {
                changeSpecalAttribute(course, stuList, e);
            }
            saveChange();
        }
        private void changeBaseAttribute(StuList stuList, mainGridCellIndex index, string value) {
            Student stu = stuList[editingStudentId];
            switch (index) {
                case mainGridCellIndex.Name: stu.name = value; break;
                case mainGridCellIndex.id:setStuId(stuList, stu, value);break;
                case mainGridCellIndex.sex: stu.sex = Student.stringToSex(value); break;
                case mainGridCellIndex.major: stu.major.name = value; break;
                case mainGridCellIndex.grade: stu.major.grade = value; break;
                case mainGridCellIndex._class: stu.major._class = value; break;
                case mainGridCellIndex.courseAttribute: stu.courseAttribute = Student.stringToCourseAttribute(value); break;
                case mainGridCellIndex.examMethod: stu.examMethod = Student.stringToExamMethod(value); break;
                case mainGridCellIndex.examAttribute: stu.examAttribute = Student.stringToExamAttribute(value); break;
                case mainGridCellIndex.isExamDelay: stu.isExamDelay = Student.stringToIsExamDelay(value); break;
                case mainGridCellIndex.score: stu.score = value; break;
                case mainGridCellIndex.subAttStartIndex: break;
                default: break;
            }
        }
        private void changeSpecalAttribute(Model.Course course, StuList stuList, DataGridViewCellEventArgs e) {
            Student stu = stuList[editingStudentId];
            DataGridViewColumn column = mainGrid.Columns[e.ColumnIndex];
            string UUID = column.Name;
            SubAttandance subAtt = course.getSubAttandance(UUID);
            string value = (string)mainGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (subAtt != null) {
                Record recordToChangeTo = course.getRecord(value);
                changeAttandance(stu, subAtt, recordToChangeTo);
                mainGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = recordToChangeTo.recordColor;
            } else {
                subExtra subExt = course.getExtra(UUID);
                changeExtra(stu, subExt, value);
                mainGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = subExt[value].typeColor;
            }
        }
        private void saveChange() {
            GlobalStation.shareInstance.librarySave(null, delegate () {
                GlobalStation.shareInstance.librarysInit();
            });
        }
        private void changeAttandance(Student stu, SubAttandance subAtt, Record record) {
            StuAttandance stuAtt = stu.getAttandance(subAtt.UUID);
            if (stuAtt == null) {
                stuAtt = new StuAttandance(subAtt, record);
                stu.addAttandance(stuAtt);
            } else {
                stuAtt.date = subAtt.date;
                stuAtt.UUID = subAtt.UUID;
                stuAtt.record = record;
            }
        }
        private void changeExtra(Student stu, subExtra subExt, string value) {
            StuExtra stuExt = stu.getStuExtra(subExt.UUID);
            if (stuExt == null) {
                stuExt = new StuExtra(subExt, value);
                stu.addStuExtra(stuExt);
            } else {
                stuExt.name = subExt.name;
                stuExt.result = subExt[value];
            }
        }
        private void setStuId(StuList stuList,Student stu,string id) {
            if (stuList[id] == null) {
                stu.id = id;
            } else {
                HKConfirmForm.showConfirmForm("该学号已经存在！");
            }
        }
        /* ----- TabsControl ----- */
        public void tabsBtn_Click(string title,int index, object userData) {
            Console.WriteLine(index);
            initTableViewContent();
        }
        public void tabBtnMenuMethod(string title,int index,string itemString,object userData) {
            Console.WriteLine(title + " " + index + " " + itemString + " " + userData);
            if (itemString.Equals("删除")) {
                tabBtnMenuMethod_ConfirmToDelete(title,userData);
            } else if (itemString.Equals("改名")) {
                tabBtnMenuMethod_ConfirmToChange(title, userData);
            }
        }
        private void tabBtnMenuMethod_ConfirmToDelete(string title,object userData) {
            HKConfirmForm confirmForm = new HKConfirmForm();
            confirmForm.title = "确定要删除《" + title + "》？";
            bool result = confirmForm.showConfirm();
            if (result == true) {
                tabBtnMenuMethod_DeleteStuList((string)userData);
            }
        }
        private void tabBtnMenuMethod_ConfirmToChange(string title,object userData) {
            HKTextInputForm inputForm = new HKTextInputForm();
            inputForm.titleText = "修改名称";
            inputForm.textBox.text = title;
            InputResult result = inputForm.showTextInputForm();
            if (result.confirm) {
                tabBtnMenuMethod_ChangeName((string)userData, result.input);
            }
        }
        private void tabBtnMenuMethod_DeleteStuList(string stuListUUID) {
            Model.Course course = null;
            StuList stuList = null;
            course = courseRef;
            stuList = course.removeStuList(stuListUUID);
            GlobalStation.shareInstance.librarySave(null, delegate () {
                course.addStuList(stuList);
            });
            initTabsContent();
            initTableViewContent();
        }
        private void tabBtnMenuMethod_ChangeName(string uuid,string name) {
            Model.Course course = courseRef;
            StuList stuList = course.getStuList(uuid);
            string originName = stuList.name;
            stuList.name = name;
            GlobalStation.shareInstance.librarySave(null, delegate () {
                stuList.name = originName;
            });
            initTabsContent();
        }
        private void tabs_addBtn_Click(object sender, EventArgs e) {
            HKTextInputForm inputForm = new HKTextInputForm();
            inputForm.titleText = "新名单名";
            InputResult result = inputForm.showTextInputForm();
            if (result.confirm == true) {
                tabs_addNewStuList(result.input);
            }
        }
        private void tabs_addNewStuList(string title) {
            Model.Course course = courseRef;
            StuList stuList = createStuList(title);
            course.addStuList(stuList);
            GlobalStation.shareInstance.librarySave(null, delegate () {
                course.removeStuList(stuList.UUID);
            });
            initTabsContent();

        }
        private StuList createStuList(string title) {
            Model.Course course = courseRef;
            StuList stuList = new StuList();
            stuList.name = title;
            return stuList;
        }
        /* ----- Mode change ----- */
        private void bar_modeBtn_Click(object sender, EventArgs e) {
            if (!isAddPanelContainInControls()) {
                includeAddPanel();
            } else {
                removeAddPanel();
            }
        }
        private bool isAddPanelContainInControls() {
            if (Controls.Find("addPanel", false).Length == 0) {
                return false;
            }else {
                return true;
            }
        }
        private void includeAddPanel() {
            AddPanel addPanel = new AddPanel();
            addPanel.Name = "addPanel";
            addPanel.add("编辑模式", Color.ForestGreen, changeToEditMode);
            addPanel.add("自由点名", Color.DarkGoldenrod, changeToFreeMode);
            addPanel.add("顺序点名", Color.DarkOrange, changeToOrderMode);
            addPanel.add("随机点名", Color.OrangeRed, changeToRandomMode);
            addPanel.addToParent(this);
            addPanel.Location = new Point(bar_modeBtn.Location.X - 15, bar_modeBtn.Location.Y + bar_modeBtn.Height + 2);
            addPanel.Size = new Size(bar_modeBtn.Width + 30, 150);
        }
        private void removeAddPanel() {
            AddPanel addPanel = (AddPanel)Controls.Find("addPanel", false)[0];
            addPanel.removeFromParent();
        }
        public void changeToEditMode(string title) {
            if (mode == HallMode.editMode) { return; }
            modeLabel.Text = "编辑模式";
            mode = HallMode.editMode;
            mainGrid.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            mainGrid.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            editModeVisibleSetting(true);
            if (attandanceTask != null) { attandanceTask.cancel(); }
        }
        public void changeToFreeMode(string title) {
            if (mode == HallMode.freedomMode) { return; }
            modeLabel.Text = "自由模式";
            mode = HallMode.freedomMode;
            mainGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            mainGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            editModeVisibleSetting(false);
            beginAttandance(mode);

        }
        public void changeToOrderMode(string title) {
            if (mode == HallMode.orderMode) { return; }
            modeLabel.Text = "顺序模式";
            mode = HallMode.orderMode;
            mainGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            mainGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            editModeVisibleSetting(false);
            beginAttandance(mode);
        }
        public void changeToRandomMode(string title) {
            if (mode == HallMode.randomMode) { return; }
            modeLabel.Text = "随机模式";
            mode = HallMode.randomMode;
            mainGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            mainGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            editModeVisibleSetting(false);
            beginAttandance(mode);
        }
        private void editModeVisibleSetting(bool value) {
            mainGrid_addRowBtn.Visible = value;
            mainGrid_extraAddBtn.Visible = value;
            mainGrid_isRightMenuStripEnable = value;
            tabs_addBtn.Visible = value;
            setColumnVisible("delete", value);
            excelExport.Visible = value;
            excelImport.Visible = value;
            scoreCalBtn.Visible = value;
            reportBtn.Visible = value;

        }
        private void beginAttandance(HallMode mode) {
            if (attandanceTask != null) { attandanceTask.cancel(); }
            attandanceTask = AttandanceTask.createAttandanceTask(this,mainPanel);
            layoutAttandanceTaskPanel();
            attandanceTask.hall = this;
        }

        /* ----- Bottom button ----- */
        private void excelBtn_Click(object sender, EventArgs e) {
            selectResult result = HKSelectForm.showSelectForm("导出目前名单", "导出总名单");
            if (result.confirm) {
                excelBtn_SelectConfirm(result.title);
            }
        }
        private void excelBtn_SelectConfirm(string title) {
            List<StuList> lists = new List<StuList>();
            if (title.Equals("导出目前名单") && tabs.selectedIndex == -1) {
                HKConfirmForm.showConfirmForm("请先选择名单");
                return;
            }
            if (title.Equals("导出目前名单") && tabs.selectedIndex != -1) {
                lists.Add(SelectedStuList);
            } else if (title.Equals("导出总名单")) {
                foreach (StuList item  in courseRef.allStulist()) {
                    lists.Add(item);
                }
            }
            exportStulists(lists);
        }
        private void exportStulists(List<StuList> lists) {
            try {
                string path = HKSaveFileDialog.saveTo(HKDialogFilter.Excel);
                ExcelExporter exporter = ExcelExporter.createExporter(lists, courseRef, path);
                exporter.export();
                HKConfirmForm.showConfirmForm("导出成功");
            } catch (ExcelExporter.ParseException e) {
                HKConfirmForm.showConfirmForm(e.Message);
            } catch (ExcelExporter.ExportException e) {
                HKConfirmForm.showConfirmForm(e.Message);
            } catch (HKSaveFileDialog.CancelSaveFileException) { }
        }
        private void scoreCalBtn_Click(object sender, EventArgs e) {
            if (tabs.selectedIndex == HKTab.unselected || mainGrid.SelectedCells.Count == 0) { return;}
            DataGridViewCell cell = mainGrid.SelectedCells[0];
            if (mainGrid.Columns[cell.ColumnIndex].HeaderText.Equals("成绩")) {
                calTheStudentScore();
            }else {
                createConfirmForm();
            }
        }
        private void createConfirmForm() {
            HKConfirmForm confirmForm = new HKConfirmForm();
            confirmForm.title = "当前没选中任何学生的成绩单元格，是否自动计算所有学生的成绩？";
            if (confirmForm.showConfirm() == true) {
                calAllStudentsScore();
            } else {
                Console.WriteLine("no! back!");
            }
        }
        private void calTheStudentScore() {
            ScoreCal cal = ScoreCal.createForCourse(courseRef);
            Student stu = SelectedStuList[getRowValue(mainGrid.CurrentRow.Index, mainGridCellIndex.id)];
            cal.calStudentScore(stu);
            GlobalStation.shareInstance.librarySave(delegate () {
                mainGrid_RefreshAllScore();
            }, null);
        }
        private void calAllStudentsScore() {
            ScoreCal cal = ScoreCal.createForCourse(courseRef);
            foreach (Student stu in SelectedStuList.allStudents()) {
                cal.calStudentScore(stu);
            }
            GlobalStation.shareInstance.librarySave(delegate () {
                mainGrid_RefreshAllScore();
            }, null);
        }
        private void mainGrid_RefreshAllScore() {
            stopCellValueChanged();
            foreach (DataGridViewRow row in mainGrid.Rows) {
                Student student = SelectedStuList[getRowValue(row.Index, mainGridCellIndex.id)];
                row.Cells[(int)mainGridCellIndex.score].Value = student.score;
            }
            startCellValueChanged();
        }
        private void reportBtn_Click(object sender, EventArgs e) {
            if (tabs.selectedIndex != -1) {
                CourseReport.showCourseReport(tabs.selectedTitle, SelectedStuList,courseRef);
            }
        }
        private void excelImport_Click(object sender, EventArgs e) {
            try {
                string fileName = HKOpenFileDialog.selectFile(HKDialogFilter.Excel);
                ExcelReader reader = ExcelReader.createReader(fileName);
                List<StuList> list = reader.stuListsClassifyByClass();
                Model.Course course = courseRef;
                foreach (StuList item in list) {
                    if (course.containsStuListByName(item.name)) {
                        course.getStuListByName(item.name).appendStudents(item);
                    }else {
                        course.addStuList(item);
                    }
                }
                GlobalStation.shareInstance.librarySave(delegate () {
                    initTabsContent();
                }, null);
            }catch(ExcelReader.ExcelOpenFailedException ex) {
                MessageBox.Show("文件打开失败:{0}", ex.Message);
            }catch(HKOpenFileDialog.CancelOpenFileException ex) {
                Console.WriteLine(ex.Message);
            }
        }
        /* ---- addRowBtn ---- */
        private void mainGrid_addRowBtn_Click(object sender, EventArgs e) {
            if (tabs.selectedIndex == HKTab.unselected) {return;}
            selectResult result = createRowAddSelectForm();
            if (result.confirm) {
                if (result.title.Equals("手工录入")) { DIY(); }
                else if (result.title.Equals("Excel导入(覆盖)")) { addRowByExcelWithCoverEnable(true); }
                else if (result.title.Equals("Excel导入(添加)")) { addRowByExcelWithCoverEnable(false); }
            }
        }
        private selectResult createRowAddSelectForm() {
            HKSelectForm selectForm = new HKSelectForm();
            selectForm.checkBackColor = Color.DarkMagenta;
            selectForm.addRadio("手工录入");
            selectForm.addRadio("Excel导入(覆盖)");
            selectForm.addRadio("Excel导入(添加)");
            selectForm.Width = 450;
            selectForm.Height = 150;
            return selectForm.showSelect();
        }
        private void DIY(){
            string newStuIdString;
            string major, grade, _class;
            Model.Course course = courseRef;
            string selectedStuListId = SelectedStuListUUID;
            StuList stuList = course.getStuList(selectedStuListId);

            newStuIdString = DIY_calTheMaxStudentId(stuList);
            DIY_getMajorInfoOfLastStudent(stuList, out major, out grade, out _class);
            Student stu = DIY_createNewStudent(newStuIdString,major,grade,_class);
            stuList.addStudent(stu);
            GlobalStation.shareInstance.librarySave(null, delegate () {
                stuList.removeStudent(stu.id);
            });
            maingrid_addRow(stu);
        }
        private string DIY_calTheMaxStudentId(StuList stuList) {
            long newStuId = 0;
            ArrayList allStudents = stuList.allStudents();
            foreach (Student item in allStudents) {
                long itemId = long.Parse(item.id);
                if (itemId > newStuId) {
                    newStuId = itemId;
                }
            }
            newStuId++;
            return "" + newStuId;
        }
        private void DIY_getMajorInfoOfLastStudent(StuList stuList,out string major,out string grade,out string _class) {
            try {
                ArrayList allStudents = stuList.allStudents();
                Student lastStudent = (Student)(allStudents[allStudents.Count - 1]);
                major = lastStudent.major.name;
                grade = lastStudent.major.grade;
                _class = lastStudent.major._class;
            } catch (ArgumentOutOfRangeException e) {
                Console.WriteLine(e);
                major = "未命名";
                grade = "未命名";
                _class = "未命名";
            }
        }
        private Student DIY_createNewStudent(string id,string major,string grade, string _class) {
            Student stu = new Student("新学生", Sex.male, id);
            stu.major = new Major(major, grade, _class);
            stu.courseAttribute = Model.CourseAttribute.required;
            stu.examMethod = ExamMethod.unconfirmed;
            stu.examAttribute = ExamAttribute.normal;
            stu.isExamDelay = false;
            return stu;
        }
        private void addRowByExcelWithCoverEnable(bool coverEnable) {
            try {
                string fileName = HKOpenFileDialog.selectFile(HKDialogFilter.Excel);
                ExcelReader reader = ExcelReader.createReader(fileName);
                StuList currentStuList = SelectedStuList;
                if (coverEnable) { currentStuList.clear(); }
                StuList stulist = reader.appendStudentsToList(currentStuList);
                GlobalStation.shareInstance.librarySave(delegate () {
                    initTableViewContent();
                }, delegate () {
                    GlobalStation.shareInstance.librarysInit();
                });
            } catch(ExcelReader.ExcelOpenFailedException e) {
                MessageBox.Show("文件打开失败:{0}",e.Message);
            }catch(ExcelReader.StudentParseException e) {
                MessageBox.Show("文件解析失败:{0}", e.Message);
            }catch(HKOpenFileDialog.CancelOpenFileException) { }
        }
        /* ---- ExtraBtn ---- */
        private void mainGrid_extraAddBtn_Click(object sender, EventArgs e) {
            if (tabs.selectedIndex == HKTab.unselected) { return;}
            ExtraAddForm extraAddForm = new ExtraAddForm();
            ExtraAddForm.ExtraResult result = extraAddForm.showForm();
            if (result.confirm) {
                addAnExtraItem(result.subExt);
            }
        }
        private void addAnExtraItem(subExtra subExt) {
            Model.Course course = courseRef;
            if (!course.containsExtra(subExt.name)) {
                course.addExtra(subExt);
                GlobalStation.shareInstance.librarySave(delegate () {
                    mainGrid.Columns.Add(init_createColumn(subExt));
                }, delegate () {
                    course.removeExtra(subExt.UUID);
                });
            } else {
                HKConfirmForm.showConfirmForm("已有同名的考勤项目存在");
            }
        }

        /* ----- Helper ----- */
        public void setColumnVisible(string key, bool visible) {
            foreach (DataGridViewColumn co in mainGrid.Columns) {
                if (co.Name.Equals(key)) {
                    co.Visible = visible;
                }
            }
        }
        public string getRowValue(int rowIndex, mainGridCellIndex index) {
            return (string)mainGrid.Rows[rowIndex].Cells[(int)index].Value;
        }
        public int getColumnIndexByName(string name) {
            foreach (DataGridViewColumn column in mainGrid.Columns) {
                if (column.Name.Equals(name)) {
                    return column.Index;
                }
            }
            return -1;
        }
        public DataGridViewCell cell(DataGridViewRow row,mainGridCellIndex index) {
            return row.Cells[(int)index];
        }
        public void setSeletedRow(int rowIndex) {
            if (mainGrid.Rows.Count > rowIndex) {
                DataGridViewRow row = mainGrid.Rows[rowIndex];
                row.Selected = true;
                mainGrid.CurrentCell = row.Cells[1];
            }
        }
        public string SelectedStuListUUID{
            get {
                return (string)tabs.userDataOfSelectedIndex();
            }
        }
        public StuList SelectedStuList {
            get {
                return courseRef.getStuList(SelectedStuListUUID);
            }
        }
        public void maingrid_addRow(Student stu) {
            Model.Course course = courseRef;
            int rowIndex = mainGrid.Rows.Add();
            DataGridViewRow row = mainGrid.Rows[rowIndex];
            stopCellValueChanged();
            init_rows_baseAttributeInit(row, stu);
            init_rows_attandanceInit(row, course.allSubAttandances(), stu);
            init_rows_extrasInit(row, course.allExtras(), stu);
            startCellValueChanged();
        }
        public void stopCellValueChanged() {
            mainGrid.CellValueChanged -= MainGrid_CellValueChanged;
        }
        public void startCellValueChanged() {
            mainGrid.CellValueChanged += MainGrid_CellValueChanged;
        }
        public void updateCourseInfo(string name,string id,string remark) {
            courseTitle.contentText = name;

        }

    }
}
