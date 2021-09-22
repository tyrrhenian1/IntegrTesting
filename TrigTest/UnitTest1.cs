using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IntegrTesting.Trigonom;

namespace TrigTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFac()
        {
            Assert.AreEqual(24, TrigFunc.Factorial(4));
            Assert.AreEqual(1, TrigFunc.Factorial(0));
        }
        [TestMethod]
        public void TestPower()
        {
            Assert.AreEqual(Math.Pow(1,0), TrigFunc.Power(1, 0));
            Assert.AreEqual(Math.Pow(9, 2), TrigFunc.Power(9, 2));
        }
        [TestMethod]
        public void TestAbs()
        {
            Assert.AreEqual(9, TrigFunc.Abs(-9));
            Assert.AreEqual(167, TrigFunc.Abs(-167));
        }
        [TestMethod]
        public void TestSin()
        {
            Assert.AreEqual(Math.Round(Math.Sin(60 * Math.PI / 180), 4), Math.Round(TrigFunc.Sin(60 * Math.PI / 180), 4));
            Assert.AreEqual(Math.Round(Math.Sin(50 * Math.PI / 180), 4), Math.Round(TrigFunc.Sin(50 * Math.PI / 180), 4));
        }
        [TestMethod]
        public void TestTan()
        {
            Assert.AreEqual(Math.Round(Math.Tan(60 * Math.PI / 180), 4), Math.Round(TrigFunc.Tan(60 * Math.PI / 180), 4));
            Assert.AreEqual(Math.Round(Math.Tan(40 * Math.PI / 180), 4), Math.Round(TrigFunc.Tan(40 * Math.PI / 180), 4));
        }
        [TestMethod]
        public void TestCos()
        {
            Assert.AreEqual(Math.Round(Math.Cos(60*Math.PI/180),4) , Math.Round(TrigFunc.Cos(60*Math.PI/180),4));
            Assert.AreEqual(Math.Round(Math.Cos(20 * Math.PI / 180), 4), Math.Round(TrigFunc.Cos(20 * Math.PI / 180), 4));
        }
        [TestMethod]
        public void TestCotan()
        {
            Assert.AreEqual(Math.Round(1/Math.Tan(60*Math.PI/180),4),Math.Round(TrigFunc.Cotan(60*Math.PI/180),4));
            Assert.AreEqual(Math.Round(1 / Math.Tan(30 * Math.PI / 180), 4), Math.Round(TrigFunc.Cotan(30 * Math.PI / 180), 4));
        }

    }
}
