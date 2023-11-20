using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Practice3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var FirstNumber = new NumberCalculations(1, 2, 3);
            var res = FirstNumber.PerformCalculation();
            var testres = 36; // test 
            Assert.AreEqual(testres, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var FirstNumber = new NumberCalculations(2, 4, 6);
            var res = FirstNumber.PerformCalculation();
            var testres = 48; // test 
            Assert.AreEqual(testres, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var interval = new Interval(0, 10);
            var testres = 30;
            var res = interval.IntervalCalculation();
            Assert.AreEqual(testres, res);

        }
    }
}
