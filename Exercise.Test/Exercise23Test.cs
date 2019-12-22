using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Exercise23Test
    {
        [TestMethod]
        public void TestReverse()
        {
            Assert.AreEqual(new Exercise23().Reverse("123456"), "654321");
            Assert.AreEqual(new Exercise23().Reverse("qwertyuiop"), "poiuytrewq");
            Assert.AreEqual(new Exercise23().Reverse(""), "");
        }
    }
}
