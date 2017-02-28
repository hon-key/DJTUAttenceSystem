namespace DJTUAttenceSystem.Course {
    partial class CourseHallEditForm {
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
            this.editPanel = new DJTUAttenceSystem.Course.CourseEdit();
            this.SuspendLayout();
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.Color.Transparent;
            this.editPanel.BarHeight = 100;
            this.editPanel.Location = new System.Drawing.Point(124, 113);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(1312, 558);
            this.editPanel.TabIndex = 0;
            this.editPanel.titleText = "创建新课程";
            // 
            // CourseHallEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1612, 711);
            this.Controls.Add(this.editPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseHallEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CourseHallEditForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CourseEdit editPanel;
    }
}