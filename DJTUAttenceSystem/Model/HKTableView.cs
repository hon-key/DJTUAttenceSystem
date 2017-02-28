using System;
using System.Windows.Forms;
using HelperSpace;

namespace DJTUAttenceSystem.Model {
    public enum HKTableViewMode {
        vertical = 1,
        horizental = 2
    }
    public partial class HKTableView : UserControl {
        public HKTableViewMode mode = HKTableViewMode.vertical;
        public delegate void Vertical_ResizeHandler(Panel parent,Control control);
        public delegate void Horizental_ResizeHandler(Panel parent,Control control);
        public Vertical_ResizeHandler vertical_ResizeForEveryCell;
        public Horizental_ResizeHandler horizental_ResizeForEveryCell;
        public HKTableView() {
            InitializeComponent();
            Helper.hideScrollBar(this, Helper.scrollBarType.HorizentalAndVertical);
            Resize += HKTableView_Resize;
        }
        /* ----- Resize ----- */
        public void HKTableView_Resize(object sender, EventArgs e) {
            if (mode == HKTableViewMode.vertical) {
                vertical_Resize();
            } else {
                horizental_Resize();
            }
        }
        private void vertical_Resize() {
            foreach (Panel panel in Controls) {
                if (vertical_ResizeForEveryCell != null) {
                    vertical_ResizeForEveryCell(panel,panel.Controls[0]);
                }
            }
        }
        private void horizental_Resize() {
            foreach (Panel panel in Controls) {
                if (horizental_ResizeForEveryCell != null) {
                    horizental_ResizeForEveryCell(panel,panel.Controls[0]);
                }
            }
        }

        public void add(Control control) {
            Panel panel = new Panel();
            configurePanel(ref panel,control);
            if (mode == HKTableViewMode.vertical) {
                vertical_Configure(control);
            }else {
                horizental_Configure(control);
            }
        }
        private void configurePanel(ref Panel panel,Control control) {
            Controls.Add(panel);
            panel.Controls.Add(control);
            panel.BringToFront();
        }
        private void vertical_Configure(Control control) {
            Panel panel = (Panel)control.Parent;
            panel.Dock = DockStyle.Top;
        }
        private void horizental_Configure(Control control) {
            Panel panel = (Panel)control.Parent;
            panel.Dock = DockStyle.Left;
        }
        public void clear() {
            Controls.Clear();
        }

    }
}
