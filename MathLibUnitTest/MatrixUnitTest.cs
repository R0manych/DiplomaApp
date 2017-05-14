using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLib;

namespace MathLibUnitTest
{
    [TestClass]
    public class MatrixUnitTest
    {
        [TestMethod]
        public void TransporateTest()
        {
            var matrix = new Matrix<double>(2, 2);
            double[,] testArray = { { 1, 1 }, { 2, 2 } };
            matrix.Fill(testArray);
            matrix.Transporate();
            double[,] resultArray = { { 1, 2 }, { 1, 2 } };
            for (var i = 0; i < resultArray.GetLength(0); i++)
            {
                for (var j = 0; j < resultArray.GetLength(1); j++)
                {
                    Assert.AreEqual(resultArray[i, j], matrix.Array[i, j]);
                }
            }
        }

        [TestMethod]
        public void MultiplicateTest()
        {
            var matrix1 = new Matrix<double>(2, 2);
            double[,] testArray1 = { { 1, 2 }, { 3, 2 } };
            matrix1.Fill(testArray1);

            var matrix2 = new Matrix<double>(2, 2);
            double [,] testArray2 = { { 1, 3}, { 2, 3} };
            matrix2.Fill(testArray2);

            var resultMatrix = matrix1 * matrix2;

            double[,] resultArray = { { 5, 9 }, { 7, 15 } };
            for (var i = 0; i < resultArray.GetLength(0); i++)
            {
                for (var j = 0; j < resultArray.GetLength(1); j++)
                {
                    Assert.AreEqual(resultArray[i, j], resultMatrix.Array[i, j]);
                }
            }
        }
    }
}
