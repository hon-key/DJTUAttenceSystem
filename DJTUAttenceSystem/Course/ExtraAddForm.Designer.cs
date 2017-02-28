namespace DJTUAttenceSystem.Course {
    partial class ExtraAddForm {
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameInputBox = new DJTUAttenceSystem.Model.HKTextBox2();
            this.nameLabel = new System.Windows.Forms.Label();
            this.checkTypeAddPanel = new System.Windows.Forms.Panel();
            this.checkTypeAddButton = new System.Windows.Forms.Button();
            this.checkTypeAddLabel = new System.Windows.Forms.Label();
            this.checkPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.namePanel.SuspendLayout();
            this.checkTypeAddPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.checkPanel);
            this.topPanel.Controls.Add(this.checkTypeAddPanel);
            this.topPanel.Controls.Add(this.namePanel);
            this.topPanel.Size = new System.Drawing.Size(1215, 628);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Location = new System.Drawing.Point(0, 628);
            this.bottomPanel.Size = new System.Drawing.Size(1215, 127);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.closeButton.Size = new System.Drawing.Size(583, 127);
            this.closeButton.UseVisualStyleBackColor = false;
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.Color.Transparent;
            this.yesButton.FlatAppearance.BorderSize = 0;
            this.yesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.yesButton.Location = new System.Drawing.Point(583, 0);
            this.yesButton.Size = new System.Drawing.Size(632, 127);
            this.yesButton.UseVisualStyleBackColor = false;
            // 
            // namePanel
            // 
            this.namePanel.BackColor = System.Drawing.Color.Transparent;
            this.namePanel.Controls.Add(this.nameInputBox);
            this.namePanel.Controls.Add(this.nameLabel);
            this.namePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.namePanel.Location = new System.Drawing.Point(0, 0);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(1215, 158);
            this.namePanel.TabIndex = 0;
            // 
            // nameInputBox
            // 
            this.nameInputBox.BackColor = System.Drawing.Color.Transparent;
            this.nameInputBox.borderColor = System.Drawing.Color.Silver;
            this.nameInputBox.borderWidth = 3;
            this.nameInputBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameInputBox.font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameInputBox.Location = new System.Drawing.Point(250, 0);
            this.nameInputBox.Name = "nameInputBox";
            this.nameInputBox.Size = new System.Drawing.Size(516, 158);
            this.nameInputBox.TabIndex = 1;
            this.nameInputBox.textColor = System.Drawing.SystemColors.HotTrack;
            this.nameInputBox.textForeColor = System.Drawing.Color.SeaShell;
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(250, 158);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "名称";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkTypeAddPanel
            // 
            this.checkTypeAddPanel.BackColor = System.Drawing.Color.Transparent;
            this.checkTypeAddPanel.Controls.Add(this.checkTypeAddButton);
            this.checkTypeAddPanel.Controls.Add(this.checkTypeAddLabel);
            this.checkTypeAddPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkTypeAddPanel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkTypeAddPanel.ForeColor = System.Drawing.Color.SeaShell;
            this.checkTypeAddPanel.Location = new System.Drawing.Point(0, 158);
            this.checkTypeAddPanel.Name = "checkTypeAddPanel";
            this.checkTypeAddPanel.Size = new System.Drawing.Size(1215, 100);
            this.checkTypeAddPanel.TabIndex = 1;
            // 
            // checkTypeAddButton
            // 
            this.checkTypeAddButton.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.add1_5m;
            this.checkTypeAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkTypeAddButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkTypeAddButton.FlatAppearance.BorderSize = 0;
            this.checkTypeAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.checkTypeAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkTypeAddButton.Location = new System.Drawing.Point(250, 0);
            this.checkTypeAddButton.Name = "checkTypeAddButton";
            this.checkTypeAddButton.Size = new System.Drawing.Size(100, 100);
            this.checkTypeAddButton.TabIndex = 1;
            this.checkTypeAddButton.UseVisualStyleBackColor = true;
            this.checkTypeAddButton.Click += new System.EventHandler(this.checkTypeAddButton_Click);
            // 
            // checkTypeAddLabel
            // 
            this.checkTypeAddLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkTypeAddLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkTypeAddLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkTypeAddLabel.Location = new System.Drawing.Point(0, 0);
            this.checkTypeAddLabel.Name = "checkTypeAddLabel";
            this.checkTypeAddLabel.Size = new System.Drawing.Size(250, 100);
            this.checkTypeAddLabel.TabIndex = 0;
            this.checkTypeAddLabel.Text = "评定";
            this.checkTypeAddLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkPanel
            // 
            this.checkPanel.AutoScroll = true;
            this.checkPanel.BackColor = System.Drawing.Color.Transparent;
            this.checkPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkPanel.Location = new System.Drawing.Point(0, 258);
            this.checkPanel.Name = "checkPanel";
            this.checkPanel.Size = new System.Drawing.Size(1215, 370);
            this.checkPanel.TabIndex = 2;
            // 
            // ExtraAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.ClientSize = new System.Drawing.Size(1215, 755);
            this.Name = "ExtraAddForm";
            this.topPanelHeight = 622;
            this.topPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.namePanel.ResumeLayout(false);
            this.checkTypeAddPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel namePanel;
        private Model.HKTextBox2 nameInputBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel checkTypeAddPanel;
        private System.Windows.Forms.Label checkTypeAddLabel;
        private System.Windows.Forms.Button checkTypeAddButton;
        private System.Windows.Forms.Panel checkPanel;
    }
}
