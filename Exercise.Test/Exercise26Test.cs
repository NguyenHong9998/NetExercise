using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Exercise26Test
    {
        [TestMethod]
        public void TestCompactString()
        {
            Assert.AreEqual(new Exercise26().CompactString("abbbbbbbbbbbbbc"), "ab13c");
            Assert.AreEqual(new Exercise26().CompactString("abcccceeeeeefd"), "abc4e6fd");
            Assert.AreEqual(new Exercise26().CompactString(""), "");
        }
    }
}
