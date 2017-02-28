namespace DJTUAttenceSystem.Course {
    partial class HKButtonPanel {
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
            this.BGPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BGPanel
            // 
            this.BGPanel.BackColor = System.Drawing.Color.DimGray;
            this.BGPanel.Location = new System.Drawing.Point(98, 19);
            this.BGPanel.Name = "BGPanel";
            this.BGPanel.Size = new System.Drawing.Size(832, 110);
            this.BGPanel.TabIndex = 0;
            // 
            // HKButtonPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.BGPanel);
            this.Name = "HKButtonPanel";
            this.Size = new System.Drawing.Size(1144, 154);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BGPanel;
    }
}
