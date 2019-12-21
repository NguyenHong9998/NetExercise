using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Exercise14Test
    {
        [TestMethod]
        public void TestSumPrime()
        {
            Assert.AreEqual(new Exercise14().SumPrime(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }), 17);
            Assert.AreEqual(new Exercise14().SumPrime(new List<int> { 0, 1, 13, 25, 68, 100 }), 13);
            Assert.AreEqual(new Exercise14().SumPrime(new List<int> { }), 0);
        }
    }
}
