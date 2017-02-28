using DJTUAttenceSystem.Model;
using HelperSpace;
using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace DJTUAttenceSystem {
    class GlobalStation {
        private volatile static GlobalStation instance = null;
        private static readonly object mutexLocker = new object();
        private GlobalStation() {}
        public static GlobalStation createInstance() {
            if (instance == null) {
                lock (mutexLocker)
                    instance = new GlobalStation();
            }
            return instance;
        }
        public static GlobalStation shareInstance {
            get { return createInstance(); }
        }
        /* ---- Propertys ---- */
        public Entrance entrance = null;
        public DJTUBinary librarys;
        /* ---- Libs ----*/
        public delegate void LibrarySaveBlock();
        public void librarySave(LibrarySaveBlock success,LibrarySaveBlock failure) {
            try {
                librarys.save();
                if (success != null)
                    success();
            }catch(DJTUBinary.FileSaveException e) {
                if (failure != null)
                    failure();
                HKConfirmForm.showConfirmForm(e.Message);
            }
        }
        public void librarysInit() {
            librarys = DJTUBinary.initFromLocal();
        }

    }
}
