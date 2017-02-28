using System;
using System.Drawing;
using HelperSpace;
using System.Windows.Forms;
using DJTUAttenceSystem.LibraryHall;
using DJTUAttenceSystem.Model;

namespace DJTUAttenceSystem {
    public partial class Login : UserControl {

        public Login() {
            InitializeComponent();
            Load += Login_Load;
            configureMainPanelLayout();
            configureColor();
            configureEvent();
            configureTableView();
        }
        private void Login_Load(object sender, EventArgs e) {
            initTableViewContent();
        }
        /* ----- configure ----- */
        private void configureEvent() {
            addButton.MouseClick += addButton_Click;
        }
        private void configureMainPanelLayout() {
            this.Resize += resize;
            Dock = DockStyle.Fill;
        }
        private void configureColor() {
            addButton.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            SettingButton.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
        }
        private void configureTableView() {
            hkTableView1.mode = HKTableViewMode.vertical;
            hkTableView1.vertical_ResizeForEveryCell = tableViewCell_Resize;
        }
        /* ----- Relate to TableView ----- */
        public void initTableViewContent() {
            hkTableView1.clear();
            foreach (AttandanceLibrary lib in GlobalStation.shareInstance.librarys.collections) {
                LoginCell cell = new LoginCell(lib.name, lib.remarks, lib.lastModified.ToString());
                cell.libraryUUID = lib.UUID;
                cell.Height = LoginCell.cellHeight;
                cell.tableView = hkTableView1;
                cell.loginHall = this;
                hkTableView1.add(cell);
            }
            hkTableView1.HKTableView_Resize(null, null);
        }
        private void tableViewCell_Resize(Panel panel,Control control) {
            panel.Height = control.Height + 40;
            control.Width = panel.Width - 150;
            control.Location = new Point(panel.Width / 2 - control.Width / 2, panel.Height / 2 - control.Height / 2);
        }
        /* ----- relate to addPanel ----- */
        private void addButton_Click(object sender,MouseEventArgs e) {
            if (!isAddPanelInlude()) {
                includeAddPanel();
            } else {
                removeAddPanel();
            }
        }
        private bool isAddPanelInlude() {
            if (Controls.Find("addPanel", false).Length == 0) {
                return false;
            }else {
                return true;
            }
        }
        private void includeAddPanel() {
            AddPanel addPanel = new AddPanel();
            addPanel.Name = "addPanel";
            addPanel.add("创建", Color.ForestGreen, addPanel_CreateButton_Click);
            addPanel.add("打开", Color.OrangeRed, addPanel_openButton_Click);
            addPanel.add("导入", Color.DarkOrange, addPanel_importButton_Click);
            addPanel.addToParent(this);
            addPanel.Location =
                new Point(addButton.Location.X + addButton.Width / 2 - addPanel.Width / 2, addButton.Location.Y + addButton.Height);
            addPanel.Size = new Size(AddPanel.defaultWidth, AddPanel.defaultHeight);

        }
        private void moveAddPanel() {
            if (isAddPanelInlude()) {
                AddPanel addPanel = (AddPanel)this.Controls.Find("addPanel", false)[0];
                addPanel.Size = new Size(AddPanel.defaultWidth, AddPanel.defaultHeight);
                addPanel.Location = new Point(
                    addButton.Location.X + addButton.Width / 2 - addPanel.Width / 2,
                    addButton.Location.Y + addButton.Height);
            }
        }
        private void removeAddPanel() {
            AddPanel addPanel = (AddPanel)this.Controls.Find("addPanel", false)[0];
            addPanel.removeFromParent();
        }
        private void addPanel_CreateButton_Click(string title) {
            if (title.Equals("创建")) {
                LibraryAddPanel lap = new LibraryAddPanel();
                GlobalStation.shareInstance.entrance.showPanel(lap);
            }
        }
        private void addPanel_openButton_Click(string title) {
            try {
                string path = HKOpenFileDialog.selectFile(HKDialogFilter.Library);
                AttandanceLibrary lib = FileSerilizeOpener<AttandanceLibrary>.open(path);
                GlobalStation.shareInstance.librarys.isCustomize = true;
                GlobalStation.shareInstance.librarys.customizeLibrary = CustomLibrary.createLibrary(lib, path);
                LibraryHallPanel hall = new LibraryHallPanel();
                hall.libraryUUID = lib.UUID;
                GlobalStation.shareInstance.entrance.showPanel(hall);
            }catch(HKOpenFileDialog.CancelOpenFileException) { }
        }
        private void addPanel_importButton_Click(string title) {
            try {
                string path = HKOpenFileDialog.selectFile(HKDialogFilter.Library);
                AttandanceLibrary lib = FileSerilizeOpener<AttandanceLibrary>.open(path);
                AttandanceLibrary oldLib = null;
                DJTUBinary librarys = GlobalStation.shareInstance.librarys;
                librarys.isCustomize = false;
                if (librarys.containsLibrary(lib))
                    handleOverwrite(lib,ref oldLib);
                librarys.addLib(lib);
                GlobalStation.shareInstance.librarySave(delegate() {
                    initTableViewContent();
                    resize(null, null);
                }, delegate () {
                    if (oldLib != null) librarys.addLib(oldLib);
                    librarys.removeLib(lib.UUID);
                });
            } catch (HKOpenFileDialog.CancelOpenFileException) { }
        }
        private void handleOverwrite(AttandanceLibrary lib, ref AttandanceLibrary oldLib) {
            DJTUBinary librarys = GlobalStation.shareInstance.librarys;
            HKConfirmForm form = new HKConfirmForm();
            form.title = "已存在相同的库，是否覆盖？";
            if (form.showConfirm() == true) {
                oldLib = librarys[lib.UUID];
                librarys.removeLib(lib.UUID);
            } else
                lib.UUID = Guid.NewGuid().ToString();
        }
        /* ----- Relate to Resize ----- */
        public void resize(object obj,EventArgs e) {
            layoutSettingButton();
            layoutAddButton();
            moveAddPanel();
        }
        private void layoutSettingButton() {
            SettingButton.Size = new Size(60, 50);
            SettingButton.Location = new Point(topBar.Width - 10 - SettingButton.Width, topBar.Height / 2 - SettingButton.Height / 2);
        }
        private void layoutAddButton() {
            addButton.Size = new Size(SettingButton.Width, SettingButton.Height);
            addButton.Location = new Point(SettingButton.Location.X - addButton.Width - 10, SettingButton.Location.Y);
        }
    }
}
