namespace DJTUAttenceSystem {
    partial class LoginCell {
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
            this.BGPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.remarkPanel = new System.Windows.Forms.Panel();
            this.introlLabel = new System.Windows.Forms.Label();
            this.bar = new System.Windows.Forms.Panel();
            this.nameLabel = new DJTUAttenceSystem.Model.HorizontalScrollLabel();
            this.exportButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.BGPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.remarkPanel.SuspendLayout();
            this.bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // BGPanel
            // 
            this.BGPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.BGPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BGPanel.Controls.Add(this.bottomPanel);
            this.BGPanel.Controls.Add(this.remarkPanel);
            this.BGPanel.Controls.Add(this.bar);
            this.BGPanel.Location = new System.Drawing.Point(22, 91);
            this.BGPanel.Name = "BGPanel";
            this.BGPanel.Size = new System.Drawing.Size(1207, 349);
            this.BGPanel.TabIndex = 0;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.bottomPanel.Controls.Add(this.timeLabel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(0, 294);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1207, 55);
            this.bottomPanel.TabIndex = 7;
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.timeLabel.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.timeLabel.Location = new System.Drawing.Point(865, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(342, 55);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Last modify: 2016.8.5";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remarkPanel
            // 
            this.remarkPanel.BackColor = System.Drawing.Color.Transparent;
            this.remarkPanel.Controls.Add(this.introlLabel);
            this.remarkPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.remarkPanel.Location = new System.Drawing.Point(0, 90);
            this.remarkPanel.Name = "remarkPanel";
            this.remarkPanel.Size = new System.Drawing.Size(1207, 204);
            this.remarkPanel.TabIndex = 6;
            // 
            // introlLabel
            // 
            this.introlLabel.BackColor = System.Drawing.Color.Transparent;
            this.introlLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.introlLabel.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.introlLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.introlLabel.Location = new System.Drawing.Point(134, 52);
            this.introlLabel.Name = "introlLabel";
            this.introlLabel.Size = new System.Drawing.Size(932, 107);
            this.introlLabel.TabIndex = 1;
            this.introlLabel.Text = "这是一个测试的介绍性文字这是一个测试的介绍性文字这是一个测试的介绍性文字这是一个测试的介绍性文字\r\n";
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.Transparent;
            this.bar.Controls.Add(this.nameLabel);
            this.bar.Controls.Add(this.exportButton);
            this.bar.Controls.Add(this.deleteButton);
            this.bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar.Location = new System.Drawing.Point(0, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(1207, 90);
            this.bar.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.contentFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.contentText = "label1";
            this.nameLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.Location = new System.Drawing.Point(42, 18);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(388, 52);
            this.nameLabel.TabIndex = 5;
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.Transparent;
            this.exportButton.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources._2;
            this.exportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exportButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exportButton.FlatAppearance.BorderSize = 0;
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Location = new System.Drawing.Point(1027, 0);
            this.exportButton.Margin = new System.Windows.Forms.Padding(10);
            this.exportButton.Name = "exportButton";
            this.exportButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exportButton.Size = new System.Drawing.Size(90, 90);
            this.exportButton.TabIndex = 4;
            this.exportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deleteButton.ForeColor = System.Drawing.Color.MintCream;
            this.deleteButton.Location = new System.Drawing.Point(1117, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(90, 90);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "—";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // LoginCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.BGPanel);
            this.Name = "LoginCell";
            this.Size = new System.Drawing.Size(1262, 478);
            this.BGPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.remarkPanel.ResumeLayout(false);
            this.bar.ResumeLayout(false);
            this.bar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BGPanel;
        private System.Windows.Forms.Label introlLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel remarkPanel;
        private System.Windows.Forms.Panel bar;
        private Model.HorizontalScrollLabel nameLabel;
    }
}
