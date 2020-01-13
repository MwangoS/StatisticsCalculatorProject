using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        private readonly int a = 10;
        private readonly int b = 50;
        private readonly int c = 0;

        [TestMethod()]
        public void QuotientTest()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Division.Quotient(a, c));
        }

        [TestMethod()]
        public void QuotientIntTest()
        {
            Assert.AreEqual(5, Division.Quotient(b, a));
        }
    }
}