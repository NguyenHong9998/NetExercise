using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Exercise25Test
    {
        [TestMethod]
        public void TestIsSymmetry()
        {
            Assert.IsTrue(new Exercise25().IsSymmetry("abccba"));
            Assert.IsTrue(new Exercise25().IsSymmetry("123454321"));
            Assert.IsTrue(new Exercise25().IsSymmetry("1"));
            Assert.IsTrue(new Exercise25().IsSymmetry(""));
        }
    }
}
