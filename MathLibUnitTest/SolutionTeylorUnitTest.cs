using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;
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
        private Logger Logger;
        //private static int NoTest = 112;

        public SolutionTeylorUnitTest()
        {
            var config = new NLog.Config.LoggingConfiguration();

            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "D:\\Logs\\TDOA.txt", Layout = "${message}" };

            config.AddRule(LogLevel.Info, LogLevel.Fatal, logfile);
            LogManager.Configuration = config;

            Logger = LogManager.GetCurrentClassLogger();
        }

        #region Table2

        [TestMethod]
        public void SolutionTest79()
        {
            var input = new InputDataTeylor<double>(
3 ,  5 ,  9,   5 ,  2,   4 ,  0.960827965, 0.443273615
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {79}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest80()
        {
            var input = new InputDataTeylor<double>(
2,   5 ,  8,   5,   3,   4,   0.757359313, 0.757359313
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {80}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest81()
        {
            var input = new InputDataTeylor<double>(
2,   4 ,  8 ,  3  , 2,   4, 0.171572875,   1.294678501
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {81}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest82()
        {
            var input = new InputDataTeylor<double>(
4,   7 ,  11,  7,   3 ,  5,   0.975913888, 0.119535062
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {82}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest83()
        {
            var input = new InputDataTeylor<double>(
5,   8 ,  11,  4,   1,   3,   0.83772234 , 0.443273615

,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {83}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest84()
        {
            var input = new InputDataTeylor<double>(
2 ,  5,   8,   5 ,  2 ,  4,   1.394448725, 0.637089412
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {84}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest85()
        {
            var input = new InputDataTeylor<double>(
2,   5,   8 ,  4,   3,   5,   0.333850535, 1.294678501

,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {85}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest86()
        {
            var input = new InputDataTeylor<double>(
2 ,  5 ,  8,   3,   1,   3,   0.757359313, 0

,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {86}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest87()
        {
            var input = new InputDataTeylor<double>(
4 ,  7,   10,  5,   2,   4,   0.83772234,  0.443273615
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {87}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest88()
        {
            var input = new InputDataTeylor<double>(
4,   7,   10,  7,   4,   6,   1.394448725, 0.637089412
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {88}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        #endregion

        #region Table3
        [TestMethod]
        public void SolutionTest90()
        {
            var input = new InputDataTeylor<double>(
        3, 9, 11, 5, 3, 6, 1.080363027, 1.83772234
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {90}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest91()
        {
            var input = new InputDataTeylor<double>(
5, 9, 4, 6, 5, 9, 0.592359147, 1.369483298
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {91}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest92()
        {
            var input = new InputDataTeylor<double>(
5, 4, 8, 5, 1, 1, 2.00657271, 0.926209683
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {92}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest93()
        {
            var input = new InputDataTeylor<double>(
6, 5, 9, 5, 9, 3, 0.777124151, 1.294678501
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {93}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest94()
        {
            var input = new InputDataTeylor<double>(
3, 4, 9, 7, 1, 4, 1.294678501, 1.294678501
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {94}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest95()
        {
            var input = new InputDataTeylor<double>(
1, 4, 8, 9, 3, 5, 0.394448725, 0.86658468
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {95}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest96()
        {
            var input = new InputDataTeylor<double>(
2, 6, 6, 2, 2, 5, 1.369483298, 0.926209683,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {96}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest97()
        {
            var input = new InputDataTeylor<double>(
9, 9, 5, 9, 3, 3, 1.394448725, 0.51755435,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {97}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest98()
        {
            var input = new InputDataTeylor<double>(
3, 4, 9, 6, 1, 2, 1.309858295, 1.080363027,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {98}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest99()
        {
            var input = new InputDataTeylor<double>(
6, 11, 6, 7, 3, 3, 2.00657271, 1.369483298,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {99}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        #endregion

        #region Table4
        [TestMethod]
        public void SolutionTest101()
        {
            var input = new InputDataTeylor<double>(
        2, 5, 11, 7, 3, 6, 0.123105626, 1.099019514,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {101}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest102()
        {
            var input = new InputDataTeylor<double>(
4, 7, 11, 5, 1, 5, 1, 1
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {102}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest103()
        {
            var input = new InputDataTeylor<double>(
3, 6, 8, 5, 2, 8, 1.887037648, 1.369483298
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {103}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest104()
        {
            var input = new InputDataTeylor<double>(

2, 4, 8, 5, 2, 5, 1, 2
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {104}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest105()
        {
            var input = new InputDataTeylor<double>(
3, 6, 8, 5, 1, 8, 2.123105626, 2.242640687
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {105}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest106()
        {
            var input = new InputDataTeylor<double>(
4, 9, 7, 6, 4, 2, 0.926209683, 0.926209683
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {106}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest107()
        {
            var input = new InputDataTeylor<double>(
5, 7, 10, 7, 3, 5, 0.763932023, 0.926209683,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {107}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest108()
        {
            var input = new InputDataTeylor<double>(
3, 8, 10, 2, 0, 5, 0.86658468, 0.51755435,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {108}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest109()
        {
            var input = new InputDataTeylor<double>(
6, 6, 11, 4, 1, 2, 1.605551275, 1.605551275,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {109}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest110()
        {
            var input = new InputDataTeylor<double>(
1, 2, 7, 4, 0, 2, 0.926209683, 1.887037648
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {110}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        #endregion

        #region Table5
        [TestMethod]
        public void SolutionTest112()
        {
            var input = new InputDataTeylor<double>(
        4, 5, 10, 9, 2, 6, 0.51755435, 0.394448725
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {112}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest113()
        {
            var input = new InputDataTeylor<double>(
4, 8, 6, 6, 9, 2, 2.236067977, 0.763932023
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {113}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest114()
        {
            var input = new InputDataTeylor<double>(
4, 7, 10, 7, 1, 8, 0.394448725, 0.637089412
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {114}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest115()
        {
            var input = new InputDataTeylor<double>(
2, 4, 6, 6, 2, 8, 0.763932023, 1.369483298
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {115}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest116()
        {
            var input = new InputDataTeylor<double>(
4, 6, 11, 9, 3, 9, 0.51755435, 0.86658468

,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {116}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest117()
        {
            var input = new InputDataTeylor<double>(
5, 3, 7, 8, 3, 3, 1.605551275, 1.605551275
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {117}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest118()
        {
            var input = new InputDataTeylor<double>(
4, 2, 11, 8, 1, 6, 0.527864045, 0.913028852

,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {118}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest119()
        {
            var input = new InputDataTeylor<double>(
3, 0, 7, 5, 5, 0, 1.605551275, 3

,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {119}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest120()
        {
            var input = new InputDataTeylor<double>(
4, 5, 10, 7, 0, 6, 0.51755435, 0.86658468
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {120}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        [TestMethod]
        public void SolutionTest121()
        {
            var input = new InputDataTeylor<double>(
4, 0, 3, 6, 6, 0, 1.369483298, 1.763932023
,
                0.05,
                9,
                10);
            var solutionService = new SolutionTaylorService(input);
            var output = solutionService.Solve();
            Logger.Info($"№test = {121}, X = {output.X}, Y = {output.Y}, r1 = {output.R1}");
        }

        #endregion
    }
}
