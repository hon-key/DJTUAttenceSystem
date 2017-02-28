namespace DJTUAttenceSystem {
    partial class Entrance {
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
            this.MinSizeBtn = new System.Windows.Forms.Button();
            this.MaxSizeBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.Panel();
            this.topBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.Blue;
            this.topBar.Controls.Add(this.label1);
            this.topBar.Controls.Add(this.MinSizeBtn);
            this.topBar.Controls.Add(this.MaxSizeBtn);
            this.topBar.Controls.Add(this.CloseBtn);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(876, 40);
            this.topBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "大连交通大学考勤系统";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinSizeBtn
            // 
            this.MinSizeBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.MinSizeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinSizeBtn.FlatAppearance.BorderSize = 0;
            this.MinSizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.MinSizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinSizeBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MinSizeBtn.Location = new System.Drawing.Point(644, 0);
            this.MinSizeBtn.Name = "MinSizeBtn";
            this.MinSizeBtn.Size = new System.Drawing.Size(75, 40);
            this.MinSizeBtn.TabIndex = 2;
            this.MinSizeBtn.Text = "—";
            this.MinSizeBtn.UseVisualStyleBackColor = false;
            // 
            // MaxSizeBtn
            // 
            this.MaxSizeBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.MaxSizeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaxSizeBtn.FlatAppearance.BorderSize = 0;
            this.MaxSizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.MaxSizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxSizeBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MaxSizeBtn.Location = new System.Drawing.Point(719, 0);
            this.MaxSizeBtn.Name = "MaxSizeBtn";
            this.MaxSizeBtn.Size = new System.Drawing.Size(75, 40);
            this.MaxSizeBtn.TabIndex = 1;
            this.MaxSizeBtn.Text = "囗";
            this.MaxSizeBtn.UseVisualStyleBackColor = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseBtn.Location = new System.Drawing.Point(794, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(82, 40);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 40);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(876, 519);
            this.container.TabIndex = 1;
            // 
            // Entrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(876, 559);
            this.Controls.Add(this.container);
            this.Controls.Add(this.topBar);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Entrance";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Entrance_Load);
            this.topBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MaxSizeBtn;
        private System.Windows.Forms.Button MinSizeBtn;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Label label1;
    }
}