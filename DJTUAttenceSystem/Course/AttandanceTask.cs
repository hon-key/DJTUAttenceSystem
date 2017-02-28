using HelperSpace;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpeechLib;
using DJTUAttenceSystem.Model;
using System.Collections;

namespace DJTUAttenceSystem.Course {
    public class AttandanceTask {
        private static Color backgroundColor = Helper.getColorByAddBri(Helper.ToColor(Helper.normalColor), -0.05f);
        private static Color deepBackgroundColor = Helper.ToColor(Helper.deepColor);
        public static AttandanceTask createAttandanceTask(CourseHall hallToCheck,Control parentOfPanel, int operationPanelWidth = 676) {
            AttandanceTask task = new AttandanceTask(parentOfPanel, hallToCheck, operationPanelWidth);
            return task;
        }

        public CourseHall hall;
        public HKButtonPanel operationPanel = new HKButtonPanel();
        private int operationPanelWidth;
        private SpVoice speaker = new SpVoice();
        private SubAttandance newSubAtt;
        private ArrayList usedRandomNumber = new ArrayList();
        private Random random;
        private bool isFinished = false;
        private AttandanceTask(Control parent,CourseHall hall,int operationPanelWidth) {
            this.hall = hall;
            configureGUI(parent, hall.mode, operationPanelWidth);
            createNewSubAttandance();
            createRandomIfNeed();
        }
        /* ----- configuration ----- */
        private void createNewSubAttandance() {
            Model.Course course = hall.courseRef;
            newSubAtt = new SubAttandance(DateTime.Now);
            course.addSubAttandance(newSubAtt);
            DataGridViewColumn column = hall.init_createColumn(newSubAtt);
            hall.mainGrid.Columns.Insert((int)mainGridCellIndex.subAttStartIndex + course.allSubAttandances().Count - 1, column);
        }
        private void createRandomIfNeed() {
            if (hall.mode == HallMode.randomMode) {
                long tick = DateTime.Now.Ticks;
                random = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
            }
        }
        private void configureGUI(Control parent, HallMode mode, int operationPanelWidth = 300) {
            this.operationPanelWidth = operationPanelWidth;
            parent.Controls.Add(operationPanel);
            GUI_initPanel(operationPanel);
            switch (mode) {
                case HallMode.freedomMode: GUI_addFreeModeButton(operationPanel); break;
                case HallMode.orderMode: GUI_addOrderModeButton(operationPanel); break;
                case HallMode.randomMode: GUI_addRandomModeButton(operationPanel); break;
                default: break;
            }
            operationPanel.HKButtonPanel_Resize(null, null);
        }
        private void GUI_initPanel(HKButtonPanel panel) {
            panel.Height = 30;
            panel.border = 0;
            panel.borderColor = deepBackgroundColor;
            panel.backgroundColor = backgroundColor;
        }
        private void GUI_addFreeModeButton(HKButtonPanel panel) {
            panel.Name = "FreeMode";
            int btnWidth = 90;
            int blankWidth = (operationPanelWidth - btnWidth * 7) / 2;
            addButtonToHKButtonPanel(panel, btnWidth, freeModeButtonClick, "播放语音");
            panel.addBlank(blankWidth);
            addButtonToHKButtonPanel(panel, btnWidth, freeModeButtonClick, "出勤", "迟到", "事假", "病假", "旷课");
            panel.addBlank(blankWidth);
            addButtonToHKButtonPanel(panel, btnWidth, freeModeButtonClick, "保存");
        }
        private void GUI_addOrderModeButton(HKButtonPanel panel) {
            panel.Name = "OrderMode";
            int btnWidth = 80;
            int blankWidth = (operationPanelWidth - btnWidth * 8) / 2;
            addButtonToHKButtonPanel(panel, btnWidth, orderAndRandomModeButtonClick, "开始", "重复语音");
            panel.addBlank(blankWidth);
            addButtonToHKButtonPanel(panel, btnWidth, orderAndRandomModeButtonClick, "出勤", "迟到", "事假", "病假", "旷课");
            panel.addBlank(blankWidth);
            addButtonToHKButtonPanel(panel, btnWidth, orderAndRandomModeButtonClick, "保存");
        }
        private void GUI_addRandomModeButton(HKButtonPanel panel) {
            GUI_addOrderModeButton(panel);
        }
        private void addButtonToHKButtonPanel(HKButtonPanel panel, int btnWidth,
    HKButtonPanel.buttonClickHandler handler, params string[] titles) {
            foreach (string title in titles) {
                panel.addButton(title, btnWidth, handler);
            }
        }

