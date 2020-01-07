using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations2.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        private readonly int a = 6;
        private readonly int b = 3;
        private readonly double c = 10.5;
        private readonly double d = 3.5;
        private readonly double[] e = { 45.05, 1.7, 5.3, 2.5 };
        private readonly int[] f = { 1000, 10, 5, 2};

        [TestMethod()]
        public void OverTest()
        {
            Assert.AreEqual(2, Division.Over(a, b));
        }

        [TestMethod()]
        public void OverDoubleTest()
        {
            Assert.AreEqual(3, Division.Over(c, d));
        }

        [TestMethod()]
        public void OverDoubleArrayTest()
        {
            Assert.AreEqual(2, Division.Over(e));
        }

        [TestMethod()]
        public void OverIntArrayTest()
        {
            Assert.AreEqual(10, Division.Over(f));
        }
    }
}

namespace Operations2Tests
{
    class DivisionTests
    {
    }
}
