using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations2.Tests
{
    [TestClass()]
    public class SquareRootTests
    {
        private readonly int a = 6;
        private readonly double c = 6.7;
        private readonly double[] e = { 2.2, 5.5, 5.3 };
        private readonly int[] f = { 2, 5, 10 };

        [TestMethod()]
        public void RootTest()
        {
            Assert.AreEqual(36, SquareRoot.Root(a));
        }

        [TestMethod()]
        public void RootDoubleTest()
        {
            Assert.AreEqual(44.89, SquareRoot.Root(c));
        }

        [TestMethod()]
        public void RootDoubleArrayTest()
        {
            double[] y = SquareRoot.Root(e);
            int i = 0;

            foreach (double w in y)
            {
                Assert.AreEqual(SquareRoot.Root(f[i]), w);
                i++;
            }
        }

        [TestMethod()]
        public void RootIntArrayTest()
        {
            int[] d = SquareRoot.Root(f);
            int i = 0;

            foreach (int z in d)
            {
                Assert.AreEqual(SquareRoot.Root(f[i]), z);
                i++;
            }
            
        }
    }
}

namespace Operations2Tests
{
    class SquareRootTests
    {
    }
}
