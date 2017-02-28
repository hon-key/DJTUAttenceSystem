using System;
using HelperSpace;
using System.Windows.Forms;
using System.Drawing;
using DJTUAttenceSystem.Model;
using DJTUAttenceSystem.LibraryHall;

namespace DJTUAttenceSystem {
    public partial class LoginCell : UserControl {
        public int borderWidth = 5;
        public static int cellHeight = 130;
        private int topBarHeight = (int)(cellHeight * (1.0 / 3.0));
        private Color bgColor = Helper.getColorByAddBri(Helper.ToColor(Helper.deepColor), +0.05f);
        public HKTableView tableView;
        public Login loginHall;
        public string libraryUUID;
        public LoginCell() {
            InitializeComponent();
            this.Resize += LoginCell_Resize;
            nameLabel.contentText = "未命名";
            introlLabel.Text = "缺省";
        }
        public LoginCell(string name,string intro,string date) {
            InitializeComponent();
            this.Resize += LoginCell_Resize;
            Anchor = AnchorStyles.None;
            nameLabel.contentText = name;
            introlLabel.Text = intro;
            timeLabel.Text = "Last modify: " + date.ToString();
            configureColor();
            configureEvent();
        }
        /* ----- configuration ----- */
        private void configureEvent() {
            MouseLeave += on_mouseLeave;
            MouseEnter += on_mouseEnter;
            bar.MouseEnter += on_mouseEnter;
            remarkPanel.MouseEnter += on_mouseEnter;
            bottomPanel.MouseEnter += on_mouseEnter;
            introlLabel.MouseEnter += on_mouseEnter;
            nameLabel.MouseEnter += on_mouseEnter;
            deleteButton.MouseEnter += on_mouseEnter;
            exportButton.MouseEnter += on_mouseEnter;
            timeLabel.MouseEnter += on_mouseEnter;
            nameLabel.Click += openLibrary;
            introlLabel.Click += openLibrary;
            timeLabel.Click += openLibrary;
            bar.Click += openLibrary;
            bottomPanel.Click += openLibrary;
        }
        private void configureColor() {
            BGPanel.BackColor = bgColor;
            BackColor = bgColor;
            bar.BackColor = Helper.ToColor(Helper.deepColor);
            deleteButton.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            exportButton.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
        }
        /*----- layout -----*/
        private void LoginCell_Resize(object sender, EventArgs e) {
            LayoutBGPanel();
            layoutTopBar();
            layoutLabel();
            layoutButton();
        }
        private void LayoutBGPanel() {
            BGPanel.Width = Width - 2 * borderWidth;
            BGPanel.Height = Height - 2 * borderWidth;
            BGPanel.Location = new Point(borderWidth, borderWidth);
        }
        private void layoutTopBar() {
            bar.Height = (int)(BGPanel.Height * 0.25);
            remarkPanel.Height = (int)(BGPanel.Height * 0.5);
            bottomPanel.Height = (int)(BGPanel.Height * 0.25);
        }
        private void layoutLabel() {
            nameLabel.Width = 200;
            nameLabel.Location = new Point(20, bar.Height / 2 - nameLabel.Height / 2);

            introlLabel.Location = new Point(20, 10);
            introlLabel.Height = remarkPanel.Height - 20;
            introlLabel.Width = remarkPanel.Width - 20;
        }
        private void layoutButton() {
            exportButton.Width = exportButton.Height;
            deleteButton.Width = deleteButton.Height;
        }
        /* ----- Event ----- */
        private void on_mouseEnter(object sender, EventArgs e) {
            BackColor = Helper.ToColor(Helper.specialColor);
            foreach (Panel panel in tableView.Controls) {
                Control con = panel.Controls[0];
                if (con != this) {
                    panel.Controls[0].BackColor = bgColor;
                }
            }
        }
        private void on_mouseLeave(object sender, EventArgs e) {
            BackColor = bgColor;
            
        }
        private void openLibrary(object sender, EventArgs e) {
            if (Helper.IsNullOrWhiteSpace(GlobalStation.shareInstance.librarys[libraryUUID].password)) {
                open();
                return;
            }
            InputResult result = showPasswordInputForm();
            if (result.confirm == true) {
                if (verify(result.input) == true)
                    open();
                else {
                    HKConfirmForm.showConfirmForm("密码不正确");
                    openLibrary(null, null);
                }
            }
        }
        private InputResult showPasswordInputForm() {
            HKTextInputForm form = new HKTextInputForm();
            form.titleText = "请输入密码";
            form.isSecurity = true;
            return form.showTextInputForm();
        }
        private bool verify(string password) {
            if (GlobalStation.shareInstance.librarys[libraryUUID].password.Equals(password)) {
                return true;
            }
            return false;
        }
        private void open() {
            GlobalStation.shareInstance.librarys.isCustomize = false;
            LibraryHallPanel hall = new LibraryHallPanel();
            hall.libraryUUID = this.libraryUUID;
            GlobalStation.shareInstance.entrance.showPanel(hall);
        }
        private void deleteButton_Click(object sender, EventArgs e) {
            if (Helper.IsNullOrWhiteSpace(GlobalStation.shareInstance.librarys[libraryUUID].password)) {
                showDeleteConfirmForm();
                return;
            } else {
                InputResult result = showPasswordInputForm();
                if (result.confirm == true && verify(result.input) == true) {
                    showDeleteConfirmForm();
                } else if (result.confirm == true && verify(result.input) == false) {
                    HKConfirmForm.showConfirmForm("密码不正确");
                    deleteButton_Click(null, null);
                }
            }
            
        }
        private void showDeleteConfirmForm() {
            HKConfirmForm form = new HKConfirmForm();
            form.title = "确定要删除？";
            if (form.showConfirm() == true) {
                AttandanceLibrary lib = GlobalStation.shareInstance.librarys[libraryUUID];
                GlobalStation.shareInstance.librarys.removeLib(libraryUUID);
                GlobalStation.shareInstance.librarySave(null, delegate () {
                    GlobalStation.shareInstance.librarys.addLib(lib);
                });
                loginHall.initTableViewContent();
                loginHall.resize(null, null);
            }
        }
        private void exportButton_Click(object sender, EventArgs e) {
            try {
                GlobalStation.shareInstance.librarys.isCustomize = false;
                AttandanceLibrary lib = GlobalStation.shareInstance.librarys[libraryUUID];
                string path = HKSaveFileDialog.saveTo(HKDialogFilter.Library);
                FileSerializeStorage<AttandanceLibrary>.save(lib, path);
                HKConfirmForm.showConfirmForm("导出成功");
            } catch (HKSaveFileDialog.CancelSaveFileException) {
            } catch (FileSerializeStorage<AttandanceLibrary>.FileSaveException ex) {
                HKConfirmForm.showConfirmForm(ex.Message);
            }
        }
    }
}
