namespace DJTUAttenceSystem.Model {
    partial class HKSelectForm {
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
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Size = new System.Drawing.Size(946, 139);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Location = new System.Drawing.Point(0, 139);
            this.bottomPanel.Size = new System.Drawing.Size(946, 71);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.closeButton.Size = new System.Drawing.Size(483, 71);
            // 
            // yesButton
            // 
            this.yesButton.FlatAppearance.BorderSize = 0;
            this.yesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.yesButton.Size = new System.Drawing.Size(463, 71);
            // 
            // HKSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.ClientSize = new System.Drawing.Size(946, 210);
            this.Name = "HKSelectForm";
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
