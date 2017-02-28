using HelperSpace;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DJTUAttenceSystem.Model {
    public partial class HKDialogForm : Form {
        public bool confirm = false;
        public int border = 3;
        public EventHandler yesButtonClick {
            set {
                Helper.RemoveEvent(yesButton, "Click");
                yesButton.Click += value;
            }
        }
        public EventHandler closeButtonClick {
            set {
                Helper.RemoveEvent(closeButton, "Click");
                yesButton.Click += value;
            }
        }
        public HKDialogForm() {
            InitializeComponent();
            Resize += HKDialogForm_Resize;
            StartPosition = FormStartPosition.CenterParent;
            topPanelColor = Helper.getColorByAddBri(Helper.ToColor(Helper.normalColor), -0.05f);
            bottomPanelColor = Helper.getColorByAddBri(Helper.ToColor(Helper.normalColor), -0.1f);
            yesButton.Click += yesButton_Click;
            closeButton.Click += closeButton_Click;
            BackColor = Helper.ToColor(Helper.deepColor);
        }
        private void HKDialogForm_Resize(object sender, EventArgs e) {
            BGPanel.Location = new Point(border, border);
            BGPanel.Width = Width - 2 * border;
            BGPanel.Height = Height - 2 * border;
            closeButton.Width = Width / 2;
        }

        public Color topPanelColor {
            get {
                return topPanel.BackColor;
            }
            set {
                topPanel.BackColor = value;
            }
        }
        public Color bottomPanelColor {
            get {
                return bottomPanel.BackColor;
            }
            set {
                bottomPanel.BackColor = value;
            }
        }
        public Color closeButtonOverColor {
            get {
                return closeButton.FlatAppearance.MouseOverBackColor;
            }
            set {
                closeButton.FlatAppearance.MouseOverBackColor = value;
            }
        }
        public Color yesButtonOverColor {
            get {
                return yesButton.FlatAppearance.MouseOverBackColor;
            }
            set {
                yesButton.FlatAppearance.MouseOverBackColor = value;
            }
        }
        public int topPanelHeight {
            get {
                return topPanel.Height;
            }
            set {
                topPanel.Height = value;
            }
        }
        public bool isSingleButtonMode {
            set {
                if (value == true) {
                    bottomPanel.Controls.Remove(closeButton);
                    yesButton.Dock = DockStyle.Fill;
                }else {
                    yesButton.Dock = DockStyle.Left;
                    bottomPanel.Controls.Add(closeButton);
                    yesButton.BringToFront();
                }
            }
            get {
                if (bottomPanel.Controls.Contains(closeButton)) {
                    return false;
                }
                return true;
            }
        }
        public void closeButton_Click(object sender, EventArgs e) {
            confirm = false;
            Close();
        }
        public void yesButton_Click(object sender, EventArgs e) {
            confirm = true;
            Close();
        }
    }
}
