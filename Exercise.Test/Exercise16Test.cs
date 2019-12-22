using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Exercise16Test
    {
        [TestMethod]
        public void TestBinarySearch()
        {
            Assert.AreEqual(new Exercise16().BinarySearch(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 0, 8, 3), 2);
            Assert.AreEqual(new Exercise16().BinarySearch(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 0, 8, 10), -1);
            Assert.AreEqual(new Exercise16().BinarySearch(new int[] { 0 }, 0, 0, 10), -1);
        }
    }
}
