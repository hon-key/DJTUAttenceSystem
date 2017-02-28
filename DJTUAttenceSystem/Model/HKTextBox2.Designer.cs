namespace DJTUAttenceSystem.Model {
    partial class HKTextBox2 {
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
            this.txBox = new System.Windows.Forms.TextBox();
            this.borderPanel = new System.Windows.Forms.Panel();
            this.borderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txBox
            // 
            this.txBox.Location = new System.Drawing.Point(45, 24);
            this.txBox.Name = "txBox";
            this.txBox.Size = new System.Drawing.Size(100, 35);
            this.txBox.TabIndex = 0;
            // 
            // borderPanel
            // 
            this.borderPanel.BackColor = System.Drawing.Color.Silver;
            this.borderPanel.Controls.Add(this.txBox);
            this.borderPanel.Location = new System.Drawing.Point(108, 31);
            this.borderPanel.Name = "borderPanel";
            this.borderPanel.Size = new System.Drawing.Size(200, 100);
            this.borderPanel.TabIndex = 1;
            // 
            // HKTextBox2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.borderPanel);
            this.Name = "HKTextBox2";
            this.Size = new System.Drawing.Size(434, 192);
            this.Load += new System.EventHandler(this.HKTextBox2_Load);
            this.borderPanel.ResumeLayout(false);
            this.borderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txBox;
        private System.Windows.Forms.Panel borderPanel;
    }
}
