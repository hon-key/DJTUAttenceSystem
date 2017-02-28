using System;
using System.Windows.Forms;
using HelperSpace;

namespace DJTUAttenceSystem {
    public partial class Entrance : Form {
        
        public Entrance() {
            InitializeComponent();
            Helper.setFormShaddow(this);
        }
        private void Entrance_Load(object sender, EventArgs e) {
            configureColor();
            configureLayout();
            ConfigureMouseEvent();
            showPanel(new Login());
        }
        /* ---- Configure ---- */
        private void configureLayout() {
            CloseBtn.Width = CloseBtn.Height * 2;
            MaxSizeBtn.Width = MaxSizeBtn.Height * 2;
            MinSizeBtn.Width = MinSizeBtn.Height * 2;
        }
        private void configureColor() {
            container.BackColor = Helper.ToColor(Helper.normalColor);
            topBar.BackColor = Helper.ToColor(Helper.deepColor);
            CloseBtn.BackColor = Helper.ToColor(Helper.deepColor);
            MaxSizeBtn.BackColor = Helper.ToColor(Helper.deepColor);
            MinSizeBtn.BackColor = Helper.ToColor(Helper.deepColor);
        }
        private void ConfigureMouseEvent() {
            topBar.MouseDown += dragTopBarToMove;
            CloseBtn.MouseClick += closeBtn_Click;
            MaxSizeBtn.MouseClick += MaxSizeBtn_Click;
            MinSizeBtn.MouseClick += MinSizeBtn_Click;
        }
        /* ---- Change panel ---- */
        public void showPanel(Control userControl) {
            container.Controls.Clear();
            container.Controls.Add(userControl);
        }
        /* ----- Event ----- */
        private void dragTopBarToMove(object sender,MouseEventArgs e) {
            Helper.dragControl(this);
        }
        private void closeBtn_Click(object sender, MouseEventArgs e) {
            Environment.Exit(0);
        }
        private void MaxSizeBtn_Click(object sender, MouseEventArgs e) {
            if (WindowState == FormWindowState.Maximized) {
                WindowState = FormWindowState.Normal;
            }else if (WindowState == FormWindowState.Normal) {
                WindowState = FormWindowState.Maximized;
            }
        }
        private void MinSizeBtn_Click(object sender, MouseEventArgs e) {
            WindowState = FormWindowState.Minimized;
        }
    }
}
