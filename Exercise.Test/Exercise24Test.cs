using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Exercise24Test
    {
        [TestMethod]
        public void TestSumOfNumbersInString()
        {
            Assert.AreEqual(new Exercise24().SumOfNumbersInString("abc 123 def 33 mn 3.221"), 380);
            Assert.AreEqual(new Exercise24().SumOfNumbersInString("123Hong3Cute"), 126);
        }
    }
}
