using HelperSpace;
using System;
using System.Drawing;
using System.Threading;

namespace DJTUAttenceSystem.Model {
    public struct InputResult {
        public bool confirm;
        public string input;
    }
    public partial class HKTextInputForm : HKDialogForm {
        public HKTextInputForm() {
            InitializeComponent();
            Resize += HKTextInputForm_Resize;
            barColor = topPanelColor;
            inputBox.textColor = bottomPanelColor;
            inputBox.borderColor = Helper.ToColor(Helper.deepColor);
            yesButtonClick = newYesButtonClick;
            inputBox.textBox.TextChanged += TextBox_TextChanged;
            tipsLabel.Visible = false;
        }
        private void HKTextInputForm_Resize(object sender, EventArgs e) {
            inputBox.Width = (int)(this.Width * 0.75);
            inputBox.Height = inputBox.textBox.Height + 10;
            inputBox.Location = new Point(this.Width / 2 - inputBox.Width / 2, title.Height);
            tipsLabel.Location = new Point(inputBox.Location.X, inputBox.Location.Y + inputBox.Height + 5);
        }
        private void TextBox_TextChanged(object sender, EventArgs e) {
            tipsLabel.Visible = false;
        }
        public static InputResult showInputform(string title,string initialInput) {
            HKTextInputForm inputForm = new HKTextInputForm();
            inputForm.title.Text = title;
            inputForm.inputBox.text = initialInput;
            return inputForm.showTextInputForm();
        }
        public bool isSecurity = false;
        /* ----- Property ----- */
        public int titleHeight {
            set {
                title.Height = value;
            }
            get {
                return title.Height;
            }
        }
        public Color barColor {
            set {
                title.BackColor = value;
            }
            get {
                return title.BackColor;
            }
        }
        public Font titleFont {
            get {
                return title.Font;
            }
            set {
                title.Font = value;
            }
        }
        public Color titleForeColor {
            get {
                return title.ForeColor;
            }
            set {
                title.ForeColor = value;
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
        public HKTextBox2 textBox {
            get {
                return inputBox;
            }
        }
        public InputResult showTextInputForm() {
            setSecurity();
            ShowDialog();
            InputResult result = new InputResult();
            result.confirm = confirm;
            result.input = inputBox.textBox.Text;
            return result;
        }
        public void newYesButtonClick(object sender, EventArgs e) {
            confirm = true;
            if (Helper.IsNullOrWhiteSpace(inputBox.textBox.Text)) {
                tipsLabel.Visible = true;
                Helper.shakeForm(this, 2);
            }else {
                Close();
            }
        }

        private void setSecurity() {
            if (isSecurity == true) {
                inputBox.textBox.PasswordChar = '*';
            } else
                inputBox.textBox.PasswordChar = (char)0;
        }
    }
}
