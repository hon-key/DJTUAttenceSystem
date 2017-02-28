namespace DJTUAttenceSystem.Model {
    partial class HKConfirmForm {
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.titleLabel);
            this.topPanel.Size = new System.Drawing.Size(894, 371);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Location = new System.Drawing.Point(0, 371);
            this.bottomPanel.Size = new System.Drawing.Size(894, 82);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.closeButton.Size = new System.Drawing.Size(483, 82);
            // 
            // yesButton
            // 
            this.yesButton.FlatAppearance.BorderSize = 0;
            this.yesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.yesButton.Size = new System.Drawing.Size(411, 82);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(894, 371);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Text";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HKConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.ClientSize = new System.Drawing.Size(894, 453);
            this.Name = "HKConfirmForm";
            this.topPanelHeight = 371;
            this.topPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
    }
}
