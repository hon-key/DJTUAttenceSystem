using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using HelperSpace;
using DJTUAttenceSystem.Model;

namespace DJTUAttenceSystem.LibraryHall {
    public partial class CourseCell : UserControl {
        public static Color bgColor = Helper.getColorByAddBri(Helper.ToColor(Helper.deepColor), +0.05f);
        public HKTableView tableView;
        public string courseId;
        public LibraryHallPanel libHall;
        public CourseCell() {
            InitializeComponent();
            init("unkown", "unkown");
        }
        public CourseCell(string title,string remark) {
            InitializeComponent();
            init(title, remark);
        }
        private void init(string title,string remark) {
            Resize += resize;
            Anchor = AnchorStyles.None;
            initText(title,remark);
            initColor();
            initEvent();
            tooltip.SetToolTip(remarkBox, remarkBox.Text);
        }
        /* ----- Configuration ----- */
        private void initText(string title,string remark) {
            this.title.contentText = title;
            remarkBox.Text = remark;
        }
        private void initColor() {
            exportButton.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            deleteButton.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            BackColor = bgColor;
            BGPanel.BackColor = BackColor;
            topPanel.BackColor = Helper.ToColor(Helper.deepColor);
            remarkPanel.BackColor = BGPanel.BackColor;
            remarkBox.BackColor = Color.Transparent;
        }
        private void initEvent() {
            topPanel.MouseEnter += CourseCell_MouseEnter;
            remarkBox.MouseEnter += CourseCell_MouseEnter;
            remarkPanel.MouseEnter += CourseCell_MouseEnter;
            deleteButton.MouseEnter += CourseCell_MouseEnter;
            exportButton.MouseEnter += CourseCell_MouseEnter;
            title.MouseEnter += CourseCell_MouseEnter;
            MouseEnter += CourseCell_MouseEnter;
            MouseLeave += CourseCell_MouseLeave;

            remarkPanel.Click += CourseCell_Click;
            topPanel.Click += CourseCell_Click;
            remarkBox.Click += CourseCell_Click;
            title.contentLabel.Click += CourseCell_Click;
            title.Click += CourseCell_Click;

            
        }
        /* ----- Layout ----- */
        public void resize(object sender, EventArgs e) {
            layoutBGPanel();
            layoutTitle();
            layoutRemarkBox();
        }
        private void layoutBGPanel() {
            BGPanel.Width = Width - 8;
            BGPanel.Height = Height - 8;
            BGPanel.Location = new Point(4, 4);
        }
        private void layoutTitle() {
            title.Width = topPanel.Width - deleteButton.Width - exportButton.Width - 10;
            title.Location = new Point(10, topPanel.Height / 2 - title.Height / 2);
        }
        private void layoutRemarkBox() {
            remarkBox.Width = remarkPanel.Width - 20;
            remarkBox.Height = remarkPanel.Height - 20;
            remarkBox.Location = new Point(remarkPanel.Width / 2 - remarkBox.Width / 2,
                remarkPanel.Height / 2 - remarkBox.Height / 2);
        }
        /* ----- Event ----- */
        private void CourseCell_MouseLeave(object sender, EventArgs e) {
            BackColor = bgColor;
        }
        private void CourseCell_MouseEnter(object sender, EventArgs e) {
            BackColor = Helper.ToColor(Helper.specialColor);
            foreach (Panel panel in tableView.Controls) {
                Control con = panel.Controls[0];
                if (con != this) {
                    con.BackColor = bgColor;
                }
            }
        }
        private void CourseCell_Click(object sender,EventArgs e) {
            Model.Course course = libHall.libraryRef[courseId];
            libHall.displayCourseHall(course);
        }
        private void deleteButton_Click(object sender, EventArgs e) {
            HKConfirmForm confirmForm = new HKConfirmForm();
            confirmForm.title = "确定删除《" + cellTitle + "》?";
            bool result = confirmForm.showConfirm();
            if (result == true) {
                deleteTheCourseFromLibrary(courseId);
            }
        }
        private void exportButton_Click(object sender, EventArgs e) {
            try {
                string path = HKSaveFileDialog.saveTo(HKDialogFilter.Course);
                FileSerializeStorage<Model.Course>.save(libHall.libraryRef[courseId], path);
                HKConfirmForm.showConfirmForm("导出成功");
            }catch(FileSerializeStorage<Model.Course>.FileSaveException ex) {
                HKConfirmForm.showConfirmForm(ex.Message) ;
            }catch(HKSaveFileDialog.CancelSaveFileException ex) {
                Console.WriteLine(ex.Message);
            }
        }
        private void deleteTheCourseFromLibrary(string courseId) {
            AttandanceLibrary lib = libHall.libraryRef;
            if (lib.containsCourse(courseId)) {
                Model.Course course = lib[courseId];
                lib.removeCourse(course);
                GlobalStation.shareInstance.librarySave(null, delegate () {
                    lib.addCourse(course);
                });
                libHall.contentInit();
            }
        }
        /* ----- Property ----- */
        public string cellTitle {
            get {
                return title.contentText;
            }
        }
    }
}
