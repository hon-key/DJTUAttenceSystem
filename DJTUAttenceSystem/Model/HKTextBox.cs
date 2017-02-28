using System;
using System.Drawing;
using System.Windows.Forms;

namespace DJTUAttenceSystem.Model {
    public partial class HKTextBox : UserControl {
        private int offset;
        private int border;
        public HKTextBox() {
            InitializeComponent();
            this.Resize += resize;
            widthOffset = 17;
        }
        private void resize(object sender, EventArgs e) {
            bgPanel.Width = this.Width - border * 2;
            bgPanel.Height = this.Height - border * 2;
            bgPanel.Location = new Point(border, border);

            textBox.Location = new Point(0, 0);
            textBox.Width = bgPanel.Width + offset;
            textBox.Height = bgPanel.Height;
        }
        public int borderWidth {
            set {
                border = value;
            }
            get {
                return border;
            }
        }
        public Color borderColor {
            set {
                this.BackColor = value;
            }
            get {
                return this.BackColor;
            }
        }
        public int widthOffset {
            set {
                offset = value;
                textBox.Location = new Point(0, 0);
                textBox.Width = this.Width + offset;
                textBox.Height = this.Height;
            }
            get {
                return offset;
            }
        }
        public String text {
            set {
                textBox.Text = value;
            }
            get {
                return textBox.Text;
            }
        }
        public TextBox txBox {
            get {
                return textBox;
            }
        }
        public Color BGColor {
            set {
                textBox.BackColor = value;
            }
            get {
                return textBox.BackColor;
            }
        }
        public Font textFont {
            set {
                textBox.Font = value;
            }
            get {
                return textBox.Font;
            }
        }
        public ScrollBars bar {
            set {
                textBox.ScrollBars = value;
            }
            get {
                return textBox.ScrollBars;
            }
        }
        public Color foreColor {
            get {
                return textBox.ForeColor;
            }
            set {
                textBox.ForeColor = value;
            }
        }

    }
}