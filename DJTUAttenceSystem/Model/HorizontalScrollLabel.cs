using System;
using System.Drawing;
using System.Windows.Forms;

namespace DJTUAttenceSystem.Model {
    public partial class HorizontalScrollLabel : UserControl {
        public enum ScrollState {
            leftScroll = 1,
            rightScroll = 2,
            stopScroll = -1
        }
        private Timer timer;
        private int stopCount = 0;
        private ScrollState state = ScrollState.stopScroll;
        public HorizontalScrollLabel() {
            InitializeComponent();
            this.Resize += resize;
            content.Location = new Point(0, 0);
            content.FlatStyle = FlatStyle.Flat;
            content.BorderStyle = BorderStyle.None;
            content.AutoSize = true;

            timer = new Timer();
            timer.Tick += timer_Tick;
            timer.Interval = 42;
            timer.Enabled = true;
            contentText = content.Text;
        }
        public void resize(object sender,EventArgs e) {
            Height = content.Height;
        }
        public Label contentLabel {
            get {
                return content;
            }
        }
        public Font contentFont {
            set {
                content.Font = value;
                Height = content.Height;
            }
            get {
                return content.Font;
            }
        }
        public String contentText {
            set {
                content.Text = value;
            }
            get {
                return content.Text;
            }
        }

        void timer_Tick(object sender,EventArgs e) {
            Timer t = (Timer)sender;
            if (content.Width < this.Width) { return;}
            // 停止滚动时
            if (state == ScrollState.stopScroll) {
                if (stopCount <= 40) {
                    stopCount++; // 计数
                }else {
                    stopCount = 0; // reset
                    if (content.Location.X == 0) {
                        state = ScrollState.leftScroll; // 向左滚动
                    }else {
                        state = ScrollState.rightScroll; // 向右滚动
                    }
                }
            }
            // 向左滚动时 
            else if (state == ScrollState.leftScroll) {
                content.Location = new Point(content.Location.X - 1, content.Location.Y);
                if (content.Location.X + content.Width <= this.Width) {
                    state = ScrollState.stopScroll;
                }
            }
            // 向右滚动时
            else if (state == ScrollState.rightScroll) {
                content.Location = new Point(content.Location.X + 1, content.Location.Y);
                if (content.Location.X >= 0) {
                    state = ScrollState.stopScroll;
                }
            }
        }

    }
}
