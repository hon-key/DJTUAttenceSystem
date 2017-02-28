using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DJTUAttenceSystem.Model {
    public struct selectResult {
        public string title;
        public bool confirm;
    }
    public partial class HKSelectForm : HKDialogForm {
        private Color cbc = Color.Transparent;
        public HKSelectForm() {
            InitializeComponent();
            this.Resize += HKSelect_Resize;
        }
        public static selectResult showSelectForm(params string[] titles) {
            HKSelectForm select = new HKSelectForm();
            select.checkBackColor = Color.DarkGoldenrod;
            foreach (string title in titles) {
                select.addRadio(title);
            }
            select.Width = 300;
            select.Height = 150;
            return select.showSelect();
        }
        private void HKSelect_Resize(object sender, EventArgs e) {
            topPanel.Height = (int)(this.Height * 0.75);
            int radioButtonWidth = Width / topPanel.Controls.Count;
            foreach (Control con in topPanel.Controls) {
                con.Width = radioButtonWidth;
            }
        }
        public Font titleFont = new Font("微软雅黑", 12, FontStyle.Bold);
        public Color foreColor = Color.SeaShell;
        public Color checkBackColor {
            get {
                return cbc;
            }
            set {
                cbc = value;
                foreach (RadioButton con in topPanel.Controls) {
                    con.FlatAppearance.CheckedBackColor = value;
                }
            }
        }
        public void addRadio(string title) {
            RadioButton rb = new RadioButton();
            rb.AutoSize = false;
            rb.Dock = DockStyle.Left;
            rb.Name = title;
            rb.Appearance = Appearance.Button;
            rb.CheckAlign = ContentAlignment.MiddleCenter;
            rb.FlatAppearance.BorderSize = 0;
            rb.FlatStyle = FlatStyle.Flat;
            rb.Font = titleFont;
            rb.ForeColor = foreColor;
            rb.Text = title;
            rb.TextAlign = ContentAlignment.MiddleCenter;
            topPanel.Controls.Add(rb);
            rb.BringToFront();
        }
        public selectResult showSelect() {
            foreach (RadioButton con in topPanel.Controls) {
                con.Font = titleFont;
                con.ForeColor = foreColor;
                con.FlatAppearance.CheckedBackColor = cbc;
            }
            ((RadioButton)topPanel.Controls[topPanel.Controls.Count - 1]).Checked = true;
            ShowDialog();
            selectResult s = new selectResult();
            foreach (RadioButton con in topPanel.Controls) {
                if (con.Checked) {
                    s.title = con.Text;
                }
            }
            s.confirm = confirm;
            return s;
        }
    }
}
