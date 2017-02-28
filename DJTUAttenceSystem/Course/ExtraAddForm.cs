using DJTUAttenceSystem.Model;
using HelperSpace;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace DJTUAttenceSystem.Course {
    public partial class ExtraAddForm : HKDialogForm {
        public struct ExtraResult {
            public bool confirm;
            public subExtra subExt;
        }
        public ExtraAddForm() {
            InitializeComponent();
            layout();
            configureColor();
            yesButtonClick = newYesButton_Click;
        }
        private void layout() {
            topPanel.Height = (int)(this.Height * 0.87);
        }
        private void configureColor() {
            nameInputBox.textColor = Helper.getColorByAddBri(Helper.ToColor(Helper.normalColor), -0.1f);
            nameInputBox.borderColor = Helper.ToColor(Helper.deepColor);
        }
        /* ---- Add a item ---- */
        private void checkTypeAddButton_Click(object sender, EventArgs e) {
            CheckTypeInputPanel checkTypeInputPanel = new CheckTypeInputPanel();
            if (checkPanel.Controls.Count == 0) {
                layoutFirstInputPanel(ref checkTypeInputPanel);
            }else {
                layoutBottomInputPanel(ref checkTypeInputPanel);
            }
            checkTypeInputPanel.afterDelete += checkTypeInputPanel_Delete;
            addInputPanel(ref checkTypeInputPanel);
        }
        private void layoutFirstInputPanel(ref CheckTypeInputPanel inputPanel) {
            int controlsLoactionX = checkPanel.Width / 2 - inputPanel.Width / 2;
            inputPanel.Location = new Point(controlsLoactionX, 0);
        }
        private void layoutBottomInputPanel(ref CheckTypeInputPanel inputPanel) {
            int controlsLoactionX = checkPanel.Width / 2 - inputPanel.Width / 2;
            int bottomPanelIndex = checkPanel.Controls.Count - 1;
            CheckTypeInputPanel bottomInputPanel = (CheckTypeInputPanel)checkPanel.Controls[checkPanel.Controls.Count - 1];
            inputPanel.Location = new Point(controlsLoactionX, bottomInputPanel.Location.Y + bottomInputPanel.Height);
        }
        private void addInputPanel(ref CheckTypeInputPanel inputPanel) {
            checkPanel.Controls.Add(inputPanel);
            inputPanel.resizeSelf();
        }
        /* ---- Delete ---- */
        private void checkTypeInputPanel_Delete(CheckTypeInputPanel sender) {
            for (int i = 0; i < checkPanel.Controls.Count; i++) {
                if (i == 0) {
                    reLayoutFirstItem();
                }else {
                    reLayoutItem(i);
                }
            }
        }
        private void reLayoutFirstItem() {
            CheckTypeInputPanel item = (CheckTypeInputPanel)checkPanel.Controls[0];
            item.Location = new Point(checkPanel.Width / 2 - item.Width / 2, 0);
        }
        private void reLayoutItem(int i) {
            CheckTypeInputPanel item = (CheckTypeInputPanel)checkPanel.Controls[i];
            CheckTypeInputPanel preItem = (CheckTypeInputPanel)checkPanel.Controls[i - 1];
            item.Location = new Point(checkPanel.Width / 2 - item.Width / 2, preItem.Location.Y + preItem.Height);
        }

        public ExtraResult showForm() {
            ShowDialog();
            ExtraResult result = new ExtraResult();
            result.confirm = confirm;
            if (confirm == true) {
                checkType[] checkTypes = getCheckTypeFromPanel();
                subExtra subExt = new subExtra(nameInputBox.text, checkTypes);
                result.subExt = subExt;
            }
            return result;
        }
        private checkType[] getCheckTypeFromPanel() {
            checkType[] checkTypes = new checkType[checkPanel.Controls.Count];
            int i = 0;
            foreach (CheckTypeInputPanel inputPanel in checkPanel.Controls) {
                checkType checkType = new checkType(inputPanel.nameBox.text, int.Parse(inputPanel.weightBox.Text));
                checkType.typeColor = inputPanel.checkTypeColor;
                checkTypes[i] = checkType;
                i++;
            }
            return checkTypes;
        }
        private void newYesButton_Click(object sender, EventArgs e) {
            confirm = true;
            if (isNameInputBoxEmpty()||
                hasCheckTypeInputPanelEmpty() ||
                hasCheckTypeInputPanelNameRepeat()||
                isNoCheckTypeInputPanel()) {
                return;
            }
            Close();
        }
        private bool isNameInputBoxEmpty() {
            if (Helper.IsNullOrWhiteSpace(nameInputBox.text)) {
                HKConfirmForm.showConfirmForm("未填写名称");
                return true;
            }
            return false;
        }
        private bool hasCheckTypeInputPanelEmpty() {
            foreach (CheckTypeInputPanel inputPanel in checkPanel.Controls) {
                if (Helper.IsNullOrWhiteSpace(inputPanel.nameBox.text) ||
                    Helper.IsNullOrWhiteSpace(inputPanel.weightBox.Text)) {
                    HKConfirmForm.showConfirmForm("有评定未填写");
                    return true;
                }
            }
            return false;
        }
        private bool isNoCheckTypeInputPanel() {
            if (checkPanel.Controls.Count == 0) {
                HKConfirmForm.showConfirmForm("至少需要一个评定");
                return true;
            }
            return false;
        }
        private bool hasCheckTypeInputPanelNameRepeat() {
            List<string> nameList = new List<string>();
            foreach (CheckTypeInputPanel inputPanel in checkPanel.Controls) {
                if (nameList.Contains(inputPanel.nameBox.text)) {
                    HKConfirmForm.showConfirmForm("有相同名称的评定");
                    return true;
                }
                nameList.Add(inputPanel.nameBox.text);
            }
            return false;
        }
    }
}
