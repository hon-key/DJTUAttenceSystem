namespace DJTUAttenceSystem {
    partial class AddPanel {
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
            this.bgPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgPanel.Location = new System.Drawing.Point(0, 0);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(188, 233);
            this.bgPanel.TabIndex = 0;
            this.bgPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // AddPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bgPanel);
            this.Name = "AddPanel";
            this.Size = new System.Drawing.Size(188, 233);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bgPanel;
    }
}
