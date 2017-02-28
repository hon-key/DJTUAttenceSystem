namespace DJTUAttenceSystem.Course {
    partial class CourseEdit {
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.topPanel_bottom = new System.Windows.Forms.Panel();
            this.remarkLabel = new System.Windows.Forms.Label();
            this.topPanel_top = new System.Windows.Forms.Panel();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.weightLabel = new System.Windows.Forms.Label();
            this.bar = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.busWeight = new DJTUAttenceSystem.Model.HKComboBox();
            this.sickWeight = new DJTUAttenceSystem.Model.HKComboBox();
            this.absWeight = new DJTUAttenceSystem.Model.HKComboBox();
            this.lateWeight = new DJTUAttenceSystem.Model.HKComboBox();
            this.attWeight = new DJTUAttenceSystem.Model.HKComboBox();
            this.remarkBox = new DJTUAttenceSystem.Model.HKTextBox();
            this.idBox = new DJTUAttenceSystem.Model.HKTextBox2();
            this.nameBox = new DJTUAttenceSystem.Model.HKTextBox2();
            this.topPanel.SuspendLayout();
            this.topPanel_bottom.SuspendLayout();
            this.topPanel_top.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.Controls.Add(this.topPanel_bottom);
            this.topPanel.Controls.Add(this.topPanel_top);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 100);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1312, 410);
            this.topPanel.TabIndex = 0;
            // 
            // topPanel_bottom
            // 
            this.topPanel_bottom.BackColor = System.Drawing.Color.Transparent;
            this.topPanel_bottom.Controls.Add(this.remarkBox);
            this.topPanel_bottom.Controls.Add(this.remarkLabel);
            this.topPanel_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel_bottom.Location = new System.Drawing.Point(0, 110);
            this.topPanel_bottom.Name = "topPanel_bottom";
            this.topPanel_bottom.Size = new System.Drawing.Size(1312, 300);
            this.topPanel_bottom.TabIndex = 1;
            // 
            // remarkLabel
            // 
            this.remarkLabel.BackColor = System.Drawing.Color.Transparent;
            this.remarkLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.remarkLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remarkLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.remarkLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.remarkLabel.Location = new System.Drawing.Point(0, 0);
            this.remarkLabel.Name = "remarkLabel";
            this.remarkLabel.Size = new System.Drawing.Size(138, 300);
            this.remarkLabel.TabIndex = 0;
            this.remarkLabel.Text = "备注";
            this.remarkLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // topPanel_top
            // 
            this.topPanel_top.BackColor = System.Drawing.Color.Transparent;
            this.topPanel_top.Controls.Add(this.idBox);
            this.topPanel_top.Controls.Add(this.idLabel);
            this.topPanel_top.Controls.Add(this.nameBox);
            this.topPanel_top.Controls.Add(this.nameLabel);
            this.topPanel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel_top.Location = new System.Drawing.Point(0, 0);
            this.topPanel_top.Name = "topPanel_top";
            this.topPanel_top.Size = new System.Drawing.Size(1312, 110);
            this.topPanel_top.TabIndex = 0;
            // 
            // idLabel
            // 
            this.idLabel.BackColor = System.Drawing.Color.Transparent;
            this.idLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.idLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.idLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.idLabel.Location = new System.Drawing.Point(321, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(140, 110);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "课程号";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(140, 110);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "课程名";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.bottomPanel.Controls.Add(this.busWeight);
            this.bottomPanel.Controls.Add(this.sickWeight);
            this.bottomPanel.Controls.Add(this.absWeight);
            this.bottomPanel.Controls.Add(this.lateWeight);
            this.bottomPanel.Controls.Add(this.attWeight);
            this.bottomPanel.Controls.Add(this.weightLabel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(0, 510);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1312, 374);
            this.bottomPanel.TabIndex = 1;
            // 
            // weightLabel
            // 
            this.weightLabel.BackColor = System.Drawing.Color.Transparent;
            this.weightLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.weightLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weightLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.weightLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.weightLabel.Location = new System.Drawing.Point(0, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(138, 374);
            this.weightLabel.TabIndex = 0;
            this.weightLabel.Text = "加权";
            this.weightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.Transparent;
            this.bar.Controls.Add(this.title);
            this.bar.Controls.Add(this.closeButton);
            this.bar.Controls.Add(this.yesButton);
            this.bar.Controls.Add(this.pictureBox1);
            this.bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar.Location = new System.Drawing.Point(0, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(1312, 100);
            this.bar.TabIndex = 2;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Dock = System.Windows.Forms.DockStyle.Left;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.Color.SeaShell;
            this.title.Location = new System.Drawing.Point(133, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(273, 100);
            this.title.TabIndex = 2;
            this.title.Text = "创建新课程";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.close1_48m;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(1112, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 100);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.Color.Transparent;
            this.yesButton.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.yes3_48m;
            this.yesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.yesButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.yesButton.FlatAppearance.BorderSize = 0;
            this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yesButton.Location = new System.Drawing.Point(1212, 0);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(100, 100);
            this.yesButton.TabIndex = 0;
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.teacher1_48m;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 100);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // busWeight
            // 
            this.busWeight.BackColor = System.Drawing.Color.Transparent;
            this.busWeight.comboBGColor = System.Drawing.SystemColors.Window;
            this.busWeight.comboForeColor = System.Drawing.SystemColors.WindowText;
            this.busWeight.comboWidth = 35;
            this.busWeight.dropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.busWeight.flatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.busWeight.Location = new System.Drawing.Point(897, 18);
            this.busWeight.Name = "busWeight";
            this.busWeight.Size = new System.Drawing.Size(123, 76);
            this.busWeight.TabIndex = 5;
            this.busWeight.titleColor = System.Drawing.Color.SeaShell;
            this.busWeight.titleFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.busWeight.titleText = "事假";
            // 
            // sickWeight
            // 
            this.sickWeight.BackColor = System.Drawing.Color.Transparent;
            this.sickWeight.comboBGColor = System.Drawing.SystemColors.Window;
            this.sickWeight.comboForeColor = System.Drawing.SystemColors.WindowText;
            this.sickWeight.comboWidth = 35;
            this.sickWeight.dropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sickWeight.flatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.sickWeight.Location = new System.Drawing.Point(718, 18);
            this.sickWeight.Name = "sickWeight";
            this.sickWeight.Size = new System.Drawing.Size(123, 76);
            this.sickWeight.TabIndex = 4;
            this.sickWeight.titleColor = System.Drawing.Color.SeaShell;
            this.sickWeight.titleFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sickWeight.titleText = "病假";
            // 
            // absWeight
            // 
            this.absWeight.BackColor = System.Drawing.Color.Transparent;
            this.absWeight.comboBGColor = System.Drawing.SystemColors.Window;
            this.absWeight.comboForeColor = System.Drawing.SystemColors.WindowText;
            this.absWeight.comboWidth = 35;
            this.absWeight.dropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.absWeight.flatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.absWeight.Location = new System.Drawing.Point(561, 18);
            this.absWeight.Name = "absWeight";
            this.absWeight.Size = new System.Drawing.Size(123, 76);
            this.absWeight.TabIndex = 3;
            this.absWeight.titleColor = System.Drawing.Color.SeaShell;
            this.absWeight.titleFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.absWeight.titleText = "旷课";
            // 
            // lateWeight
            // 
            this.lateWeight.BackColor = System.Drawing.Color.Transparent;
            this.lateWeight.comboBGColor = System.Drawing.SystemColors.Window;
            this.lateWeight.comboForeColor = System.Drawing.SystemColors.WindowText;
            this.lateWeight.comboWidth = 35;
            this.lateWeight.dropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lateWeight.flatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.lateWeight.Location = new System.Drawing.Point(367, 18);
            this.lateWeight.Name = "lateWeight";
            this.lateWeight.Size = new System.Drawing.Size(123, 76);
            this.lateWeight.TabIndex = 2;
            this.lateWeight.titleColor = System.Drawing.Color.SeaShell;
            this.lateWeight.titleFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lateWeight.titleText = "迟到";
            // 
            // attWeight
            // 
            this.attWeight.BackColor = System.Drawing.Color.Transparent;
            this.attWeight.comboBGColor = System.Drawing.SystemColors.Window;
            this.attWeight.comboForeColor = System.Drawing.SystemColors.WindowText;
            this.attWeight.comboWidth = 35;
            this.attWeight.dropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.attWeight.flatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.attWeight.Location = new System.Drawing.Point(194, 18);
            this.attWeight.Name = "attWeight";
            this.attWeight.Size = new System.Drawing.Size(123, 76);
            this.attWeight.TabIndex = 1;
            this.attWeight.titleColor = System.Drawing.Color.SeaShell;
            this.attWeight.titleFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.attWeight.titleText = "出勤";
            // 
            // remarkBox
            // 
            this.remarkBox.BackColor = System.Drawing.Color.DarkRed;
            this.remarkBox.bar = System.Windows.Forms.ScrollBars.Vertical;
            this.remarkBox.BGColor = System.Drawing.SystemColors.Window;
            this.remarkBox.borderColor = System.Drawing.Color.DarkRed;
            this.remarkBox.borderWidth = 2;
            this.remarkBox.foreColor = System.Drawing.Color.SeaShell;
            this.remarkBox.Location = new System.Drawing.Point(316, 54);
            this.remarkBox.Name = "remarkBox";
            this.remarkBox.Size = new System.Drawing.Size(389, 147);
            this.remarkBox.TabIndex = 1;
            this.remarkBox.text = "";
            this.remarkBox.textFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.remarkBox.widthOffset = 17;
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.Color.Transparent;
            this.idBox.borderColor = System.Drawing.Color.Silver;
            this.idBox.borderWidth = 2;
            this.idBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.idBox.font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.idBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.idBox.Location = new System.Drawing.Point(461, 0);
            this.idBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(189, 110);
            this.idBox.TabIndex = 3;
            this.idBox.text = "";
            this.idBox.textColor = System.Drawing.SystemColors.InactiveCaption;
            this.idBox.textForeColor = System.Drawing.Color.SeaShell;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.Transparent;
            this.nameBox.borderColor = System.Drawing.Color.Maroon;
            this.nameBox.borderWidth = 2;
            this.nameBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameBox.font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameBox.Location = new System.Drawing.Point(140, 0);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(181, 110);
            this.nameBox.TabIndex = 1;
            this.nameBox.text = "";
            this.nameBox.textColor = System.Drawing.Color.LightGray;
            this.nameBox.textForeColor = System.Drawing.Color.SeaShell;
            // 
            // CourseEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bar);
            this.Name = "CourseEdit";
            this.Size = new System.Drawing.Size(1312, 884);
            this.topPanel.ResumeLayout(false);
            this.topPanel_bottom.ResumeLayout(false);
            this.topPanel_top.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel topPanel_bottom;
        private System.Windows.Forms.Panel topPanel_top;
        private System.Windows.Forms.Panel bottomPanel;
        public Model.HKTextBox2 idBox;
        private System.Windows.Forms.Label idLabel;
        public Model.HKTextBox2 nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.Label remarkLabel;
        public Model.HKTextBox remarkBox;
        private System.Windows.Forms.Label weightLabel;
        public Model.HKComboBox attWeight;
        public Model.HKComboBox busWeight;
        public Model.HKComboBox sickWeight;
        public Model.HKComboBox absWeight;
        public Model.HKComboBox lateWeight;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
