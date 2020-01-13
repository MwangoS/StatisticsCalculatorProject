using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        private readonly int f = 50;
        private readonly int g = 10;
        private readonly double h = 2.5;
        private readonly double i = 1.3;
        private readonly int[] j = { 5, 7, 6 };
        private readonly double[] k = { 2.1, 1.5 };

        [TestMethod()]
        public void SumTest()
        {
            Assert.AreEqual(60, Addition.Sum(f, g));
        }

        [TestMethod()]
        public void SumDoubleTest()
        {
            Assert.AreEqual(3.8, Addition.Subtract(h, i));
        }

        [TestMethod()]
        public void SumIntArrayTest()
        {
            Assert.AreEqual(18, Addition.Sum(j));
        }

        [TestMethod()]
        public void SumDoubleArrayTest()
        {
            Assert.AreEqual(3.6, Addition.Sum(k));
        }
    }
}