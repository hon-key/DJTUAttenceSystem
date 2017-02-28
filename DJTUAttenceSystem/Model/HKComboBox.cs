using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Collections;

namespace DJTUAttenceSystem.Model {
    public partial class HKComboBox : UserControl {
        public delegate void SelectedChangedHandler(HKComboBox box, string newValue);
        public SelectedChangedHandler selectedChanged;
        public HKComboBox() {
            InitializeComponent();
            this.Resize += resize;
            BackColor = Color.Red;
            
        }
        private void HKComboBox_Load(object sender, EventArgs e) {
            resize(null, null);
        }
        public void resize(object sender, EventArgs e) {
            title.Location = new Point(3, Height / 2 - title.Height / 2);
            comboBox.Location = new Point(3 + title.Width, Height / 2 - comboBox.Height / 2);
            Width = comboBox.Width + title.Width + 6;
        }
        public ComboBox cmbBox {
            get {
                return comboBox;
            }
        }
        public Color titleColor {
            get {
                return title.ForeColor;
            }
            set {
                title.ForeColor = value;
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
        public Color comboBGColor {
            get {
                return comboBox.BackColor;
            }
            set {
                comboBox.BackColor = value;
            }
        }
        public Color comboForeColor {
            get {
                return comboBox.ForeColor;
            }
            set {
                comboBox.ForeColor = value;
            }
        }
        public int comboWidth {
            get {
                return comboBox.Width;
            }
            set {
                comboBox.Width = value;
            }
        }
        public ComboBoxStyle dropDownStyle {
            get {
                return comboBox.DropDownStyle;
            }
            set {
                comboBox.DropDownStyle = value;
            }
        }
        public FlatStyle flatStyle {
            get {
                return comboBox.FlatStyle;
            }
            set {
                comboBox.FlatStyle = value;
            }
        }
        public String titleText {
            get {
                return title.Text;
            }
            set {
                title.Text = value;
            }
        }
        public string selectedString {
            get {
                return comboBox.GetItemText(comboBox.SelectedItem);
            }
        }
        public void add(int i) {
            comboBox.Items.Add(i);
        }
        public void clear() {
            comboBox.Items.Clear();
        }
        public int itemCount() {
            return comboBox.Items.Count;
        }
        public void add(string s) {
            comboBox.Items.Add(s);
        }

        /* ---- special usage (unsafe) ---- */
        public void setSelectedIntValue(int value) {
            for (int i = 0; i < this.itemCount(); i++) {
                object item = this.cmbBox.Items[i];
                string itemText = this.cmbBox.GetItemText(item);
                int itemTextIntegerValue = int.Parse(itemText);
                if (value == itemTextIntegerValue) {
                    this.cmbBox.SelectedIndex = i;
                }
            }
        }
        public int getSelectedIntValue() {
            try {
                return int.Parse(this.selectedString);
            } catch {
                return -1;
            }
        }
        public void setIntSelections(int startIndex, int maxIndex) {
            this.clear();
            for (int i = startIndex; i <= maxIndex; i++) {
                this.add(i);
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (selectedChanged != null) {
                selectedChanged(this,selectedString);
            }
        }
    }
}
