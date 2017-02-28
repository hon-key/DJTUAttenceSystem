using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DJTUAttenceSystem.Model {
    public partial class HKConfirmForm : DJTUAttenceSystem.Model.HKDialogForm {
        public HKConfirmForm() {
            InitializeComponent();
            Resize += HKConfirm_Resize;
            Height = 200;
            Width = 300;
            buttonHeight = 40;
        }
        public static bool showConfirmForm(string title) {
            HKConfirmForm confirmForm = new HKConfirmForm();
            confirmForm.isSingleButtonMode = true;
            confirmForm.title = title;
            return confirmForm.showConfirm();
        }
        private void HKConfirm_Resize(object sender, EventArgs e) {

        }
        public string title {
            get {
                return titleLabel.Text;
            }
            set {
                titleLabel.Text = value;
            }
        }
        public Font titleFont {
            get {
                return titleLabel.Font;
            }
            set {
                titleLabel.Font = value;
            }
        }
        public Color titleForeColor {
            get {
                return titleLabel.ForeColor;
            }
            set {
                titleLabel.ForeColor = value;
            }
        }
        public int buttonHeight {
            get {
                return bottomPanel.Height;
            }
            set {
                topPanel.Height = this.Height - value;
            }
        }
        public bool showConfirm() {
            this.ShowDialog();
            return confirm;
        }
    }
}
