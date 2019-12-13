using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Exercise20Test
    {
        [TestMethod]
        public void TestCountNumber()
        {
            Assert.AreEqual(new Exercise20().SumSquareNumbers(new List<int> { 3, 6, 9, 12, 14, 4 }), 13);
            Assert.AreEqual(new Exercise20().SumSquareNumbers(new List<int> { 0, 1, 6, 9, 12, 25, 4 }), 39);
        }
    }
}