        /* ----- Event ----- */
        private void freeModeButtonClick(string title) {
            if (hall.tabs.selectedIndex == -1) {return;}
            if (title.Equals("播放语音")) {
                speak();
            } else if (title.Equals("保存")) {
                finish();
            } else {
                Record record = execAttandance(title);
                execMainGridCellModify(record);
            }
        }
        private void orderAndRandomModeButtonClick(string title) {
            if (hall.tabs.selectedIndex == -1) { return; }
            if (title.Equals("开始")) {
                selectRow(true);
                operationPanel.setButtonEnable("开始", false);
            } else if (title.Equals("重复语音")) {
                speak();
            } else if (title.Equals("保存")) {
                finish();
            }else {
                Record record = execAttandance(title);
                execMainGridCellModify(record);
                selectRow(false);
            }
        }

        private void finish() {
            GlobalStation.shareInstance.librarySave(delegate () {
                HKConfirmForm.showConfirmForm("考勤成功");
                isFinished = true;
                hall.changeToEditMode("编辑模式");
            }, delegate () {
                GlobalStation.shareInstance.librarysInit();
            });
        }
        private void speak() {
            string textToSpeak = hall.getRowValue(hall.mainGrid.CurrentRow.Index, mainGridCellIndex.Name);
            speaker.Speak(textToSpeak, SpeechVoiceSpeakFlags.SVSFlagsAsync);
        }
        // Attendance
        private Record execAttandance(string title) {
            Record.RType type = Record.RType.attendance;
            switch (title) {
                case "出勤": type = Record.RType.attendance; break;
                case "迟到": type = Record.RType.late; break;
                case "事假": type = Record.RType.businessLeave; break;
                case "病假": type = Record.RType.sickLeave; break;
                case "旷课": type = Record.RType.absenteeism; break;
                default: break;
            }
            setAttandanceToTheStudent(type);
            return hall.courseRef.getRecord(type);
        }
        private void setAttandanceToTheStudent(Record.RType type) {
            Model.Course course = hall.courseRef;
            StuList stuList = course.getStuList(hall.SelectedStuListUUID);
            string stuId = hall.getRowValue(hall.mainGrid.CurrentRow.Index, mainGridCellIndex.id);
            Student stu = stuList[stuId];
            StuAttandance stuAtt = stu.getAttandance(newSubAtt.UUID);
            if (stuAtt == null) {
                stuAtt = new StuAttandance(newSubAtt, course.getRecord(type));
                stu.addAttandance(stuAtt);
            } else {
                stuAtt.record = course.getRecord(type);
            }
        }
        // Cell modification
        private void execMainGridCellModify(Record record) {
            hall.stopCellValueChanged();
            hall.mainGrid.CurrentRow.Cells[newSubAtt.UUID].Style.BackColor = record.recordColor;
            hall.mainGrid.CurrentRow.Cells[newSubAtt.UUID].Value = record.recordString();
            hall.startCellValueChanged();
        }
        // select a row
        private void selectRow(bool isFirst) {
            switch (hall.mode) {
                case HallMode.orderMode: orderModeSelectRow(isFirst); break;
                case HallMode.randomMode: randomModeSelectRow(); break;
                default: break;
            }
        }
        private void orderModeSelectRow(bool isFirst) {
            if (isFirst) {
                hall.fixedRowIndex = 0;
            } else if (hall.fixedRowIndex == hall.mainGrid.Rows.Count - 1) {
                HKConfirmForm.showConfirmForm("最后一位学生已经点完了");
                return;
            } else {
                hall.fixedRowIndex++;
            }
            hall.setSeletedRow(hall.fixedRowIndex);
            speak();
        }
        private void randomModeSelectRow() {
            int index = getARandom(hall.mainGrid.Rows.Count);
            if (index != -1) {
                hall.fixedRowIndex = index;
            } else {
                HKConfirmForm.showConfirmForm("所有学生都已经随机到了");
                return;
            }
            hall.setSeletedRow(hall.fixedRowIndex);
            speak();
        }
        private int getARandom(int maxValue) {
            int result = -1;
            for (;;) {
                if (usedRandomNumber.Count == maxValue) {
                    break;
                }
                int num = random.Next(maxValue);
                if (!usedRandomNumber.Contains(num)) {
                    result = num;
                    usedRandomNumber.Add(result);
                    break;
                }
            }
            return result;
        }

        /* ----- Cancel Task ----- */
        public void cancel() {
            removeOperationPanel();
            GlobalStation.shareInstance.librarysInit();
            if (!isFinished) {
                try {
                    hall.mainGrid.Columns.Remove(hall.mainGrid.Columns[newSubAtt.UUID]);
                } catch { }
            }
        }
        private void removeOperationPanel() {
            Control con = operationPanel.Parent;
            if (con != null) {
                con.Controls.Remove(operationPanel);
            }
        }
    }
}
