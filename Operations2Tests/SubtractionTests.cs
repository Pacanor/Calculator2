using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations2.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly int a = 6;
        private readonly int b = 3;
        private readonly double c = 6.7;
        private readonly double d = 3.2;
        private readonly double[] e = { 10.5, 2.05, 1.1, 5.3, 1.7 };
        private readonly int[] f = {20, 2, 1, 5, 1, 10 };

        [TestMethod()]
        public void DifTest()
        {
            Assert.AreEqual(3, Subtraction.Dif(a, b));
        }

        [TestMethod()]
        public void DifDoubleTest()
        {
            Assert.AreEqual(3.5, Subtraction.Dif(c, d));
        }

        [TestMethod()]
        public void DifDoubleArrayTest()
        {
            Assert.AreEqual(-20.65, Subtraction.Dif(e));
        }

        [TestMethod()]
        public void DifIntArrayTest()
        {
            Assert.AreEqual(-39, Subtraction.Dif(f));
        }
    }
}

namespace Operations2Tests
{
    class SubtractionTests
    {
    }
}
