namespace DJTUAttenceSystem.Course {
    partial class CourseHall {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseHall));
            this.bar = new System.Windows.Forms.Panel();
            this.mainGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseAttribute = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.examMethod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.examAttribute = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.isExamDelay = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainGridBorderPanel = new System.Windows.Forms.Panel();
            this.excelImport = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.scoreCalBtn = new System.Windows.Forms.Button();
            this.excelExport = new System.Windows.Forms.Button();
            this.modeLabel = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.mainGrid_extraAddBtn = new System.Windows.Forms.Button();
            this.tabs_addBtn = new System.Windows.Forms.Button();
            this.mainGrid_addRowBtn = new System.Windows.Forms.Button();
            this.bar_backBtn = new System.Windows.Forms.Button();
            this.bar_modeBtn = new System.Windows.Forms.Button();
            this.bar_settingBtn = new System.Windows.Forms.Button();
            this.bar_deleteBtn = new System.Windows.Forms.Button();
            this.tabs = new DJTUAttenceSystem.Course.HKTab();
            this.courseTitle = new DJTUAttenceSystem.Model.HorizontalScrollLabel();
            this.bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.mainGridBorderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar
            // 
            this.bar.Controls.Add(this.courseTitle);
            this.bar.Controls.Add(this.bar_backBtn);
            this.bar.Controls.Add(this.bar_modeBtn);
            this.bar.Controls.Add(this.bar_settingBtn);
            this.bar.Controls.Add(this.bar_deleteBtn);
            this.bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar.Location = new System.Drawing.Point(0, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(1736, 100);
            this.bar.TabIndex = 0;
            // 
            // mainGrid
            // 
            this.mainGrid.AllowUserToAddRows = false;
            this.mainGrid.AllowUserToDeleteRows = false;
            this.mainGrid.AllowUserToResizeRows = false;
            this.mainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mainGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete,
            this.name,
            this.id,
            this.sex,
            this.major,
            this.grade,
            this._class,
            this.CourseAttribute,
            this.examMethod,
            this.examAttribute,
            this.isExamDelay,
            this.score});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 5.625F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.mainGrid.EnableHeadersVisualStyles = false;
            this.mainGrid.GridColor = System.Drawing.Color.PapayaWhip;
            this.mainGrid.Location = new System.Drawing.Point(68, 40);
            this.mainGrid.MultiSelect = false;
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mainGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.mainGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainGrid.RowTemplate.Height = 30;
            this.mainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mainGrid.Size = new System.Drawing.Size(687, 426);
            this.mainGrid.TabIndex = 1;
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "姓名";
            this.name.Name = "name";
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 87;
            // 
            // id
            // 
            this.id.HeaderText = "学号";
            this.id.Name = "id";
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 87;
            // 
            // sex
            // 
            this.sex.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sex.HeaderText = "性别";
            this.sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sex.Name = "sex";
            this.sex.Width = 87;
            // 
            // major
            // 
            this.major.HeaderText = "专业";
            this.major.Name = "major";
            this.major.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.major.Width = 87;
            // 
            // grade
            // 
            this.grade.HeaderText = "年级";
            this.grade.Name = "grade";
            this.grade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.grade.Width = 87;
            // 
            // _class
            // 
            this._class.HeaderText = "班级";
            this._class.Name = "_class";
            this._class.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._class.Width = 87;
            // 
            // CourseAttribute
            // 
            this.CourseAttribute.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.CourseAttribute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CourseAttribute.HeaderText = "选课属性";
            this.CourseAttribute.Items.AddRange(new object[] {
            "必修",
            "选修"});
            this.CourseAttribute.Name = "CourseAttribute";
            this.CourseAttribute.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CourseAttribute.Width = 151;
            // 
            // examMethod
            // 
            this.examMethod.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.examMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.examMethod.HeaderText = "考核方式";
            this.examMethod.Items.AddRange(new object[] {
            "未确定",
            "其他"});
            this.examMethod.Name = "examMethod";
            this.examMethod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.examMethod.Width = 151;
            // 
            // examAttribute
            // 
            this.examAttribute.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.examAttribute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.examAttribute.HeaderText = "考试性质";
            this.examAttribute.Items.AddRange(new object[] {
            "正常考试",
            "其他"});
            this.examAttribute.Name = "examAttribute";
            this.examAttribute.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.examAttribute.Width = 151;
            // 
            // isExamDelay
            // 
            this.isExamDelay.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.isExamDelay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isExamDelay.HeaderText = "是否缓考";
            this.isExamDelay.Items.AddRange(new object[] {
            "非缓考",
            "缓考"});
            this.isExamDelay.Name = "isExamDelay";
            this.isExamDelay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isExamDelay.Width = 151;
            // 
            // score
            // 
            this.score.HeaderText = "成绩";
            this.score.Name = "score";
            this.score.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.score.Width = 87;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.mainGridBorderPanel);
            this.mainPanel.Controls.Add(this.excelImport);
            this.mainPanel.Controls.Add(this.reportBtn);
            this.mainPanel.Controls.Add(this.scoreCalBtn);
            this.mainPanel.Controls.Add(this.excelExport);
            this.mainPanel.Controls.Add(this.mainGrid_extraAddBtn);
            this.mainPanel.Controls.Add(this.tabs_addBtn);
            this.mainPanel.Controls.Add(this.mainGrid_addRowBtn);
            this.mainPanel.Controls.Add(this.modeLabel);
            this.mainPanel.Controls.Add(this.tabs);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 100);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1736, 835);
            this.mainPanel.TabIndex = 2;
            // 
            // mainGridBorderPanel
            // 
            this.mainGridBorderPanel.Controls.Add(this.mainGrid);
            this.mainGridBorderPanel.Location = new System.Drawing.Point(336, 177);
            this.mainGridBorderPanel.Name = "mainGridBorderPanel";
            this.mainGridBorderPanel.Size = new System.Drawing.Size(822, 501);
            this.mainGridBorderPanel.TabIndex = 11;
            // 
            // excelImport
            // 
            this.excelImport.FlatAppearance.BorderSize = 0;
            this.excelImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.excelImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excelImport.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.excelImport.ForeColor = System.Drawing.Color.SeaShell;
            this.excelImport.Location = new System.Drawing.Point(1380, 772);
            this.excelImport.Name = "excelImport";
            this.excelImport.Size = new System.Drawing.Size(131, 39);
            this.excelImport.TabIndex = 10;
            this.excelImport.Text = "excel导入";
            this.excelImport.UseVisualStyleBackColor = true;
            this.excelImport.Click += new System.EventHandler(this.excelImport_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.FlatAppearance.BorderSize = 0;
            this.reportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.reportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reportBtn.ForeColor = System.Drawing.Color.SeaShell;
            this.reportBtn.Location = new System.Drawing.Point(977, 772);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(131, 39);
            this.reportBtn.TabIndex = 9;
            this.reportBtn.Text = "查看报告";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // scoreCalBtn
            // 
            this.scoreCalBtn.FlatAppearance.BorderSize = 0;
            this.scoreCalBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.scoreCalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreCalBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scoreCalBtn.ForeColor = System.Drawing.Color.SeaShell;
            this.scoreCalBtn.Location = new System.Drawing.Point(1164, 772);
            this.scoreCalBtn.Name = "scoreCalBtn";
            this.scoreCalBtn.Size = new System.Drawing.Size(131, 39);
            this.scoreCalBtn.TabIndex = 8;
            this.scoreCalBtn.Text = "成绩计算";
            this.scoreCalBtn.UseVisualStyleBackColor = true;
            this.scoreCalBtn.Click += new System.EventHandler(this.scoreCalBtn_Click);
            // 
            // excelExport
            // 
            this.excelExport.FlatAppearance.BorderSize = 0;
            this.excelExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.excelExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excelExport.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.excelExport.ForeColor = System.Drawing.Color.SeaShell;
            this.excelExport.Location = new System.Drawing.Point(1574, 772);
            this.excelExport.Name = "excelExport";
            this.excelExport.Size = new System.Drawing.Size(131, 39);
            this.excelExport.TabIndex = 7;
            this.excelExport.Text = "excel导出";
            this.excelExport.UseVisualStyleBackColor = true;
            this.excelExport.Click += new System.EventHandler(this.excelBtn_Click);
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modeLabel.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modeLabel.ForeColor = System.Drawing.Color.Wheat;
            this.modeLabel.Location = new System.Drawing.Point(57, 748);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(128, 28);
            this.modeLabel.TabIndex = 3;
            this.modeLabel.Text = "编辑模式";
            this.modeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "删除";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 87;
            // 
            // delete
            // 
            this.delete.Frozen = true;
            this.delete.HeaderText = "删除";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.Width = 87;
            // 
            // mainGrid_extraAddBtn
            // 
            this.mainGrid_extraAddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainGrid_extraAddBtn.BackgroundImage")));
            this.mainGrid_extraAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainGrid_extraAddBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainGrid_extraAddBtn.FlatAppearance.BorderSize = 0;
            this.mainGrid_extraAddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mainGrid_extraAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mainGrid_extraAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainGrid_extraAddBtn.Location = new System.Drawing.Point(1164, 208);
            this.mainGrid_extraAddBtn.Name = "mainGrid_extraAddBtn";
            this.mainGrid_extraAddBtn.Size = new System.Drawing.Size(50, 50);
            this.mainGrid_extraAddBtn.TabIndex = 6;
            this.mainGrid_extraAddBtn.UseVisualStyleBackColor = true;
            this.mainGrid_extraAddBtn.Click += new System.EventHandler(this.mainGrid_extraAddBtn_Click);
            // 
            // tabs_addBtn
            // 
            this.tabs_addBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabs_addBtn.BackgroundImage")));
            this.tabs_addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabs_addBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabs_addBtn.FlatAppearance.BorderSize = 0;
            this.tabs_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tabs_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tabs_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabs_addBtn.Location = new System.Drawing.Point(364, 99);
            this.tabs_addBtn.Name = "tabs_addBtn";
            this.tabs_addBtn.Size = new System.Drawing.Size(50, 50);
            this.tabs_addBtn.TabIndex = 4;
            this.tabs_addBtn.UseVisualStyleBackColor = true;
            this.tabs_addBtn.Click += new System.EventHandler(this.tabs_addBtn_Click);
            // 
            // mainGrid_addRowBtn
            // 
            this.mainGrid_addRowBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainGrid_addRowBtn.BackgroundImage")));
            this.mainGrid_addRowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainGrid_addRowBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainGrid_addRowBtn.FlatAppearance.BorderSize = 0;
            this.mainGrid_addRowBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mainGrid_addRowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mainGrid_addRowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainGrid_addRowBtn.Location = new System.Drawing.Point(217, 337);
            this.mainGrid_addRowBtn.Name = "mainGrid_addRowBtn";
            this.mainGrid_addRowBtn.Size = new System.Drawing.Size(50, 50);
            this.mainGrid_addRowBtn.TabIndex = 5;
            this.mainGrid_addRowBtn.UseVisualStyleBackColor = true;
            this.mainGrid_addRowBtn.Click += new System.EventHandler(this.mainGrid_addRowBtn_Click);
            // 
            // bar_backBtn
            // 
            this.bar_backBtn.BackColor = System.Drawing.Color.Transparent;
            this.bar_backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bar_backBtn.BackgroundImage")));
            this.bar_backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bar_backBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.bar_backBtn.FlatAppearance.BorderSize = 0;
            this.bar_backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bar_backBtn.Location = new System.Drawing.Point(1216, 0);
            this.bar_backBtn.Name = "bar_backBtn";
            this.bar_backBtn.Size = new System.Drawing.Size(130, 100);
            this.bar_backBtn.TabIndex = 3;
            this.bar_backBtn.UseVisualStyleBackColor = false;
            this.bar_backBtn.Click += new System.EventHandler(this.bar_backBtn_Click);
            // 
            // bar_modeBtn
            // 
            this.bar_modeBtn.BackColor = System.Drawing.Color.Transparent;
            this.bar_modeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bar_modeBtn.BackgroundImage")));
            this.bar_modeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bar_modeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.bar_modeBtn.FlatAppearance.BorderSize = 0;
            this.bar_modeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bar_modeBtn.Location = new System.Drawing.Point(1346, 0);
            this.bar_modeBtn.Name = "bar_modeBtn";
            this.bar_modeBtn.Size = new System.Drawing.Size(130, 100);
            this.bar_modeBtn.TabIndex = 2;
            this.bar_modeBtn.UseVisualStyleBackColor = false;
            this.bar_modeBtn.Click += new System.EventHandler(this.bar_modeBtn_Click);
            // 
            // bar_settingBtn
            // 
            this.bar_settingBtn.BackColor = System.Drawing.Color.Transparent;
            this.bar_settingBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bar_settingBtn.BackgroundImage")));
            this.bar_settingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bar_settingBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.bar_settingBtn.FlatAppearance.BorderSize = 0;
            this.bar_settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bar_settingBtn.Location = new System.Drawing.Point(1476, 0);
            this.bar_settingBtn.Name = "bar_settingBtn";
            this.bar_settingBtn.Size = new System.Drawing.Size(130, 100);
            this.bar_settingBtn.TabIndex = 1;
            this.bar_settingBtn.UseVisualStyleBackColor = false;
            this.bar_settingBtn.Click += new System.EventHandler(this.bar_settingBtn_Click);
            // 
            // bar_deleteBtn
            // 
            this.bar_deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.bar_deleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bar_deleteBtn.BackgroundImage")));
            this.bar_deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bar_deleteBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.bar_deleteBtn.FlatAppearance.BorderSize = 0;
            this.bar_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bar_deleteBtn.Location = new System.Drawing.Point(1606, 0);
            this.bar_deleteBtn.Name = "bar_deleteBtn";
            this.bar_deleteBtn.Size = new System.Drawing.Size(130, 100);
            this.bar_deleteBtn.TabIndex = 0;
            this.bar_deleteBtn.UseVisualStyleBackColor = false;
            this.bar_deleteBtn.Click += new System.EventHandler(this.bar_deleteBtn_Click);
            // 
            // tabs
            // 
            this.tabs.BackColor = System.Drawing.Color.Maroon;
            this.tabs.borderColor = System.Drawing.Color.Maroon;
            this.tabs.borderWidth = 2;
            this.tabs.btnMouseOverColor = System.Drawing.Color.LightSalmon;
            this.tabs.containerBackColor = System.Drawing.Color.Gray;
            this.tabs.Location = new System.Drawing.Point(453, 89);
            this.tabs.Name = "tabs";
            this.tabs.Size = new System.Drawing.Size(634, 40);
            this.tabs.TabIndex = 2;
            this.tabs.textColor = System.Drawing.Color.SeaShell;
            this.tabs.textFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // courseTitle
            // 
            this.courseTitle.BackColor = System.Drawing.Color.Transparent;
            this.courseTitle.contentFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.courseTitle.contentText = "计算机网络1234567890";
            this.courseTitle.ForeColor = System.Drawing.Color.Transparent;
            this.courseTitle.Location = new System.Drawing.Point(62, 23);
            this.courseTitle.Name = "courseTitle";
            this.courseTitle.Size = new System.Drawing.Size(301, 52);
            this.courseTitle.TabIndex = 4;
            // 
            // CourseHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.bar);
            this.Name = "CourseHall";
            this.Size = new System.Drawing.Size(1736, 935);
            this.bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.mainGridBorderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.Button bar_deleteBtn;
        private System.Windows.Forms.Button bar_settingBtn;
        private System.Windows.Forms.Button bar_modeBtn;
        private System.Windows.Forms.Button bar_backBtn;
        public System.Windows.Forms.DataGridView mainGrid;
        private System.Windows.Forms.Panel mainPanel;
        public HKTab tabs;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.Button tabs_addBtn;
        private System.Windows.Forms.Button mainGrid_addRowBtn;
        private System.Windows.Forms.Button mainGrid_extraAddBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button scoreCalBtn;
        private System.Windows.Forms.Button excelExport;
        private Model.HorizontalScrollLabel courseTitle;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button excelImport;
        private System.Windows.Forms.Panel mainGridBorderPanel;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewComboBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn major;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn _class;
        private System.Windows.Forms.DataGridViewComboBoxColumn CourseAttribute;
        private System.Windows.Forms.DataGridViewComboBoxColumn examMethod;
        private System.Windows.Forms.DataGridViewComboBoxColumn examAttribute;
        private System.Windows.Forms.DataGridViewComboBoxColumn isExamDelay;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
    }
}
