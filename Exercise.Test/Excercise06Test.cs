using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Excercise06Test
    {
        [TestMethod]
        public void TestSumSequenceOfNumbers()
        {
            Assert.AreEqual(new Excercise06().SumSequenceOfNumbers(4),40);
            Assert.AreEqual(new Excercise06().SumSequenceOfNumbers(6),112);
        }
    }
}
