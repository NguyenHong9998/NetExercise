using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Exercise13Test
    {
        [TestMethod]
        public void TestSubtract()
        {
            Assert.AreEqual(new Exercise13().Subtract(new List<int> { 1,2,3,4,5,6,7,8,9}),-5);
            Assert.AreEqual(new Exercise13().Subtract(new List<int> {0,1,13,25,68,100}),129);
            Assert.AreEqual(new Exercise13().Subtract(new List<int> { }), 0);
        }
    }
}
