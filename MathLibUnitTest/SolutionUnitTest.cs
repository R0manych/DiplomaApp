﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class SolutionUnitTest
    {
        [TestMethod]
        public void SolutionTest()
        {
            var input = new InputData<double>(
                3, 3, 5, 3, 1, 1, 1.394448725, 0.51755435);
            var solutionService = new SolutionService(input);
            var output = solutionService.Solve();
            Assert.AreEqual(4, output.X);
            Assert.AreEqual(5, output.Y);
            Assert.AreEqual(3.16, output.R1);
        }
    }
}
