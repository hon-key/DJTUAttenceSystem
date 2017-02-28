using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using HelperSpace;
using System.Windows.Forms;
using DJTUAttenceSystem.Model;

namespace DJTUAttenceSystem.Course {
    public struct NewWeight {
        public int attendance;
        public int late;
        public int absenteeism;
        public int sickLeave;
        public int businessLeave;
    }
    public struct NewCourseInfo {
        public string name;
        public string id;
        public string remark;
        public NewWeight weight;
    }
    public partial class CourseEdit : UserControl {
        public delegate void yesHandler(NewCourseInfo courseInfo);
        public delegate void closeHandler();
        public yesHandler yes;
        public closeHandler close; 
        public CourseEdit() {
            InitializeComponent();
            configureLayout();
            configureColor();
            configureEvent();
            initComboBoxSelection();

            
        }
        /* ----- Configuration -----*/
        private void configureLayout() {
            Resize += resize;
        }
        private void configureColor() {
            bar.BackColor = Helper.getColorByAddBri(Helper.ToColor(Helper.normalColor), -0.05f);
            yesButton.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            closeButton.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            nameBox.textBox.BackColor = idBox.textBox.BackColor = remarkBox.BGColor =
                Helper.getColorByAddBri(Helper.ToColor(Helper.normalColor), -0.05f);
            nameBox.borderColor = idBox.borderColor = remarkBox.borderColor =
                Helper.ToColor(Helper.deepColor);
        }
        private void configureEvent() {
            idBox.textBox.KeyPress += idBox_filterKeypressed;
            attWeight.selectedChanged = lateWeight.selectedChanged = 
            absWeight.selectedChanged = sickWeight.selectedChanged = 
            busWeight.selectedChanged = comboBoxValueChanged;
        }
        private void initComboBoxSelection() {
            attWeight.setIntSelections(1, 10);
            attWeight.setSelectedIntValue(2);
        }
        /* ----- Layout -----*/
        public void resize(object sender,EventArgs e) {
            layoutRemarkBox();
            layoutComboBoxes();
        }
        private void layoutRemarkBox() {
            remarkBox.Width = topPanel_bottom.Width - remarkLabel.Width - 40;
            remarkBox.Height = topPanel_bottom.Height - 20;
            remarkBox.Location = new Point(remarkLabel.Width, 0);
        }
        private void layoutComboBoxes() {
            attWeight.Location = new Point(weightLabel.Width + 20, 0);
            lateWeight.Location = new Point(attWeight.Location.X + attWeight.Width + 20, 0);
            absWeight.Location = new Point(lateWeight.Location.X + attWeight.Width + 20, 0);
            sickWeight.Location = new Point(absWeight.Location.X + attWeight.Width + 20, 0);
            busWeight.Location = new Point(sickWeight.Location.X + attWeight.Width + 20, 0);
            attWeight.Height = lateWeight.Height = absWeight.Height = sickWeight.Height = busWeight.Height = attWeight.cmbBox.Height + 3;
        }
        /* ----- Button Event ----- */
        private void closeButton_Click(object sender, EventArgs e) {
            if (close != null) {
                close();
            }
        }
        private void yesButton_Click(object sender, EventArgs e) {
            if (isFieldsReady() && yes != null) {
                NewCourseInfo courseInfo = produceNewCourseInfo();
                yes(courseInfo);
            }else {
                HKConfirmForm.showConfirmForm("信息未填写完整");
            }
        }
        private bool isFieldsReady() {
            if (Helper.IsNullOrWhiteSpace(nameBox.textBox.Text) ||
                Helper.IsNullOrWhiteSpace(idBox.textBox.Text)) {
                return false;
            }
            return true;
        }
        private NewCourseInfo produceNewCourseInfo() {
            NewCourseInfo info = new NewCourseInfo();
            setInfoBase(ref info);
            setInfoWeight(ref info);
            return info;
        }
        private void setInfoBase(ref NewCourseInfo info) {
            info.name = nameBox.textBox.Text;
            info.id = idBox.textBox.Text;
            info.remark = remarkBox.text;
        }
        private void setInfoWeight(ref NewCourseInfo info) {
            NewWeight newWeight = new NewWeight();
            newWeight.attendance = attWeight.getSelectedIntValue();
            newWeight.late = lateWeight.getSelectedIntValue();
            newWeight.absenteeism = absWeight.getSelectedIntValue();
            newWeight.sickLeave = sickWeight.getSelectedIntValue();
            newWeight.businessLeave = busWeight.getSelectedIntValue();
            info.weight = newWeight;
        }
        private void idBox_filterKeypressed(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b') {

            } else {
                e.Handled = true;
            }
        }
        /* ----- ComboBox Event ----- */
        private void comboBoxValueChanged(HKComboBox box, string newValue) {
            if (box == attWeight) {
                attWeightValueChanged();
            } else if (box == lateWeight) {
                lateWeightValueChanged();
            }
        }
        private void attWeightValueChanged() {
            lateWeight.setIntSelections(0, attWeight.getSelectedIntValue() - 1);
            lateWeight.setSelectedIntValue(attWeight.getSelectedIntValue() - 1);
            sickWeight.setIntSelections(0, attWeight.getSelectedIntValue());
            sickWeight.setSelectedIntValue(0);
            busWeight.setIntSelections(0, attWeight.getSelectedIntValue());
            busWeight.setSelectedIntValue(0);
        }
        private void lateWeightValueChanged() {
            absWeight.setIntSelections(0, lateWeight.getSelectedIntValue());
            absWeight.setSelectedIntValue(0);
        }

        public int BarHeight {
            set {
                bar.Height = value;
                yesButton.Width = value;
                closeButton.Width = value;
            }
            get {
                return bar.Height;
            }
        }
        public string titleText {
            set {
                title.Text = value;
            }
            get {
                return title.Text;
            }
        }
    }
}
