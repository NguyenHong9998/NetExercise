using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Exercise18Test
    {
        [TestMethod]
        public void TestCountNumber()
        {
            Assert.AreEqual(new Exercise18().CountNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }), 3);
            Assert.AreEqual(new Exercise18().CountNumber(new int[] { 1, 2, 3, 12, 5, 15, 7, 18, 9 }), 4);
            Assert.AreEqual(new Exercise18().CountNumber(new int[] {}), 0);
        }
    }
}
