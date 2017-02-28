using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace DJTUAttenceSystem.Course {
    public partial class HKButtonPanel : UserControl {
        public class PanelItem {
            public Button button;
            public Panel blank;
            public bool isButton;
            public buttonClickHandler buttonClick;
        }
        public delegate void buttonClickHandler(string title);
        private int _border = 0;
        public ArrayList items = new ArrayList();
        public HKButtonPanel() {
            InitializeComponent();
            Resize += HKButtonPanel_Resize;
        }

        public void HKButtonPanel_Resize(object sender, EventArgs e) {
            int selfWidth = 0;
            foreach (PanelItem item in items) {
                if (item.isButton) {
                    selfWidth += item.button.Width;
                }else {
                    selfWidth += item.blank.Width;
                }
            }
            if (selfWidth == 0) {
                selfWidth = 100;
            }
            Width = selfWidth + 2 * _border;
            BGPanel.Location = new Point(_border, _border);
            BGPanel.Width = Width - 2 * _border;
            BGPanel.Height = Height - 2 * _border;
        }
        public int border {
            get {
                return _border;
            }
            set {
                _border = value;
            }
        }
        public Color borderColor {
            get {
                return BackColor;
            }
            set {
                BackColor = value;
            }
        }
        public Color backgroundColor {
            get {
                return BGPanel.BackColor;
            }
            set {
                BGPanel.BackColor = value;
            }
        }

        public void addButton(string title,int width,buttonClickHandler buttonClick) {
            Button btn = new Button();
            BGPanel.Controls.Add(btn);
            btn.Dock = DockStyle.Left;
            btn.BringToFront();
            btn.Width = width;
            btn.Name = title;
            btn.Text = title;
            btn.BackColor = Color.Transparent;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 2;
            btn.FlatAppearance.BorderColor = borderColor;
            btn.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btn.Font = new Font("微软雅黑", 10, FontStyle.Bold);
            btn.ForeColor = Color.SeaShell;
            btn.Click += Btn_Click;

            PanelItem newItem = new PanelItem();
            newItem.button = btn;
            newItem.isButton = true;
            newItem.buttonClick = buttonClick;
            items.Add(newItem);
        }
        public void addBlank(int width) {
            Panel panel = new Panel();
            BGPanel.Controls.Add(panel);
            panel.Dock = DockStyle.Left;
            panel.BringToFront();
            panel.BackColor = Color.Transparent;
            panel.Width = width;
            PanelItem newItem = new PanelItem();
            newItem.isButton = false;
            newItem.blank = panel;
            items.Add(newItem);
        }
        public void setButtonEnable(string title,bool value) {
            foreach (PanelItem item in items) {
                if (item.isButton == true && item.button.Text.Equals(title)) {
                    item.button.Enabled = value;
                }
            }
        }
        private void Btn_Click(object sender, EventArgs e) {
            foreach (PanelItem item in items) {
                if (item.button == sender) {
                    if (item.buttonClick != null) {
                        item.buttonClick(item.button.Text);
                    }
                }
            }
        }
    }
}
