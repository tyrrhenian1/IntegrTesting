using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IntegrTesting.Log;

namespace LogTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLog()
        {
            Assert.AreEqual(Math.Round(Math.Log(0.7),4),Math.Round(LogFunc.Ln1MinusX(0.3),4));
        }

    }
}
