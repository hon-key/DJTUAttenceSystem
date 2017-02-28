namespace DJTUAttenceSystem.Course {
    partial class CourseReport {
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
            this.switchPanel = new System.Windows.Forms.Panel();
            this.absThreeTimes = new System.Windows.Forms.RadioButton();
            this.fullAttandance = new System.Windows.Forms.RadioButton();
            this.stuFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.switchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.stuFlowPanel);
            this.topPanel.Controls.Add(this.switchPanel);
            this.topPanel.Controls.Add(this.titleLabel);
            this.topPanel.Size = new System.Drawing.Size(1181, 600);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Location = new System.Drawing.Point(0, 600);
            this.bottomPanel.Size = new System.Drawing.Size(1181, 106);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.closeButton.Size = new System.Drawing.Size(593, 106);
            // 
            // yesButton
            // 
            this.yesButton.FlatAppearance.BorderSize = 0;
            this.yesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.yesButton.Location = new System.Drawing.Point(593, 0);
            this.yesButton.Size = new System.Drawing.Size(588, 106);
            // 
            // switchPanel
            // 
            this.switchPanel.Controls.Add(this.absThreeTimes);
            this.switchPanel.Controls.Add(this.fullAttandance);
            this.switchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.switchPanel.Location = new System.Drawing.Point(0, 105);
            this.switchPanel.Name = "switchPanel";
            this.switchPanel.Size = new System.Drawing.Size(1181, 110);
            this.switchPanel.TabIndex = 0;
            // 
            // absThreeTimes
            // 
            this.absThreeTimes.Appearance = System.Windows.Forms.Appearance.Button;
            this.absThreeTimes.Dock = System.Windows.Forms.DockStyle.Left;
            this.absThreeTimes.FlatAppearance.BorderSize = 0;
            this.absThreeTimes.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.absThreeTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.absThreeTimes.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.absThreeTimes.ForeColor = System.Drawing.Color.SeaShell;
            this.absThreeTimes.Location = new System.Drawing.Point(226, 0);
            this.absThreeTimes.Name = "absThreeTimes";
            this.absThreeTimes.Size = new System.Drawing.Size(367, 110);
            this.absThreeTimes.TabIndex = 1;
            this.absThreeTimes.TabStop = true;
            this.absThreeTimes.Text = "旷课超过三次的学生";
            this.absThreeTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.absThreeTimes.UseVisualStyleBackColor = true;
            this.absThreeTimes.CheckedChanged += new System.EventHandler(this.absThreeTimes_CheckedChanged);
            // 
            // fullAttandance
            // 
            this.fullAttandance.Appearance = System.Windows.Forms.Appearance.Button;
            this.fullAttandance.Dock = System.Windows.Forms.DockStyle.Left;
            this.fullAttandance.FlatAppearance.BorderSize = 0;
            this.fullAttandance.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.fullAttandance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullAttandance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fullAttandance.ForeColor = System.Drawing.Color.SeaShell;
            this.fullAttandance.Location = new System.Drawing.Point(0, 0);
            this.fullAttandance.Name = "fullAttandance";
            this.fullAttandance.Size = new System.Drawing.Size(226, 110);
            this.fullAttandance.TabIndex = 0;
            this.fullAttandance.TabStop = true;
            this.fullAttandance.Text = "满勤的学生";
            this.fullAttandance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fullAttandance.UseVisualStyleBackColor = true;
            this.fullAttandance.CheckedChanged += new System.EventHandler(this.fullAttandance_CheckedChanged);
            // 
            // stuFlowPanel
            // 
            this.stuFlowPanel.AutoScroll = true;
            this.stuFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stuFlowPanel.Location = new System.Drawing.Point(0, 215);
            this.stuFlowPanel.Name = "stuFlowPanel";
            this.stuFlowPanel.Size = new System.Drawing.Size(1181, 385);
            this.stuFlowPanel.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1181, 105);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.ClientSize = new System.Drawing.Size(1187, 712);
            this.Name = "CourseReport";
            this.topPanelHeight = 600;
            this.topPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.switchPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel stuFlowPanel;
        private System.Windows.Forms.Panel switchPanel;
        private System.Windows.Forms.RadioButton absThreeTimes;
        private System.Windows.Forms.RadioButton fullAttandance;
        private System.Windows.Forms.Label titleLabel;
    }
}
