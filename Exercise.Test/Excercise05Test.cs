using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Excercise05Test
    {
        [TestMethod]
        public void TestSolvingQuadraticEquation()
        {
            Assert.AreEqual(new Excercise05().SolvingQuadraticEquation(1,1,1), "Phuong trinh VN");
            Assert.AreEqual(new Excercise05().SolvingQuadraticEquation(0,1,1),"Phuong trinh co nghiem x= -1");
        }
    }
}
