using System;
using HelperSpace;
using System.Windows.Forms;
using System.Drawing;
using DJTUAttenceSystem.Model;

namespace DJTUAttenceSystem.LibraryHall {
    public partial class LibraryEditForm : Form {
        public LibraryHallPanel libHall;
        public LibraryEditForm() {
            InitializeComponent();
            this.Resize += resize;
        }

        private void LibraryEditForm_Load(object sender, EventArgs e) {
            configureColor();
            configureNameTextBox();
            configurePswBox();
            configureRemarkBox();
        }
        /* ----- configuration ----- */
        private void configureColor() {
            BackColor = Helper.ToColor(Helper.normalColor);
            topBar.BackColor = Helper.ToColor(Helper.deepColor);
            yesButton.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            closeButton.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
        }
        private void configureNameTextBox() {
            nameTextBox.textBox.BackColor = Helper.getColorByAddBri(Helper.ToColor(Helper.normalColor), -0.05f);
            nameTextBox.borderColor = Helper.ToColor(Helper.deepColor);
            nameTextBox.resize(null, null);
            AttandanceLibrary lib = libHall.libraryRef;
            nameTextBox.text = lib.name;
            pswBox.text = lib.password;
            remarkBox.text = lib.remarks;
        }
        private void configurePswBox() {
            pswBox.borderColor = Helper.ToColor(Helper.deepColor);
            pswBox.textBox.BackColor = Helper.getColorByAddBri(Helper.ToColor(Helper.normalColor), -0.05f);
            pswBox.resize(null, null);
            pswBox.textBox.KeyPress += pswField_keyPressed;
            pswBox.textBox.PasswordChar = '*';
        }
        private void configureRemarkBox() {
            remarkBox.BGColor = Helper.getColorByAddBri(Helper.ToColor(Helper.normalColor), -0.05f);
            remarkBox.borderColor = Helper.ToColor(Helper.deepColor);
        }
        /* ----- Layout ----- */
        public void resize(object sender, EventArgs e) {
            layoutRemarkBox();
            layoutPswCheckBox();
        }
        private void layoutRemarkBox() {
            remarkBox.Width = bottomPanel.Width - remarkLabel.Width - 30;
            remarkBox.Height = bottomPanel.Height - 30;
            remarkBox.Location = new Point(remarkLabel.Width, remarkLabel.Location.Y + 5);
        }
        private void layoutPswCheckBox() {
            pswCheckBox.Location = new Point(pswBox.Location.X + pswBox.Width + 10,
                pswBox.Location.Y + pswBox.Height / 2 - pswCheckBox.Height / 2);
        }
        /* ----- Event ----- */
        private void yesButton_Click(object sender, EventArgs e) {
            if (!Helper.IsNullOrWhiteSpace(nameTextBox.text)) {
                modifyInfo();
            }else {
                HKConfirmForm.showConfirmForm("信息为填写完整");
            }
            
        }
        private void modifyInfo() {
            AttandanceLibrary lib = libHall.libraryRef;
            lib.name = nameTextBox.text;
            lib.password = pswBox.text;
            if (!Helper.IsNullOrWhiteSpace(remarkBox.text))
                lib.remarks = remarkBox.text;
            else
                lib.remarks = "作者什么都没留下";
            GlobalStation.shareInstance.librarySave(delegate () {
                libHall.contentInit();
            }, null);
            Close();
        }
        private void closeButton_Click(object sender, EventArgs e) {
            Close();
        }
        private void pswField_keyPressed(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') ||
                (e.KeyChar >= 'A' && e.KeyChar <= 'Z') ||
                (e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
                e.KeyChar == '\b') {
            } else {
                e.Handled = true;
            }
        }
        private void pswCheckBox_CheckedChanged(object sender, EventArgs e) {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked) {
                pswBox.textBox.PasswordChar = (char)0;
            } else {
                pswBox.textBox.PasswordChar = '*';
            }
        }
    }
}
