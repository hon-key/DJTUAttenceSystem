using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace HelperSpace { 
    class HSBProperty {
        public static int hue = 0;
        public static int sat = 1;
        public static int bri = 2;
        public static int alphaFull = 255;
        public static int alpahHalf = 125;
    }
    class Helper {
        public static string deepColor = "#293E6A";
        public static string normalColor = "#3B5998";
        public static string highlightColor = "#639BF1";
        public static string specialColor = "#77BA9B";

        /* ----- 鼠标拖动时间API ----- */
        public static void dragControl(Control control) {
            ReleaseCapture();// 释放捕获
            SendMessage(control.Handle, WM_SYSCOMMAND, HTCAPTION + SC_MOVE, 0);
        }
        // user32 API 释放鼠标
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        // user32 API 控制
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0X0112; // 鼠标事件
        public const int SC_MOVE = 0xf010; // 移动通知
        public const int HTCAPTION = 0X0002; // 标题栏id
        /* ----- 鼠标拖动时间API ----- */

        /* ----- 滚动条相关 ----- */
        public enum scrollBarType {
            Horizental = 0,
            Vertical = 1,
            HorizentalAndVertical = 3
        }
        public static void showScrollBar(Control control,scrollBarType type) {
            SetScrollBar(control.Handle, (int)type, 1);
        }
        public static void hideScrollBar(Control control,scrollBarType type) {
            SetScrollBar(control.Handle, (int)type, 0);
        }
        [DllImport("user32.dll")]
        private static extern int ShowScrollBar(IntPtr hWnd, int bar, int show);
        private class SubWindow : NativeWindow {
            private int m_Horz = 0;
            private int m_Show = 0;
            public SubWindow(int p_Horz, int p_Show) {
                m_Horz = p_Horz;
                m_Show = p_Show;
            }
            protected override void WndProc(ref Message m_Msg) {
                ShowScrollBar(m_Msg.HWnd, m_Horz, m_Show);
                base.WndProc(ref m_Msg);
            }
        }

        [DllImport("user32.dll")]
        private static extern int GetScrollPos(IntPtr hwnd, int nBar);
        /// <summary>  
        /// 设置滚动条是否显示
        /// </summary>  
        /// <param name="p_ControlHandle">句柄</param>  
        /// <param name="p_Horz">0横 1列 3全部</param>  
        /// <param name="p_Show">0隐 1显</param> 
        public static void SetScrollBar(IntPtr p_ControlHandle, int p_Horz, int p_Show) {
            SubWindow _SubWindow = new SubWindow(p_Horz, p_Show);
            _SubWindow.AssignHandle(p_ControlHandle);
        }
        /* ----- 滚动条相关 ----- */

        /* ----- HSB TO RGB ----- */
        public static List<float> getHSB(Color color) {
            List<float> hsbList = new List<float>();
            hsbList.Add(color.GetHue());
            hsbList.Add(color.GetSaturation());
            hsbList.Add(color.GetBrightness());
            return hsbList;
        }
        public static Color FromAhsb(int alpha, List<float> hsb) {
            float hue = hsb[HSBProperty.hue];
            float saturation = hsb[HSBProperty.sat];
            float brightness = hsb[HSBProperty.bri];
            if (0 > alpha || 255 < alpha) {
                throw new ArgumentOutOfRangeException("alpha",alpha,"Value must be within a range of 0 - 255.");
            }
            if (0f > hue || 360f < hue) {
                throw new ArgumentOutOfRangeException("hue",hue,"Value must be within a range of 0 - 360.");
            }
            if (0f > saturation || 1f < saturation) {
                throw new ArgumentOutOfRangeException("saturation",saturation,"Value must be within a range of 0 - 1.");
            }
            if (0f > brightness || 1f < brightness) {
                throw new ArgumentOutOfRangeException("brightness",brightness,"Value must be within a range of 0 - 1.");
            }
            if (0 == saturation) {
                return Color.FromArgb(alpha,Convert.ToInt32(brightness * 255),
                    Convert.ToInt32(brightness * 255),Convert.ToInt32(brightness * 255));
            }

            float fMax, fMid, fMin;
            int iSextant, iMax, iMid, iMin;

            if (0.5 < brightness) {
                fMax = brightness - (brightness * saturation) + saturation;
                fMin = brightness + (brightness * saturation) - saturation;
            } else {
                fMax = brightness + (brightness * saturation);
                fMin = brightness - (brightness * saturation);
            }

            iSextant = (int)Math.Floor(hue / 60f);
            if (300f <= hue) { hue -= 360f;}

            hue /= 60f;
            hue -= 2f * (float)Math.Floor(((iSextant + 1f) % 6f) / 2f);

            if (0 == iSextant % 2) { fMid = (hue * (fMax - fMin)) + fMin; } 
            else                   { fMid = fMin - (hue * (fMax - fMin)); }

            iMax = Convert.ToInt32(fMax * 255);
            iMid = Convert.ToInt32(fMid * 255);
            iMin = Convert.ToInt32(fMin * 255);
            switch (iSextant) {
                case 1:
                    return Color.FromArgb(alpha, iMid, iMax, iMin);
                case 2:
                    return Color.FromArgb(alpha, iMin, iMax, iMid);
                case 3:
                    return Color.FromArgb(alpha, iMin, iMid, iMax);
                case 4:
                    return Color.FromArgb(alpha, iMid, iMin, iMax);
                case 5:
                    return Color.FromArgb(alpha, iMax, iMin, iMid);
                default:
                    return Color.FromArgb(alpha, iMax, iMid, iMin);
            }
        }
        public static Color ToColor(string color) {

            int red, green, blue = 0;
            char[] rgb;
            color = color.TrimStart('#');
            color = Regex.Replace(color.ToLower(), "[g-zG-Z]", "");
            switch (color.Length) {
                case 3:
                    rgb = color.ToCharArray();
                    red = Convert.ToInt32(rgb[0].ToString() + rgb[0].ToString(), 16);
                    green = Convert.ToInt32(rgb[1].ToString() + rgb[1].ToString(), 16);
                    blue = Convert.ToInt32(rgb[2].ToString() + rgb[2].ToString(), 16);
                    return Color.FromArgb(red, green, blue);
                case 6:
                    rgb = color.ToCharArray();
                    red = Convert.ToInt32(rgb[0].ToString() + rgb[1].ToString(), 16);
                    green = Convert.ToInt32(rgb[2].ToString() + rgb[3].ToString(), 16);
                    blue = Convert.ToInt32(rgb[4].ToString() + rgb[5].ToString(), 16);
                    return Color.FromArgb(red, green, blue);
                default:
                    return Color.FromName(color);

            }
        }
        public static Color getColorByAddBri(Color color,float bri) {
            List<float> hsb = getHSB(color);
            hsb[HSBProperty.bri] += bri;
            return FromAhsb(HSBProperty.alphaFull, hsb);
        }
        /* ----- HSB TO RGB ----- */

        /* ----- Draw ----- */
        public static void DrawRoundRectangle(Graphics g, Pen pen, Rectangle rect, int cornerRadius) {
            using (GraphicsPath path = CreateRoundedRectanglePath(rect, cornerRadius)) {
                g.DrawPath(pen, path);
            }
        }
        public static void FillRoundRectangle(Graphics g, Brush brush, Rectangle rect, int cornerRadius) {
            using (GraphicsPath path = CreateRoundedRectanglePath(rect, cornerRadius)) {
                g.FillPath(brush, path);
            }
        }
        internal static GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int cornerRadius) {
            GraphicsPath roundedRect = new GraphicsPath();
            roundedRect.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            roundedRect.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - cornerRadius * 2, rect.Y);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            roundedRect.AddLine(rect.Right, rect.Y + cornerRadius * 2, rect.Right, rect.Y + rect.Height - cornerRadius * 2);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y + rect.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            roundedRect.AddLine(rect.Right - cornerRadius * 2, rect.Bottom, rect.X + cornerRadius * 2, rect.Bottom);
            roundedRect.AddArc(rect.X, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRect.AddLine(rect.X, rect.Bottom - cornerRadius * 2, rect.X, rect.Y + cornerRadius * 2);
            roundedRect.CloseFigure();
            return roundedRect;
        }
        public static void drawBorder(Control control, Color color,int width) {
            Graphics g = Graphics.FromHwnd(control.Handle);
            ControlPaint.DrawBorder(g, control.ClientRectangle,
                color, width, ButtonBorderStyle.Solid, color, width, ButtonBorderStyle.Solid,
                color, width, ButtonBorderStyle.Solid, color, width, ButtonBorderStyle.Solid);
            g.Dispose();
        }
        /* ----- Draw ----- */


        /* ----- Form shaddow ----- */
        public static void setFormShaddow(Control control) {
            SetClassLong(control.Handle, GCL_STYLE,GetClassLong(control.Handle, GCL_STYLE) | CS_DropSHADOW);
        }
        public static  int CS_DropSHADOW = 0x20000;
        public static  int GCL_STYLE = (-26);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);
        /* ----- Form shaddow ----- */

        /* ----- date ----- */
        public static bool isTheSameDay(DateTime d1, DateTime d2) {
            return (d1.Year == d2.Year
                    && d1.Month == d2.Month
                    && d1.Day == d2.Day);
        }
        /* ----- date ----- */

        /* ----- 反射移除所有事件 ----- */
        public static void RemoveEvent(Control c, string name) {
            Delegate[] invokeList = GetObjectEventList(c, string.Format("Event{0}", name));
            if (invokeList == null) {return;}
            foreach (Delegate del in invokeList) {
                typeof(Control).GetEvent(name).RemoveEventHandler(c, del);
            }
        }
        /// <summary>
        /// 获取控件事件  
        /// </summary>
        /// <param name="p_Control">对象</param>
        /// <param name="p_EventName">事件名 EventClick EventDoubleClick </param>
        /// <returns>委托列</returns>
        public static Delegate[] GetObjectEventList(Control p_Control, string p_EventName) {
            PropertyInfo _PropertyInfo = p_Control.GetType().GetProperty("Events", BindingFlags.Instance | BindingFlags.NonPublic);
            if (_PropertyInfo != null) {
                object _EventList = _PropertyInfo.GetValue(p_Control, null);
                if (_EventList != null && _EventList is EventHandlerList) {
                    EventHandlerList _List = (EventHandlerList)_EventList;
                    FieldInfo _FieldInfo = (typeof(Control)).GetField(p_EventName, BindingFlags.Static | BindingFlags.NonPublic);
                    if (_FieldInfo == null) return null;
                    Delegate _ObjectDelegate = _List[_FieldInfo.GetValue(p_Control)];
                    if (_ObjectDelegate == null) return null;
                    return _ObjectDelegate.GetInvocationList();
                }
            }
            return null;
        }

    /* ----- 反射移除所有事件 ----- */

    /* ----- 修改文件名 ----- */
    public static bool changeFileName(string srcFileName,string desFileName, bool isRelative) {
            try {
                string srcAbsolutePath;
                string desAbsolutePath;
                if (isRelative) {
                    srcAbsolutePath = string.Format("{0}\\{1}", Application.StartupPath, srcFileName);
                    desAbsolutePath = string.Format("{0}\\{1}", Application.StartupPath, desFileName);
                }else {
                    srcAbsolutePath = srcFileName;
                    desAbsolutePath = desFileName;
                }
                if (File.Exists(srcAbsolutePath)) {
                    File.Move(srcAbsolutePath, desAbsolutePath);
                    return true;
                } else {
                    return false;
                }
            } catch {
                return false;
            }
        }
        /* ----- 修改文件名 ----- */

        /* ----- 判断字符串是否为空或者whitespace ----- */
        public static bool IsNullOrWhiteSpace(string value) {
            if (value != null) {
                for (int i = 0; i < value.Length; i++) {
                    if (!char.IsWhiteSpace(value[i])) {
                        return false;
                    }
                }
            }
            return true;
        }
        /* ----- 判断字符串是否为空或者whitespace ----- */
        /* ----- 窗体抖动 ----- */
        public static void shakeForm(Form form,int counts) {
            Point originPoint = new Point(form.Location.X, form.Location.Y);
            Random r = new Random();
            for (int i = 0; i <= counts; i++) {
                form.Location = new Point(originPoint.X + r.Next(-5, 5), originPoint.Y + r.Next(-5, 5));
                Thread.Sleep(50);
                form.Location = originPoint;
                Thread.Sleep(50);
            }
        }
    }
}
