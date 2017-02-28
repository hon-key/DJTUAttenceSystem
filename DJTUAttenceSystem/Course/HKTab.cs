using System;
using System.Drawing;
using System.Windows.Forms;
using HelperSpace;
using System.Collections;
using DJTUAttenceSystem.Model;

namespace DJTUAttenceSystem.Course {
    public partial class HKTab : UserControl {
        public static int unselected = -1;
        public delegate void tabHandler(string title,int index,object userData);
        public delegate void menuHandler(string btnTitle, int index,string itemString, object userData);
        private ArrayList userDatas = new ArrayList();
        public Font btnFont;
        public Color foreColor;
        public Color mouseOverColor;
        public tabHandler tab;
        public menuHandler rightClick;
        public int border = 0;
        public int selectedIndex = unselected;
        public string selectedTitle = null;
        public HKTab() {
            InitializeComponent();
            Resize += HKTab_Resize;
            Helper.hideScrollBar(container, Helper.scrollBarType.HorizentalAndVertical);
        }
        /* ----- Layout ----- */
        private void HKTab_Resize(object sender, EventArgs e) {
            layoutContainer();
        }
        private void layoutContainer() {
            container.Location = new Point(border, border);
            container.Height = Height - border * 2;
            container.Width = Width - border * 2;
            container.AutoScroll = true;
        }
        /* ----- Property ----- */
        public int borderWidth {
            get {
                return border;
            }
            set {
                border = value;
                HKTab_Resize(null, null);
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
        public Color btnMouseOverColor {
            get {
                return mouseOverColor;
            }
            set {
                mouseOverColor = value;
                foreach (Control con in container.Controls) {
                    ((Button)con).FlatAppearance.MouseOverBackColor = value;
                }
            }
        }
        public Font textFont {
            get {
                return btnFont;
            }

            set {
                btnFont = value;
                foreach  (Control con in container.Controls) {
                    con.Font = value;
                }
            }
        }
        public Color textColor {
            set {
                foreColor = value;
                foreach (Control con in container.Controls) {
                    con.ForeColor = value;
                }
            }
            get {
                return foreColor;
            }
        }
        public Color containerBackColor {
            get {
                return container.BackColor;
            }

            set {
                container.BackColor = value;
            }
        }
        public void setTabHandler(tabHandler tab) {
            this.tab = tab;
        }
        public object userDataOfSelectedIndex() {
            if (selectedIndex == -1) {
                return null;
            }
            return userDatas[selectedIndex];
        }
        /* ----- Add a new Tab Button ----- */
        public void addNewTab(string title,object userData) {
            Button newBtn = new Button();
            setBtnPattern(ref newBtn,title);
            container.Controls.Add(newBtn);
            userDatas.Add(userData);
            newBtn.BringToFront();
            setBtnRightClickMenu(ref newBtn);
            setBtnToolTip(ref newBtn, title);
        }
        public void clearAllTabs() {
            container.Controls.Clear();
            userDatas.Clear();
            selectedIndex = -1;
            selectedTitle = null;
        }
        private void setBtnPattern(ref Button btn,string title) {
            btn.Dock = DockStyle.Left;
            btn.AutoSize = true;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.MouseOverBackColor = mouseOverColor;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = btnFont;
            btn.ForeColor = foreColor;
            btn.Click += tabsBtn_Click;
            btn.Text = title;
            btn.Name = title;
            btn.Tag = container.Controls.Count;
        }
        private void setBtnRightClickMenu(ref Button btn) {
            HKMenuStrip menuStrip = new HKMenuStrip();
            menuStrip.addItem(new HKMenuStrip.ItemStruct("改名", menuStrip_itemClick, btn));
            menuStrip.addItem(new HKMenuStrip.ItemStruct("删除", menuStrip_itemClick, btn));
            btn.ContextMenuStrip = menuStrip;
        }
        private void setBtnToolTip(ref Button btn,string text) {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(btn, text);
        }
        /* ----- Right button click ----- */
        private void menuStrip_itemClick(string itemText,object userData) {
            Button btn = (Button)userData;
            if (btn != null && rightClick != null) {
                Console.WriteLine(btn.Tag);
                rightClick(btn.Name, (int)btn.Tag, itemText, userDatas[(int)btn.Tag]);
            }
        }
        /* ----- tabsBtn Click Event ----- */
        private void tabsBtn_Click(object sender, EventArgs e) {
            Button currentBtn = (Button)sender;
            setBtnDisable(ref currentBtn);
            setOtherBtnEnable(ref currentBtn);
            if (tab != null) {
                tab(currentBtn.Name,(int)currentBtn.Tag,userDatas[(int)currentBtn.Tag]);
            }
        }
        private void setBtnDisable(ref Button btn) {
            Helper.RemoveEvent(btn, "Click");
            btn.BackColor = mouseOverColor;
            setSelected(ref btn);
        }
        private void setSelected(ref Button btn) {
            selectedIndex = (int)btn.Tag;
            selectedTitle = btn.Text;
        }
        private void setOtherBtnEnable(ref Button theButtonExcept) {
            foreach (Button otherBtn in container.Controls) {
                if (!otherBtn.Name.Equals(theButtonExcept.Name)) {
                    Helper.RemoveEvent(otherBtn, "Click");
                    otherBtn.Click += tabsBtn_Click;
                    otherBtn.BackColor = container.BackColor;
                }
            }
        }

    }
}
