using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DJTUAttenceSystem.Model {
    public struct HKDialogFilter {
        public static string Course = "课程文件|*.crs";
        public static string Excel = "97-2003版Excel|*.xls|2007以上版本Excel|*.xlsx";
        public static string Library = "库文件|*.atl";
    }
    class HKOpenFileDialog {
        OpenFileDialog dialog;
        protected HKOpenFileDialog(string filter) {
            dialog = new OpenFileDialog();
            dialog.InitialDirectory = System.Environment.CurrentDirectory;
            dialog.Filter = filter;
            dialog.RestoreDirectory = true;
            dialog.FilterIndex = 1;
        }
        public static string selectFile(string filter) {
            return new HKOpenFileDialog(filter).openFile();
        }
        protected string openFile() {
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK) {
                return dialog.FileName;
            }
            throw new CancelOpenFileException("文件选择失败");
        }

        public class CancelOpenFileException : ApplicationException {
            public CancelOpenFileException(string message) : base(message) {

            }
        }
    }
    class HKSaveFileDialog {
        SaveFileDialog dialog;
        protected HKSaveFileDialog(string filter) {
            dialog = new SaveFileDialog();
            dialog.InitialDirectory = System.Environment.CurrentDirectory;
            dialog.Filter = filter;
        }
        public static string saveTo(string filter) {
            return new HKSaveFileDialog(filter).saveFile();
        }
        protected string saveFile() {
            if (dialog.ShowDialog() == DialogResult.OK) {
                return dialog.FileName;
            }
            throw new CancelSaveFileException("保存文件失败");
        }

        public class CancelSaveFileException:ApplicationException {
            public CancelSaveFileException(string message) : base(message) {

            }
        }
    }
}
