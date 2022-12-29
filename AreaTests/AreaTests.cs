using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Area;

namespace Area.Tests
{
    [TestClass]
    public class AreaTests
    {
        [TestMethod]
        public void OneParameterTest()
        {
            double a = 3;
            string expected = "28,27 9";

            string s = CalcArea.OneParameter(a);
            Assert.AreEqual(expected, s);
        }
        [TestMethod]
        public void TwoParameterTest()
        {
            double a = 4;
            double b = 5;
            string expected = "20 10";

            string s = CalcArea.TwoParameter(a, b);

            Assert.AreEqual(expected, s);
        }
        [TestMethod]
        public void ThreeParameterTest()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            string expected = "6";

            string s = CalcArea.ThreeParameter(a, b, c);

            Assert.AreEqual(expected, s);
        }
    }
}
