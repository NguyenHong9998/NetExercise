using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Exercise21Test
    {
        [TestMethod]
        public void TestToLowerCase()
        {
            Assert.AreEqual(new Exercise21().ToLowerCase("ABC_abc"), "abc_abc");
            Assert.AreEqual(new Exercise21().ToLowerCase("Nguyen Thi Hong"), "nguyen thi hong");
            Assert.AreEqual(new Exercise21().ToLowerCase(""), "");
        }
    }
}
