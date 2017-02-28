using System;
using HelperSpace;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;

namespace DJTUAttenceSystem {
    public partial class AddPanel : UserControl {
        public static int defaultWidth = 100;
        public static int defaultHeight = 150;
        public delegate void titleHnadler(string title);
        public ArrayList buttonHandlers = new ArrayList();
        public AddPanel() {
            InitializeComponent();
            configureColor();
            configureLayout();
        }
        /* ---- configuration ---- */
        private void configureColor() {
            bgPanel.BackColor = Helper.ToColor(Helper.deepColor);
        }
        private void configureLayout() {
            Resize += resize;
        }
        /* ---- layout ---- */
        public void resize(object sender, EventArgs e) {
            layoutButtonsHeight();
        }
        private void layoutButtonsHeight() {
            int avgHeight = this.Height / bgPanel.Controls.Count;
            foreach (Control con in bgPanel.Controls) {
                con.Height = avgHeight;
            }
        }
        /* ---- Relate to add button Action ---- */
        public void add(string title,Color color,titleHnadler handler) {
            if (containsTheSameTitle(title)) {return;}
            Button btn = new Button();
            btn.Text = title;
            initButtonPattern(btn);
            initButtonColors(btn,color);
            addButtonToPanel(btn);
            btn.Height = this.Height / bgPanel.Controls.Count;
            configureEvent(btn,title,handler); 
        }
        private bool containsTheSameTitle(string title) {
            foreach (Button btn in bgPanel.Controls) {
                if (btn.Text.Equals(title)) {
                    return true;
                }
            }
            return false;
        }
        private void initButtonPattern(Button btn) {
            btn.Dock = DockStyle.Top;
            btn.BackColor = Color.Transparent;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("微软雅黑", 12, FontStyle.Bold);
        }
        private void initButtonColors(Button btn,Color color) {
            btn.FlatAppearance.MouseOverBackColor = color;
            btn.ForeColor = Color.SeaShell;
        }
        private void addButtonToPanel(Button btn) {
            bgPanel.Controls.Add(btn);
            btn.BringToFront();
        }
        private void configureEvent(Button btn,string title,titleHnadler handler) {
            btn.MouseClick += Bt_MouseClick;
            buttonHandlers.Add(new AddButtonHandler(title, handler));
        }

        /* ---- Relate to add and remove panel ---- */
        public void addToParent(Control parent) {
            parent.Controls.Add(this);
            BringToFront();
            Focus();
        }
        public void removeFromParent() {
            if (Parent != null) {
                Parent.Controls.Remove(this);
            }
        }
        private void Bt_MouseClick(object sender, MouseEventArgs e) {
            Button bt = (Button)sender;
            foreach (AddButtonHandler handler in buttonHandlers) {
                if (handler.title.Equals(bt.Text)) {
                    handler.method(bt.Text);
                }
            }
            removeFromParent();
        }

        private void panel_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            Color color = Helper.ToColor(Helper.normalColor);
            List <float> hsb = Helper.getHSB(color);
            hsb[HSBProperty.bri] -= 0.2f;
            color = Helper.FromAhsb(HSBProperty.alphaFull, hsb);
            ControlPaint.DrawBorder(g, this.bgPanel.ClientRectangle,
                color, 2, ButtonBorderStyle.Solid, color, 2, ButtonBorderStyle.Solid,
                color, 2, ButtonBorderStyle.Solid, color, 2, ButtonBorderStyle.Solid);
            g.Dispose();
        }
    }
    public class AddButtonHandler {
        public string title;
        public AddPanel.titleHnadler method;
        public AddButtonHandler(string title, AddPanel.titleHnadler handler) {
            this.title = title;
            method = handler;
        }
    }
}
