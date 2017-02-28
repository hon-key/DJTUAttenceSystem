namespace DJTUAttenceSystem.LibraryHall {
    partial class LibraryEditForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.topBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.editPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.remarkBox = new DJTUAttenceSystem.Model.HKTextBox();
            this.remarkLabel = new System.Windows.Forms.Label();
            this.upPanel = new System.Windows.Forms.Panel();
            this.pswCheckBox = new System.Windows.Forms.CheckBox();
            this.pswBox = new DJTUAttenceSystem.Model.HKTextBox2();
            this.pswLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new DJTUAttenceSystem.Model.HKTextBox2();
            this.nameLabel = new System.Windows.Forms.Label();
            this.topBar.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.upPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.Controls.Add(this.label1);
            this.topBar.Controls.Add(this.yesButton);
            this.topBar.Controls.Add(this.closeButton);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(974, 120);
            this.topBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("幼圆", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 120);
            this.label1.TabIndex = 2;
            this.label1.Text = "修改信息";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.Color.Transparent;
            this.yesButton.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.tick_32m;
            this.yesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.yesButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.yesButton.FlatAppearance.BorderSize = 0;
            this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesButton.Location = new System.Drawing.Point(714, 0);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(130, 120);
            this.yesButton.TabIndex = 0;
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.close3_32m;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(844, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(130, 120);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.bottomPanel);
            this.editPanel.Controls.Add(this.upPanel);
            this.editPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editPanel.Location = new System.Drawing.Point(0, 120);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(974, 383);
            this.editPanel.TabIndex = 1;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.remarkBox);
            this.bottomPanel.Controls.Add(this.remarkLabel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(0, 110);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(974, 273);
            this.bottomPanel.TabIndex = 1;
            // 
            // remarkBox
            // 
            this.remarkBox.BackColor = System.Drawing.Color.DimGray;
            this.remarkBox.bar = System.Windows.Forms.ScrollBars.Vertical;
            this.remarkBox.BGColor = System.Drawing.SystemColors.Window;
            this.remarkBox.borderColor = System.Drawing.Color.DimGray;
            this.remarkBox.borderWidth = 2;
            this.remarkBox.foreColor = System.Drawing.Color.SeaShell;
            this.remarkBox.Location = new System.Drawing.Point(281, 43);
            this.remarkBox.Name = "remarkBox";
            this.remarkBox.Size = new System.Drawing.Size(296, 133);
            this.remarkBox.TabIndex = 1;
            this.remarkBox.text = "";
            this.remarkBox.textFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.remarkBox.widthOffset = 17;
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
            this.remarkLabel.Size = new System.Drawing.Size(130, 273);
            this.remarkLabel.TabIndex = 0;
            this.remarkLabel.Text = "备注:";
            this.remarkLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // upPanel
            // 
            this.upPanel.Controls.Add(this.pswCheckBox);
            this.upPanel.Controls.Add(this.pswBox);
            this.upPanel.Controls.Add(this.pswLabel);
            this.upPanel.Controls.Add(this.nameTextBox);
            this.upPanel.Controls.Add(this.nameLabel);
            this.upPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upPanel.Location = new System.Drawing.Point(0, 0);
            this.upPanel.Name = "upPanel";
            this.upPanel.Size = new System.Drawing.Size(974, 110);
            this.upPanel.TabIndex = 0;
            // 
            // pswCheckBox
            // 
            this.pswCheckBox.AutoSize = true;
            this.pswCheckBox.FlatAppearance.BorderSize = 0;
            this.pswCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pswCheckBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pswCheckBox.ForeColor = System.Drawing.Color.SeaShell;
            this.pswCheckBox.Location = new System.Drawing.Point(764, 47);
            this.pswCheckBox.Name = "pswCheckBox";
            this.pswCheckBox.Size = new System.Drawing.Size(154, 40);
            this.pswCheckBox.TabIndex = 4;
            this.pswCheckBox.Text = "显示密码";
            this.pswCheckBox.UseVisualStyleBackColor = true;
            this.pswCheckBox.CheckedChanged += new System.EventHandler(this.pswCheckBox_CheckedChanged);
            // 
            // pswBox
            // 
            this.pswBox.BackColor = System.Drawing.Color.Transparent;
            this.pswBox.borderColor = System.Drawing.Color.Silver;
            this.pswBox.borderWidth = 2;
            this.pswBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pswBox.font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pswBox.Location = new System.Drawing.Point(500, 0);
            this.pswBox.Name = "pswBox";
            this.pswBox.Size = new System.Drawing.Size(240, 110);
            this.pswBox.TabIndex = 3;
            this.pswBox.textColor = System.Drawing.SystemColors.Window;
            this.pswBox.textForeColor = System.Drawing.Color.SeaShell;
            // 
            // pswLabel
            // 
            this.pswLabel.BackColor = System.Drawing.Color.Transparent;
            this.pswLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pswLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pswLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pswLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.pswLabel.Location = new System.Drawing.Point(370, 0);
            this.pswLabel.Name = "pswLabel";
            this.pswLabel.Size = new System.Drawing.Size(130, 110);
            this.pswLabel.TabIndex = 2;
            this.pswLabel.Text = "密码:";
            this.pswLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.nameTextBox.borderColor = System.Drawing.Color.Silver;
            this.nameTextBox.borderWidth = 2;
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameTextBox.font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameTextBox.Location = new System.Drawing.Point(130, 0);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(240, 110);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.textColor = System.Drawing.SystemColors.Window;
            this.nameTextBox.textForeColor = System.Drawing.Color.SeaShell;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.nameLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(130, 110);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "名称:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LibraryEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(974, 503);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibraryEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LibraryEditForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LibraryEditForm_Load);
            this.topBar.ResumeLayout(false);
            this.editPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label nameLabel;
        private Model.HKTextBox2 nameTextBox;
        private Model.HKTextBox2 pswBox;
        private System.Windows.Forms.Label pswLabel;
        private System.Windows.Forms.Label remarkLabel;
        private Model.HKTextBox remarkBox;
        private System.Windows.Forms.CheckBox pswCheckBox;
        private System.Windows.Forms.Label label1;
    }
}