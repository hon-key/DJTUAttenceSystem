using DJTUAttenceSystem.Model;
using HelperSpace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DJTUAttenceSystem.Course {
    public partial class CourseHallEditForm : Form {
        public CourseHall hall;
        public CourseHallEditForm() {
            InitializeComponent();
            editPanel.close = closeButtonHandler;
            editPanel.yes = yesButtonHandler;
            BackColor = Helper.getColorByAddBri(Helper.ToColor(Helper.deepColor), -0.05f);
            editPanel.BackColor = Helper.ToColor(Helper.normalColor);
            editPanel.BarHeight = 70;
            Resize += CourseHallEditForm_Resize;
            editPanel.yes = yesButtonHandler;
            editPanel.close = closeButtonHandler;
            editPanel.titleText = "信息修改";
        }

        private void CourseHallEditForm_Resize(object sender, EventArgs e) {
            editPanel.Location = new Point(3, 3);
            editPanel.Width = Width - 6;
            editPanel.Height = Height - 6;
            editPanel.resize(null, null);
        }

        private void yesButtonHandler(NewCourseInfo info) {
            Model.Course course = hall.courseRef;
            course.name = info.name;
            course.id = info.id;
            course.remark = info.remark;
            course.getRecord(Record.RType.attendance).weight = info.weight.attendance;
            course.getRecord(Record.RType.late).weight = info.weight.late;
            course.getRecord(Record.RType.sickLeave).weight = info.weight.sickLeave;
            course.getRecord(Record.RType.businessLeave).weight = info.weight.businessLeave;
            course.getRecord(Record.RType.absenteeism).weight = info.weight.absenteeism;
            GlobalStation.shareInstance.librarySave(delegate () {
                hall.updateCourseInfo(course.name, course.id, course.remark);
            }, null);
            Close();
        }
        private void closeButtonHandler() {
           Close();
        }
        public static void showForm(CourseHall hall) {
            CourseHallEditForm form = new CourseHallEditForm();
            form.hall = hall;
            Model.Course course = hall.courseRef;
            form.editPanel.nameBox.text = course.name;
            form.editPanel.idBox.text = course.id;
            form.editPanel.remarkBox.text = course.remark;
            form.editPanel.attWeight.setSelectedIntValue(course.getRecord(Record.RType.attendance).weight);
            form.editPanel.lateWeight.setSelectedIntValue(course.getRecord(Record.RType.late).weight);
            form.editPanel.sickWeight.setSelectedIntValue(course.getRecord(Record.RType.sickLeave).weight);
            form.editPanel.busWeight.setSelectedIntValue(course.getRecord(Record.RType.businessLeave).weight);
            form.editPanel.absWeight.setSelectedIntValue(course.getRecord(Record.RType.absenteeism).weight);
            form.editPanel.resize(null, null);
            form.ShowDialog();
        }
    }
}
