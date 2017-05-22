using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLib.DataStructures;

namespace MathLibUnitTest
{
    [TestClass]
    public class PolynomialUnitTest
    {
        [TestMethod]
        public void TwoAnswersTest()
        {
            var polynomial = new Polynomial<double>(1, 1, -6);
            polynomial.Solve();
            Assert.AreEqual(2, polynomial.Result.R1);
            Assert.AreEqual(-3, polynomial.Result.R2);
        }

        [TestMethod]
        public void OneAnswerTest()
        {
            var polynomial = new Polynomial<double>(1, 2, 1);
            polynomial.Solve();
            Assert.AreEqual(-1, polynomial.Result.R1);
        }
    }
}
