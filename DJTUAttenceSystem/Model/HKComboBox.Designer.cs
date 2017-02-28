namespace DJTUAttenceSystem.Model {
    partial class HKComboBox {
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(136, 57);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 32);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Location = new System.Drawing.Point(14, 60);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(82, 24);
            this.title.TabIndex = 1;
            this.title.Text = "label1";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HKComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.title);
            this.Controls.Add(this.comboBox);
            this.Name = "HKComboBox";
            this.Size = new System.Drawing.Size(356, 145);
            this.Load += new System.EventHandler(this.HKComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label title;
    }
}
