namespace DJTUAttenceSystem.Model {
    partial class HKTextInputForm {
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
            this.title = new System.Windows.Forms.Label();
            this.inputBox = new DJTUAttenceSystem.Model.HKTextBox2();
            this.tipsLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.tipsLabel);
            this.topPanel.Controls.Add(this.inputBox);
            this.topPanel.Controls.Add(this.title);
            this.topPanel.Size = new System.Drawing.Size(946, 320);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Location = new System.Drawing.Point(0, 320);
            this.bottomPanel.Size = new System.Drawing.Size(946, 80);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.closeButton.Size = new System.Drawing.Size(473, 80);
            // 
            // yesButton
            // 
            this.yesButton.FlatAppearance.BorderSize = 0;
            this.yesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.yesButton.Location = new System.Drawing.Point(473, 0);
            this.yesButton.Size = new System.Drawing.Size(473, 80);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.Color.SeaShell;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(946, 150);
            this.title.TabIndex = 0;
            this.title.Text = "Text";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.Color.Transparent;
            this.inputBox.borderColor = System.Drawing.Color.Silver;
            this.inputBox.borderWidth = 3;
            this.inputBox.font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputBox.Location = new System.Drawing.Point(270, 129);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(396, 80);
            this.inputBox.TabIndex = 1;
            this.inputBox.textColor = System.Drawing.SystemColors.HotTrack;
            this.inputBox.textForeColor = System.Drawing.Color.SeaShell;
            // 
            // tipsLabel
            // 
            this.tipsLabel.AutoSize = true;
            this.tipsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipsLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tipsLabel.ForeColor = System.Drawing.Color.Tomato;
            this.tipsLabel.Location = new System.Drawing.Point(254, 237);
            this.tipsLabel.Name = "tipsLabel";
            this.tipsLabel.Size = new System.Drawing.Size(158, 31);
            this.tipsLabel.TabIndex = 2;
            this.tipsLabel.Text = "空字符串无效";
            // 
            // HKTextInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.ClientSize = new System.Drawing.Size(946, 400);
            this.Name = "HKTextInputForm";
            this.topPanelHeight = 320;
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private HKTextBox2 inputBox;
        private System.Windows.Forms.Label tipsLabel;
    }
}
