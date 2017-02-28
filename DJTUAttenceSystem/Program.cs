using System;
using System.Windows.Forms;
using DJTUAttenceSystem.Model;
using System.Collections;
using System.Drawing.Text;
using System.Drawing;

namespace DJTUAttenceSystem {
    static class Program {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        public static ArrayList usedRandomNumber = new ArrayList();
        static Entrance entrance;
        [STAThread]
        static void Main() {
            start();
        }
        private static void start() {
            printFontList();
            configureApplication();
            configureGlobalStation();
            configureGarbageCollection();
            entrance.Show();
            Application.Run();
        }
        static void printFontList() {
            InstalledFontCollection MyFont = new InstalledFontCollection();
            FontFamily[] MyFontFamilies = MyFont.Families;
            foreach (FontFamily family in MyFontFamilies) {
                String familyName = family.Name;
                Console.WriteLine(familyName);
            }
        }
        static void configureApplication() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            entrance = new Entrance();
        }
        static void configureGlobalStation() {
            GlobalStation station = GlobalStation.createInstance();
            station.librarysInit();
            station.entrance = entrance;
        }
        static void configureGarbageCollection() {
            GBCollect GB = new GBCollect();
            GB.start();
        }
    }
}
