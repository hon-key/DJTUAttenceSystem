namespace DJTUAttenceSystem.Model {
    partial class HorizontalScrollLabel {
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
            this.content = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.AutoSize = true;
            this.content.BackColor = System.Drawing.Color.Transparent;
            this.content.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.content.ForeColor = System.Drawing.Color.White;
            this.content.Location = new System.Drawing.Point(26, 33);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(131, 37);
            this.content.TabIndex = 0;
            this.content.Text = "label1";
            // 
            // HorizontalScrollLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.content);
            this.Name = "HorizontalScrollLabel";
            this.Size = new System.Drawing.Size(259, 97);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label content;
    }
}
