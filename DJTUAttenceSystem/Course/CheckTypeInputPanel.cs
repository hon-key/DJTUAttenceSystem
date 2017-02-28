using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HelperSpace;
using DJTUAttenceSystem.Model;

namespace DJTUAttenceSystem.Course {
    public partial class CheckTypeInputPanel : UserControl {
        public delegate void deleteHandler(CheckTypeInputPanel sender);
        public deleteHandler afterDelete;
        public CheckTypeInputPanel() {
            InitializeComponent();
            configureLayout();
            configureColor();
            configureColorPanel();
        }
        /* ----- Configuration ----- */
        private void configureLayout() {
            Resize += CheckTypeInputPanel_Resize;
        }
        private void configureColor() {
            nameBox.borderColor = Helper.getColorByAddBri(Helper.ToColor(Helper.normalColor), -0.15f);
            nameBox.textColor = Helper.getColorByAddBri(Helper.ToColor(Helper.normalColor), -0.1f);
        }
        private void configureColorPanel() {
            colorPanel.Click += ColorPanel_Click;
        }

        /* ----- Layout ----- */
        private void CheckTypeInputPanel_Resize(object sender, EventArgs e) {
            weightBox.Location = new Point(weightLabel.Location.X + weightLabel.Width,
                Height / 2 - weightBox.Height / 2);
            colorPanel.Location = new Point(weightBox.Location.X + weightBox.Width + 20,
                Height / 2 - colorPanel.Height / 2);
            deleteButton.Location = new Point(colorPanel.Location.X + colorPanel.Width + 20,
                Height / 2 - deleteButton.Height / 2);
        }
        public void resizeSelf() {
            CheckTypeInputPanel_Resize(null, null);
            nameBox.resize(null, null);
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            Parent.Controls.Remove(this);
            if (afterDelete != null) {
                afterDelete(this);
            }
        }
        private void ColorPanel_Click(object sender, EventArgs e) {
            selectResult result = HKSelectForm.showSelectForm("默认", "拾取颜色");
            if (result.confirm) {
                if (result.title.Equals("默认")) {
                    colorPanel.BackColor = Color.Transparent;
                }else {
                    ColorDialog colorDialog = new ColorDialog();
                    colorDialog.ShowDialog();
                    colorPanel.BackColor = colorDialog.Color;
                }
            }
        }
        #region Public Method
        public Color checkTypeColor {
            get {
                if (colorPanel.BackColor == Color.Transparent) {
                    return Color.Empty;
                }
                return colorPanel.BackColor;
            }
        }
        #endregion
    }
}
