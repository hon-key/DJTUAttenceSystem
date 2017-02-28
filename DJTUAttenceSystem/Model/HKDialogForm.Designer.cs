namespace DJTUAttenceSystem.Model {
    partial class HKDialogForm {
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.yesButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.BGPanel = new System.Windows.Forms.Panel();
            this.bottomPanel.SuspendLayout();
            this.BGPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(572, 211);
            this.topPanel.TabIndex = 0;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.yesButton);
            this.bottomPanel.Controls.Add(this.closeButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(0, 211);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(572, 93);
            this.bottomPanel.TabIndex = 1;
            // 
            // yesButton
            // 
            this.yesButton.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.yes3_32m;
            this.yesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.yesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yesButton.FlatAppearance.BorderSize = 0;
            this.yesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesButton.Location = new System.Drawing.Point(307, 0);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(265, 93);
            this.yesButton.TabIndex = 2;
            this.yesButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::DJTUAttenceSystem.Properties.Resources.close2_32m;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(0, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(307, 93);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // BGPanel
            // 
            this.BGPanel.Controls.Add(this.bottomPanel);
            this.BGPanel.Controls.Add(this.topPanel);
            this.BGPanel.Location = new System.Drawing.Point(166, 73);
            this.BGPanel.Name = "BGPanel";
            this.BGPanel.Size = new System.Drawing.Size(572, 304);
            this.BGPanel.TabIndex = 2;
            // 
            // HKDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(946, 617);
            this.Controls.Add(this.BGPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HKDialogForm";
            this.Text = "HKDialogForm";
            this.bottomPanel.ResumeLayout(false);
            this.BGPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel topPanel;
        public System.Windows.Forms.Panel bottomPanel;
        public System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Panel BGPanel;
    }
}