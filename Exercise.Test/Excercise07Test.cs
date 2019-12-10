using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Excercise07Test
    {
        [TestMethod]
        public void TesFact()
        {
            Assert.AreEqual(new Excercise07().Factorial(1),1);
            Assert.AreEqual(new Excercise07().Factorial(5),120);
            Assert.AreEqual(new Excercise07().Factorial(0), 1);
        }
    }
}
