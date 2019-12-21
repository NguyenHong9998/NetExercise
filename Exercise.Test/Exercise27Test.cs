using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Exercise27Test
    {
        [TestMethod]
        public void TestDeleteTheSameCharacters()
        {
            Assert.AreEqual(new Exercise27().DeleteTheSameCharacters("abbbbbbccccd eeffffddbc"), "abcd efdbc");
            Assert.AreEqual(new Exercise27().DeleteTheSameCharacters("11111222223333abdddd"), "123abd");
            Assert.AreEqual(new Exercise27().DeleteTheSameCharacters(""), "");
        }
    }
}
