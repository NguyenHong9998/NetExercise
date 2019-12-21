using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Exercise29Test
    {
        [TestMethod]
        public void TestisBarcodeEAN()
        {
            Assert.IsTrue(new Exercise29().isBarcodeEAN("8938505974194"));
        }
    }
}
