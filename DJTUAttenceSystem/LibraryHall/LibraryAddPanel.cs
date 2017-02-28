using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using HelperSpace;
using DJTUAttenceSystem.Model;

namespace DJTUAttenceSystem.LibraryHall {
    public partial class LibraryAddPanel : UserControl {
        public static int margin = 10;
        private static Color fillColor = Helper.getColorByAddBri(Helper.ToColor(Helper.deepColor), +0.05f);
        public LibraryAddPanel() {
            InitializeComponent();
            configureLayout();
            configureColor();
            configureEvent();
        }
        /* ----- configuration ----- */
        private void configureLayout() {
            Dock = DockStyle.Fill;
            this.Resize += resize;
        }
        private void configureColor() {
            cancelButton.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            confirmButton.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            remarkField.BackColor = pswField.BackColor = nameField.BackColor = fillColor;
            topPanel.BackColor = fillColor;
            pswCheckBox.BackColor = Helper.ToColor(Helper.deepColor);
            pswCheckBox.FlatAppearance.CheckedBackColor = Helper.ToColor(Helper.deepColor);
        }
        private void configureEvent() {
            pswField.KeyPress += pswField_filterKeyPress;
        }
        /* ----- layout ----- */
        public void resize(object obj,EventArgs e) {
            layoutFieldPanel();
            layoutNameLabelAndField();
            layoutPswLabelAndFieldAndCheckBox();
            layoutRemarkLabelAndField();
        }
        private void layoutFieldPanel() {
            fieldPanel.Width = (int)(this.Width * 0.7);
            fieldPanel.Height = (int)(this.Height * 0.4);
            fieldPanel.Location = new Point(bottomPanel.Width / 2 - fieldPanel.Width / 2,
                bottomPanel.Height / 2 - fieldPanel.Height / 2);
        }
        private void layoutNameLabelAndField() {
            nameLabel.Location = new Point(0, 0 + margin);
            nameField.Location = new Point(nameLabel.Location.X + nameLabel.Width + margin,
                nameLabel.Location.Y + nameLabel.Height / 2 - nameField.Height / 2);
        }
        private void layoutPswLabelAndFieldAndCheckBox() {
            PswLabel.Location = new Point(nameField.Location.X + nameField.Width + margin, 0 + margin);
            pswField.Location = new Point(PswLabel.Location.X + PswLabel.Width + margin,
                PswLabel.Location.Y + PswLabel.Height / 2 - pswField.Height / 2);
            pswCheckBox.Location = new Point(pswField.Location.X + pswField.Width + margin,
                pswField.Location.Y + pswField.Height / 2 - pswCheckBox.Height / 2);
        }
        private void layoutRemarkLabelAndField() {
            remarkField.Width = fieldPanel.Width - remarkLabel.Width - margin * 2;
            remarkField.Height = fieldPanel.Height - nameField.Height - margin * 2 - 30;
            remarkField.Location = new Point(fieldPanel.Width - remarkField.Width - margin,
                fieldPanel.Height - remarkField.Height - margin);
            remarkLabel.Location = new Point(remarkField.Location.X - remarkLabel.Width - margin,
                remarkField.Location.Y);
        }
        /* ----- Confirm ----- */
        private void confirmButton_Click(object sender, EventArgs e) {
            if (!confirm_nameFieldStateIsGood()) {
                HKConfirmForm.showConfirmForm("名字不能空哦");
            }else {
                confirm_addLibrary();
            }
        }
        private void confirm_addLibrary() {
            string remark = remarkField.Text;
            confirm_checkRemark(ref remark);
            string uuid = confirm_libraryCreate(nameField.Text, remark, pswField.Text);
            if (uuid != null) {
                confirm_showLibraryHall(uuid);
            }
        }
        private bool confirm_nameFieldStateIsGood() {
            if (Helper.IsNullOrWhiteSpace(nameField.Text)) {
                return false;
            }
            return true;
        }
        private void confirm_checkRemark(ref string remarks) {
            if (Helper.IsNullOrWhiteSpace(remarks)) {
                remarks = "作者啥也没留下";
            }
        }
        private string confirm_libraryCreate(string name, string remarks, string password) {
            AttandanceLibrary lib = new AttandanceLibrary(name, remarks);
            lib.password = password;
            GlobalStation.shareInstance.librarys.addLib(lib);
            string UUID = lib.UUID;
            GlobalStation.shareInstance.librarySave(null, delegate () {
                GlobalStation.shareInstance.librarys.collections.Remove(lib);
                UUID = null;
            });
            return UUID;
        }
        private void confirm_showLibraryHall(string uuid) {
            GlobalStation.shareInstance.librarys.isCustomize = false;
            LibraryHallPanel hall = new LibraryHallPanel();
            hall.libraryUUID = uuid;
            GlobalStation.shareInstance.entrance.showPanel(hall);
        }
        /* ----- Cancel ----- */
        private void cancelButton_Click(object sender, EventArgs e) {
            Login loginPanel = new Login();
            GlobalStation.shareInstance.entrance.showPanel(loginPanel);
        }
        /* ----- Other Event ----- */
        private void pswCheckBox_CheckedChanged(object sender, EventArgs e) {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked) {
                pswField.PasswordChar = (char)0;
            } else {
                pswField.PasswordChar = '*';
            }
        }
        private void pswField_filterKeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || 
                (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || 
                (e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
                e.KeyChar == '\b') {
            } else {
                e.Handled = true;
            }
        }
        
    }
}
