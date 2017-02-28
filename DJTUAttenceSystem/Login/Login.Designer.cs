namespace DJTUAttenceSystem {
    partial class Login {
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
            this.topBar = new System.Windows.Forms.Panel();
            this.SettingButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.hkTableView1 = new DJTUAttenceSystem.Model.HKTableView();
            this.topBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.Transparent;
            this.topBar.Controls.Add(this.SettingButton);
            this.topBar.Controls.Add(this.addButton);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(1077, 100);
            this.topBar.TabIndex = 0;
            // 
            // SettingButton
            // 
            this.SettingButton.AutoSize = true;
            this.SettingButton.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.setting1_5m;
            this.SettingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SettingButton.FlatAppearance.BorderSize = 0;
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingButton.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SettingButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.SettingButton.Location = new System.Drawing.Point(945, 23);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(94, 74);
            this.SettingButton.TabIndex = 1;
            this.SettingButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.add1_5m;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.addButton.Location = new System.Drawing.Point(810, 23);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(83, 74);
            this.addButton.TabIndex = 0;
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // hkTableView1
            // 
            this.hkTableView1.AutoScroll = true;
            this.hkTableView1.BackColor = System.Drawing.Color.Transparent;
            this.hkTableView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hkTableView1.Location = new System.Drawing.Point(0, 100);
            this.hkTableView1.Name = "hkTableView1";
            this.hkTableView1.Size = new System.Drawing.Size(1077, 632);
            this.hkTableView1.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.hkTableView1);
            this.Controls.Add(this.topBar);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1077, 732);
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button SettingButton;
        private Model.HKTableView hkTableView1;
    }
}
