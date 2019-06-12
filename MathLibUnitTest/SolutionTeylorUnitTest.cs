using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskUtilsLib.DataStructures;
using TaskUtilsLib.Services;

namespace MathLibUnitTest
{
    [TestClass]
    public class SolutionTeylorUnitTest
    {
        [TestMethod]
        public void SolutionTest()
        {
            var input = new InputDataTeylor<double>(
                4, 8, 6, 6, 9, 2, 2.23, 0.76, 0.05, 9, 10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
        }
    }
}
