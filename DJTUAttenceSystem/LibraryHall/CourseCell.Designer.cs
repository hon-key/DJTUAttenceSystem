namespace DJTUAttenceSystem.LibraryHall {
    partial class CourseCell {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseCell));
            this.topPanel = new System.Windows.Forms.Panel();
            this.exportButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.remarkPanel = new System.Windows.Forms.Panel();
            this.remarkBox = new System.Windows.Forms.Label();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.BGPanel = new System.Windows.Forms.Panel();
            this.title = new DJTUAttenceSystem.Model.HorizontalScrollLabel();
            this.topPanel.SuspendLayout();
            this.remarkPanel.SuspendLayout();
            this.BGPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.Controls.Add(this.title);
            this.topPanel.Controls.Add(this.exportButton);
            this.topPanel.Controls.Add(this.deleteButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(410, 71);
            this.topPanel.TabIndex = 0;
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.Transparent;
            this.exportButton.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.expert1_32m;
            this.exportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exportButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exportButton.FlatAppearance.BorderSize = 0;
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Location = new System.Drawing.Point(260, 0);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 71);
            this.exportButton.TabIndex = 1;
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.delete1_24m;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(335, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 71);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // remarkPanel
            // 
            this.remarkPanel.BackColor = System.Drawing.Color.Transparent;
            this.remarkPanel.Controls.Add(this.remarkBox);
            this.remarkPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remarkPanel.Location = new System.Drawing.Point(0, 71);
            this.remarkPanel.Name = "remarkPanel";
            this.remarkPanel.Size = new System.Drawing.Size(410, 129);
            this.remarkPanel.TabIndex = 1;
            // 
            // remarkBox
            // 
            this.remarkBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.remarkBox.ForeColor = System.Drawing.Color.SeaShell;
            this.remarkBox.Location = new System.Drawing.Point(23, 3);
            this.remarkBox.Name = "remarkBox";
            this.remarkBox.Size = new System.Drawing.Size(116, 51);
            this.remarkBox.TabIndex = 0;
            this.remarkBox.Text = resources.GetString("remarkBox.Text");
            // 
            // BGPanel
            // 
            this.BGPanel.BackColor = System.Drawing.Color.DimGray;
            this.BGPanel.Controls.Add(this.remarkPanel);
            this.BGPanel.Controls.Add(this.topPanel);
            this.BGPanel.Location = new System.Drawing.Point(56, 23);
            this.BGPanel.Name = "BGPanel";
            this.BGPanel.Size = new System.Drawing.Size(410, 200);
            this.BGPanel.TabIndex = 2;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.contentFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.contentText = "label1";
            this.title.Location = new System.Drawing.Point(30, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(241, 42);
            this.title.TabIndex = 2;
            // 
            // CourseCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.Controls.Add(this.BGPanel);
            this.Name = "CourseCell";
            this.Size = new System.Drawing.Size(572, 288);
            this.topPanel.ResumeLayout(false);
            this.remarkPanel.ResumeLayout(false);
            this.BGPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button exportButton;
        private Model.HorizontalScrollLabel title;
        private System.Windows.Forms.Panel remarkPanel;
        private System.Windows.Forms.Label remarkBox;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.Panel BGPanel;
    }
}
