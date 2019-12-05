using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Exercise02Test
    {
        [TestMethod]
        public void TestSumDigits()
        {
            Assert.AreEqual(new Excercise02().SumDigits(456), 15);
            Assert.AreEqual(new Excercise02().SumDigits(123), 6);
        }
    }
}
