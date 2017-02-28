using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace UnitTestProject1 {
    [TestClass]
    public class UnitTest1 {
        public ArrayList usedRandomNumber = new ArrayList();
        [TestMethod]
        public void TestMethod1() {
            for (int i = 0; i < 20; i++) {
                Console.WriteLine(getARandom(10));
            }
        }
        [TestMethod]
        public int getARandom(int maxValue) {
            int result = -1;
            for (int i = 0; i < maxValue; i++) {
                result = new Random().Next(maxValue);
                if (!usedRandomNumber.Contains(result)) {
                    usedRandomNumber.Add(result);
                    break;
                }
            }
            return result;
        }
    }
}
