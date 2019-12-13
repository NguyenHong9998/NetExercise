using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Exercise22Test
    {
        [TestMethod]
        public void TestToUpperCase()
        {
            Assert.AreEqual(new Exercise22().ToUpperCase("nguyen thi hong"), "NGUYEN THI HONG");
            Assert.AreEqual(new Exercise22().ToUpperCase(".net_exercise"), ".NET_EXERCISE");
        }
    }
}
