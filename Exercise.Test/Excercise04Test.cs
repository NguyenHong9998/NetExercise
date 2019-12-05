using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Excercise04Test
    {
        [TestMethod]
        public void TestFibonaci()
        {
            Assert.AreEqual(new Excercise04().PrintFibonaci(9), "1 1 2 3 5 8");
            Assert.AreEqual(new Excercise04().PrintFibonaci(20), "1 1 2 3 5 8 13");
        }
    }
}
