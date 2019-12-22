using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Exercise28Test
    {
        [TestMethod]
        public void TestTranslateString()
        {
            Assert.AreEqual(new Exercise28().TranslateString("ab13c"), "abbbbbbbbbbbbbc");
            Assert.AreEqual(new Exercise28().TranslateString("abc4e6fd"), "abcccceeeeeefd");
            Assert.AreEqual(new Exercise28().TranslateString(""), "");
        }
    }
}
