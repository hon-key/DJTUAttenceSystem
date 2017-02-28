using DJTUAttenceSystem.Model;
using HelperSpace;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DJTUAttenceSystem.Course {
    public partial class CourseReport : DJTUAttenceSystem.Model.HKDialogForm {
        private StuList stuList;
        public Model.Course course;
        public CourseReport() {
            InitializeComponent();
            titleLabel.BackColor = Helper.getColorByAddBri(Helper.ToColor(Helper.deepColor), +0.04f);
            switchPanel.BackColor = titleLabel.BackColor;
            fullAttandance.FlatAppearance.CheckedBackColor = stuFlowPanel.BackColor;
            absThreeTimes.FlatAppearance.CheckedBackColor = stuFlowPanel.BackColor;
        }


        public static void showCourseReport(string title,StuList stuList,Model.Course course) {
            CourseReport report = new CourseReport();
            report.isSingleButtonMode = true;
            report.titleLabel.Text = title;
            report.stuList = stuList;
            report.course = course;
            report.ShowDialog();
        }
        private void fullAttandance_CheckedChanged(object sender, EventArgs e) {
            if (fullAttandance.Checked == true) {
                stuFlowPanel.Controls.Clear();
                foreach (Student stu in getfullAttandanceStudents()) {
                    Label stuLabel = createLabel(stu);
                    stuFlowPanel.Controls.Add(stuLabel);
                }
            }
        }
        private void absThreeTimes_CheckedChanged(object sender, EventArgs e) {
            if (absThreeTimes.Checked == true) {
                stuFlowPanel.Controls.Clear();
                foreach (Student stu in getAbsThreeTimesStudents()) {
                    Label stuLabel = createLabel(stu);
                    stuFlowPanel.Controls.Add(stuLabel);
                }
            }
        }
        private Label createLabel(Student stu) {
            Label stuLabel = new Label();
            stuLabel.AutoSize = false;
            stuLabel.Name = stu.id;
            stuLabel.BackColor = Color.Transparent;
            stuLabel.FlatStyle = FlatStyle.Flat;
            stuLabel.Font = new Font("微软雅黑", 12);
            stuLabel.ForeColor = Color.SeaShell;
            stuLabel.Text = stu.name;
            stuLabel.TextAlign = ContentAlignment.MiddleCenter;
            stuLabel.Height = 40;
            stuLabel.Width = 80;
            return stuLabel;
        }
        private ArrayList getfullAttandanceStudents() {
            ArrayList students = new ArrayList();
            foreach (Student stu in stuList.allStudents()) {
                if (stu.isFullAttandance && stu.allStuAttandances().Count == course.allSubAttandances().Count) {
                    students.Add(stu);
                }
            }
            return students;
        }
        private ArrayList getAbsThreeTimesStudents() {
            ArrayList students = new ArrayList();
            foreach (Student stu in stuList.allStudents()) {
                int times = 0;
                foreach (StuAttandance stuAtt in stu.allStuAttandances()) {
                    if (stuAtt.record.type == Record.RType.absenteeism) {
                        times++;
                    }
                }
                if (times >= 3) {
                    students.Add(stu);
                }
            }
            return students;
        }
    }
}
