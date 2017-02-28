namespace DJTUAttenceSystem.LibraryHall {
    partial class LibraryAddPanel {
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
            this.nameField = new System.Windows.Forms.TextBox();
            this.PswLabel = new System.Windows.Forms.Label();
            this.remarkLabel = new System.Windows.Forms.Label();
            this.remarkField = new System.Windows.Forms.TextBox();
            this.pswField = new System.Windows.Forms.TextBox();
            this.fieldPanel = new System.Windows.Forms.Panel();
            this.pswCheckBox = new System.Windows.Forms.CheckBox();
            this.BGPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.titleImageBox = new System.Windows.Forms.PictureBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.fieldPanel.SuspendLayout();
            this.BGPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameLabel.Font = new System.Drawing.Font("微软雅黑", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.ForeColor = System.Drawing.Color.Snow;
            this.nameLabel.Location = new System.Drawing.Point(3, 5);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(151, 78);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "名称";
            // 
            // nameField
            // 
            this.nameField.BackColor = System.Drawing.SystemColors.Menu;
            this.nameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameField.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameField.Font = new System.Drawing.Font("微软雅黑", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameField.ForeColor = System.Drawing.Color.Snow;
            this.nameField.Location = new System.Drawing.Point(145, 5);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(231, 57);
            this.nameField.TabIndex = 1;
            // 
            // PswLabel
            // 
            this.PswLabel.AutoSize = true;
            this.PswLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PswLabel.Font = new System.Drawing.Font("微软雅黑", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PswLabel.ForeColor = System.Drawing.Color.Snow;
            this.PswLabel.Location = new System.Drawing.Point(382, 5);
            this.PswLabel.Name = "PswLabel";
            this.PswLabel.Size = new System.Drawing.Size(151, 78);
            this.PswLabel.TabIndex = 2;
            this.PswLabel.Text = "密码";
            // 
            // remarkLabel
            // 
            this.remarkLabel.AutoSize = true;
            this.remarkLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remarkLabel.Font = new System.Drawing.Font("微软雅黑", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.remarkLabel.ForeColor = System.Drawing.Color.Snow;
            this.remarkLabel.Location = new System.Drawing.Point(3, 427);
            this.remarkLabel.Name = "remarkLabel";
            this.remarkLabel.Size = new System.Drawing.Size(151, 78);
            this.remarkLabel.TabIndex = 4;
            this.remarkLabel.Text = "备注";
            // 
            // remarkField
            // 
            this.remarkField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.remarkField.Cursor = System.Windows.Forms.Cursors.Default;
            this.remarkField.Font = new System.Drawing.Font("微软雅黑", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.remarkField.ForeColor = System.Drawing.Color.Snow;
            this.remarkField.Location = new System.Drawing.Point(118, 352);
            this.remarkField.Multiline = true;
            this.remarkField.Name = "remarkField";
            this.remarkField.Size = new System.Drawing.Size(627, 199);
            this.remarkField.TabIndex = 5;
            // 
            // pswField
            // 
            this.pswField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pswField.Cursor = System.Windows.Forms.Cursors.Default;
            this.pswField.Font = new System.Drawing.Font("微软雅黑", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pswField.ForeColor = System.Drawing.Color.Snow;
            this.pswField.Location = new System.Drawing.Point(511, 5);
            this.pswField.Name = "pswField";
            this.pswField.PasswordChar = '*';
            this.pswField.Size = new System.Drawing.Size(234, 57);
            this.pswField.TabIndex = 6;
            // 
            // fieldPanel
            // 
            this.fieldPanel.BackColor = System.Drawing.Color.Transparent;
            this.fieldPanel.Controls.Add(this.pswCheckBox);
            this.fieldPanel.Controls.Add(this.nameLabel);
            this.fieldPanel.Controls.Add(this.remarkField);
            this.fieldPanel.Controls.Add(this.pswField);
            this.fieldPanel.Controls.Add(this.remarkLabel);
            this.fieldPanel.Controls.Add(this.nameField);
            this.fieldPanel.Controls.Add(this.PswLabel);
            this.fieldPanel.Location = new System.Drawing.Point(414, 213);
            this.fieldPanel.Name = "fieldPanel";
            this.fieldPanel.Size = new System.Drawing.Size(754, 554);
            this.fieldPanel.TabIndex = 7;
            // 
            // pswCheckBox
            // 
            this.pswCheckBox.AutoSize = true;
            this.pswCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.pswCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pswCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pswCheckBox.FlatAppearance.BorderSize = 0;
            this.pswCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pswCheckBox.ForeColor = System.Drawing.Color.Snow;
            this.pswCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pswCheckBox.Location = new System.Drawing.Point(511, 164);
            this.pswCheckBox.Name = "pswCheckBox";
            this.pswCheckBox.Size = new System.Drawing.Size(23, 22);
            this.pswCheckBox.TabIndex = 7;
            this.pswCheckBox.UseVisualStyleBackColor = false;
            this.pswCheckBox.CheckedChanged += new System.EventHandler(this.pswCheckBox_CheckedChanged);
            // 
            // BGPanel
            // 
            this.BGPanel.Controls.Add(this.bottomPanel);
            this.BGPanel.Controls.Add(this.topPanel);
            this.BGPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BGPanel.Location = new System.Drawing.Point(0, 0);
            this.BGPanel.Name = "BGPanel";
            this.BGPanel.Size = new System.Drawing.Size(1570, 1185);
            this.BGPanel.TabIndex = 11;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.fieldPanel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(0, 130);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1570, 1055);
            this.bottomPanel.TabIndex = 12;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.cancelButton);
            this.topPanel.Controls.Add(this.title);
            this.topPanel.Controls.Add(this.titleImageBox);
            this.topPanel.Controls.Add(this.confirmButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1570, 130);
            this.topPanel.TabIndex = 11;
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Left;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.title.Location = new System.Drawing.Point(130, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(422, 130);
            this.title.TabIndex = 10;
            this.title.Text = "Library创建";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.close1_48m;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancelButton.ForeColor = System.Drawing.Color.SeaShell;
            this.cancelButton.Location = new System.Drawing.Point(1310, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(130, 130);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // titleImageBox
            // 
            this.titleImageBox.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.library3_48m;
            this.titleImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.titleImageBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.titleImageBox.Location = new System.Drawing.Point(0, 0);
            this.titleImageBox.Name = "titleImageBox";
            this.titleImageBox.Size = new System.Drawing.Size(130, 130);
            this.titleImageBox.TabIndex = 11;
            this.titleImageBox.TabStop = false;
            // 
            // confirmButton
            // 
            this.confirmButton.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.yes3_48m;
            this.confirmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.confirmButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmButton.ForeColor = System.Drawing.Color.SeaShell;
            this.confirmButton.Location = new System.Drawing.Point(1440, 0);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(130, 130);
            this.confirmButton.TabIndex = 9;
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // LibraryAddPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.BGPanel);
            this.Name = "LibraryAddPanel";
            this.Size = new System.Drawing.Size(1570, 1185);
            this.fieldPanel.ResumeLayout(false);
            this.fieldPanel.PerformLayout();
            this.BGPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titleImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label PswLabel;
        private System.Windows.Forms.Label remarkLabel;
        private System.Windows.Forms.TextBox remarkField;
        private System.Windows.Forms.TextBox pswField;
        private System.Windows.Forms.Panel fieldPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Panel BGPanel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.CheckBox pswCheckBox;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox titleImageBox;
    }
}
