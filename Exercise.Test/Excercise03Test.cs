using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Exercise03Test
    {
        [TestMethod]
        public void TestDissectNumber()
        {
            Assert.AreEqual(new Excercise03().DissectNumber(12), "2*2*3");
            Assert.AreEqual(new Excercise03().DissectNumber(6), "2*3");
        }
    }
}
