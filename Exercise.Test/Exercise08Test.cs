using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Exercise08Test
    {
        [TestMethod]
        public void TestPi()
        {
            Assert.IsTrue(new Exercise08().Pi() - Math.PI <= 0.001);
        }
    }
}
