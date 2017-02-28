namespace DJTUAttenceSystem.Course {
    partial class CheckTypeInputPanel {
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.nameBox = new DJTUAttenceSystem.Model.HKTextBox2();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(144, 116);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "名称";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weightLabel
            // 
            this.weightLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.weightLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weightLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.weightLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.weightLabel.Location = new System.Drawing.Point(462, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(114, 116);
            this.weightLabel.TabIndex = 2;
            this.weightLabel.Text = "加权";
            this.weightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weightBox
            // 
            this.weightBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weightBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weightBox.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.weightBox.FormattingEnabled = true;
            this.weightBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.weightBox.Location = new System.Drawing.Point(602, 44);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(103, 35);
            this.weightBox.TabIndex = 3;
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.delete3_16m;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(841, 41);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(50, 50);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.Transparent;
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorPanel.Location = new System.Drawing.Point(754, 44);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(50, 50);
            this.colorPanel.TabIndex = 5;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.Transparent;
            this.nameBox.borderColor = System.Drawing.Color.Silver;
            this.nameBox.borderWidth = 3;
            this.nameBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameBox.font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameBox.Location = new System.Drawing.Point(144, 0);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(318, 116);
            this.nameBox.TabIndex = 1;
            this.nameBox.text = "";
            this.nameBox.textColor = System.Drawing.SystemColors.Highlight;
            this.nameBox.textForeColor = System.Drawing.Color.SeaShell;
            // 
            // CheckTypeInputPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "CheckTypeInputPanel";
            this.Size = new System.Drawing.Size(986, 116);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        public Model.HKTextBox2 nameBox;
        private System.Windows.Forms.Label weightLabel;
        public System.Windows.Forms.ComboBox weightBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel colorPanel;
    }
}
