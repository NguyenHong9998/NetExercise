using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Exercise11Test
    {
        [TestMethod]
        public void TestDuplicateElement()
        {
            Assert.AreEqual(new Exercise11().DuplicateElement(new int[6] { 1, 2, 3, 4, 5, 6 }), "");
            Assert.AreEqual(new Exercise11().DuplicateElement(new int[6] { 2, 2, 3, 4, 5, 5 }), "2 5");
        }
    }
}
