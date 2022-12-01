using Microsoft.VisualStudio.TestTools.UnitTesting;
using D07_Debug_test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D07_Debug_test.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Assert.AreEqual(1, 1);
            Assert.AreEqual(true, true);
            Assert.AreEqual("string", "string");
            Assert.AreEqual(1.0, 1.0);
            Assert.AreEqual(1.4, // expected value
                            1.62, // actual value
                            2.3, // delta 忍受誤差範圍
                            "error (delta=2.3) " // error message，錯誤時會跳出這個訊息
                            );
            /*
            Assert.AreEqual(1.4, // expected value
                            1.62, // actual value
                            0.1, // delta 忍受誤差範圍
                            "error (delta=0.1) " // error message，錯誤時會跳出這個訊息
                            );
            */
        }

        [TestMethod()]
        public void AddTest()
        {
            double expected = 6.0; // TODO: 初始化為適當值
            double actual;

            Form1 test = new Form1();
            actual = test.Add(2.0, 4.0);
            Assert.AreEqual(expected, actual);
        }

    }
}