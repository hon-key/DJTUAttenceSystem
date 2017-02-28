namespace DJTUAttenceSystem.Model {
    partial class HKTextBox {
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.bgPanel = new System.Windows.Forms.Panel();
            this.bgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox.Location = new System.Drawing.Point(20, 26);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 35);
            this.textBox.TabIndex = 0;
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.textBox);
            this.bgPanel.Location = new System.Drawing.Point(162, 70);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(200, 100);
            this.bgPanel.TabIndex = 1;
            // 
            // HKTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.bgPanel);
            this.Name = "HKTextBox";
            this.Size = new System.Drawing.Size(465, 241);
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Panel bgPanel;
    }
}
