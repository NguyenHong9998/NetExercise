using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Exercise12Test
    {
        [TestMethod]
        public void TestSumOfThreeLargestNumbers()
        {
            Assert.AreEqual(new Exercise12().SumOfThreeLargestNumbers(new int[] { 1, 2, 8, 7, 9, 11 }), 28);
            Assert.AreEqual(new Exercise12().SumOfThreeLargestNumbers(new int[] { 1, 200, 8, 7, 65, 11 }), 276);
        }

    }
}
