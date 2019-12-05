using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Exercise01Test
    {
        [TestMethod]
        public void TestGetGCD()
        {
            Assert.AreEqual(new Exercise01().GetGCD(30, 40), 10);
            Assert.AreEqual(new Exercise01().GetGCD(60, 40), 20);
        }

        [TestMethod]
        public void TestGetLCM()
        {
            Assert.AreEqual(new Exercise01().GetLCM(30, 40), 120);
            Assert.AreEqual(new Exercise01().GetLCM(60, 40), 120);
        }
    }
}
