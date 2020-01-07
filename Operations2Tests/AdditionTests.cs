using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations2.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        private readonly int a = 6;
        private readonly int b = 3;
        private readonly double c = 6.7;
        private readonly double d = 3.2;
        private readonly double[] e = { 2, 1.1, 5.3, 0.7 };
        private readonly int[] f = { 2, 1, 5, 1, 10 };

        [TestMethod()]
        public void SumTest()
        {
            Assert.AreEqual(9, Addition.Sum(a, b));
        }

        [TestMethod()]
        public void SumDoubleTest()
        {
            Assert.AreEqual(9.9, Addition.Sum(c, d));
        }

        [TestMethod()]
        public void SumDoubleArrayTest()
        {
            Assert.AreEqual(9.1, Addition.Sum(e));
        }

        [TestMethod()]
        public void SumIntArrayTest()
        {
            Assert.AreEqual(19, Addition.Sum(f));
        }
    }
}

namespace Operations2Tests
{
    class AdditionTests
    {
    }
}
