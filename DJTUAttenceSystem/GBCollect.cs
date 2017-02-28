using System;
using System.Threading;

namespace DJTUAttenceSystem {
    // 定期垃圾回收线程
    class GBCollect {
        public Thread thread;
        public GBCollect() {
            ThreadStart st = new ThreadStart(collect);
            thread = new Thread(st);
        }
        private static void collect() {
            for (;;) {
                TimeSpan sp = new TimeSpan(0, 0, 10);
                Thread.Sleep(sp);
                Console.WriteLine("垃圾回收");
                GC.Collect();
            }
        }

        public void start() {
            thread.Start();
        }


    }
}
