using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DJTUAttenceSystem.Model {
    public partial class HKTextBox2 : UserControl {
        private int border;
        public HKTextBox2() {
            InitializeComponent();
            this.Resize += resize;
            this.BorderStyle = BorderStyle.None;
            this.txBox.BorderStyle = BorderStyle.None;
            this.txBox.Cursor = Cursors.Default;
        }
        private void HKTextBox2_Load(object sender, EventArgs e) {
            resize(null, null);
        }
        public void resize(object sender, EventArgs e) {
            borderPanel.Height = txBox.Height + border * 2;
            borderPanel.Width = this.Width;
            txBox.Width = borderPanel.Width - border * 2;
            borderPanel.Location = new Point(0, this.Height / 2 - borderPanel.Height / 2);
            txBox.Location = new Point(border, borderPanel.Height / 2 - txBox.Height / 2);
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
                borderPanel.BackColor = value;
            }
            get {
                return borderPanel.BackColor;
            }
        }
        public TextBox textBox {
            get {
                return txBox;
            }
        }
        public Font font {
            get {
                return txBox.Font;
            }
            set {
                txBox.Font = value;
            }
        }
        public Color textColor {
            get {
                return txBox.BackColor;
            }
            set {
                txBox.BackColor = value;
            }
        }
        public Color textForeColor {
            get {
                return txBox.ForeColor;
            }
            set {
                this.txBox.ForeColor = value;
            }
        }
        public string text {
            get {
                return textBox.Text;
            }
            set {
                textBox.Text = value;
            }
        }
    }
}
