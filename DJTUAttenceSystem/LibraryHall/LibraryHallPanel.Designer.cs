namespace DJTUAttenceSystem.LibraryHall {
    partial class LibraryHallPanel {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryHallPanel));
            this.BGPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.hkTableView1 = new DJTUAttenceSystem.Model.HKTableView();
            this.remarkPanel = new System.Windows.Forms.Panel();
            this.remarkLabel = new DJTUAttenceSystem.Model.HKTextBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.titlePicture = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.title = new DJTUAttenceSystem.Model.HorizontalScrollLabel();
            this.addButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.BGPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.remarkPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BGPanel
            // 
            this.BGPanel.BackColor = System.Drawing.Color.Transparent;
            this.BGPanel.Controls.Add(this.bottomPanel);
            this.BGPanel.Controls.Add(this.topPanel);
            this.BGPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BGPanel.Location = new System.Drawing.Point(0, 0);
            this.BGPanel.Name = "BGPanel";
            this.BGPanel.Size = new System.Drawing.Size(1160, 660);
            this.BGPanel.TabIndex = 0;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.bottomPanel.Controls.Add(this.hkTableView1);
            this.bottomPanel.Controls.Add(this.remarkPanel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(0, 130);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1160, 530);
            this.bottomPanel.TabIndex = 1;
            // 
            // hkTableView1
            // 
            this.hkTableView1.AutoScroll = true;
            this.hkTableView1.BackColor = System.Drawing.Color.Transparent;
            this.hkTableView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hkTableView1.Location = new System.Drawing.Point(0, 215);
            this.hkTableView1.Name = "hkTableView1";
            this.hkTableView1.Size = new System.Drawing.Size(1160, 315);
            this.hkTableView1.TabIndex = 2;
            // 
            // remarkPanel
            // 
            this.remarkPanel.Controls.Add(this.remarkLabel);
            this.remarkPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.remarkPanel.Location = new System.Drawing.Point(0, 0);
            this.remarkPanel.Name = "remarkPanel";
            this.remarkPanel.Size = new System.Drawing.Size(1160, 215);
            this.remarkPanel.TabIndex = 1;
            // 
            // remarkLabel
            // 
            this.remarkLabel.BackColor = System.Drawing.Color.DimGray;
            this.remarkLabel.bar = System.Windows.Forms.ScrollBars.Vertical;
            this.remarkLabel.BGColor = System.Drawing.SystemColors.InactiveCaption;
            this.remarkLabel.borderColor = System.Drawing.Color.DimGray;
            this.remarkLabel.borderWidth = 0;
            this.remarkLabel.foreColor = System.Drawing.Color.AntiqueWhite;
            this.remarkLabel.Location = new System.Drawing.Point(132, 40);
            this.remarkLabel.Name = "remarkLabel";
            this.remarkLabel.Size = new System.Drawing.Size(768, 133);
            this.remarkLabel.TabIndex = 0;
            this.remarkLabel.text = resources.GetString("remarkLabel.text");
            this.remarkLabel.textFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.remarkLabel.widthOffset = 17;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.Controls.Add(this.titlePicture);
            this.topPanel.Controls.Add(this.backButton);
            this.topPanel.Controls.Add(this.title);
            this.topPanel.Controls.Add(this.addButton);
            this.topPanel.Controls.Add(this.exportButton);
            this.topPanel.Controls.Add(this.editButton);
            this.topPanel.Controls.Add(this.deleteButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1160, 130);
            this.topPanel.TabIndex = 0;
            // 
            // titlePicture
            // 
            this.titlePicture.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.teacher2_48m;
            this.titlePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.titlePicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.titlePicture.Location = new System.Drawing.Point(0, 0);
            this.titlePicture.Name = "titlePicture";
            this.titlePicture.Size = new System.Drawing.Size(130, 130);
            this.titlePicture.TabIndex = 6;
            this.titlePicture.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.back3_48m;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(510, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(130, 130);
            this.backButton.TabIndex = 5;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.contentFont = new System.Drawing.Font("幼圆", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.contentText = "佟宁12345678901234567890";
            this.title.Location = new System.Drawing.Point(152, 45);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(237, 59);
            this.title.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.add48m;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(640, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(130, 130);
            this.addButton.TabIndex = 1;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.out2_48m;
            this.exportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exportButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exportButton.FlatAppearance.BorderSize = 0;
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Location = new System.Drawing.Point(770, 0);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(130, 130);
            this.exportButton.TabIndex = 2;
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.edit1_48m;
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.editButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Location = new System.Drawing.Point(900, 0);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(130, 130);
            this.editButton.TabIndex = 7;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.delete1_48m;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(1030, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(130, 130);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // LibraryHallPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.BGPanel);
            this.Name = "LibraryHallPanel";
            this.Size = new System.Drawing.Size(1160, 660);
            this.BGPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.remarkPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BGPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button deleteButton;
        private Model.HorizontalScrollLabel title;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel remarkPanel;
        private Model.HKTextBox remarkLabel;
        private System.Windows.Forms.PictureBox titlePicture;
        private System.Windows.Forms.Button editButton;
        private Model.HKTableView hkTableView1;
    }
}
