using MathLib.DataStructures;
using MathLib.MathProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskUtilsLib.DataStructures;
using TaskUtilsLib.Services.Interfaces;

namespace TaskUtilsLib.Services
{
    public class SolutionTaylorService : ISolutionService<double>
    {
        public InputDataTeylor<double> InputData;

        private MathProvider<double> _mathProvider = new DoubleMathProvider();

        private Matrix<double> matrQ;
        private Matrix<double> matrA;
        private Matrix<double> matrD;

        public SolutionTaylorService(InputDataTeylor<double> InputData)
        {
            this.InputData = InputData;
            SetData();
        }

        private void SetData()
        {
            SetMatrQ();
            SetMatrA();
            SetMatrD();
        }

        private void SetMatrQ()
        {
            matrQ = new Matrix<double>(2, 2);
            double[,] arrayQ = {
                { _mathProvider.Multiply(InputData.delta, InputData.delta), 0 },
                {0,  _mathProvider.Multiply(InputData.delta, InputData.delta) }
            };
            matrQ.Fill(arrayQ);
        }

        private void SetMatrA()
        {
            matrA = new Matrix<double>(2, 2);
            double r1 = FunctionR(InputData.Xn, InputData.X1, InputData.Yn, InputData.Y1);
            double r2 = r1 + InputData.M2_1;
            double r3 = r1 + InputData.M3_1;
            double[,] arrayA = new double[2, 2]
            {
                {FunctionA(InputData.Xn, InputData.X1, InputData.X2, r1, r2),
                 FunctionA(InputData.Xn, InputData.Y1, InputData.Y2, r1, r2)},
                {FunctionA(InputData.Xn, InputData.X1, InputData.X3, r1, r3),
                 FunctionA(InputData.Xn, InputData.Y1, InputData.Y3, r1, r3)}
            };
            matrA.Fill(arrayA);
        }

        private void SetMatrD()
        {
            matrD = new Matrix<double>(2, 1);
            double[,] arrayD = new double[2, 1]
            {
                { InputData.M2_1 - FunctionF(InputData.Xn, InputData.X1, InputData.X2, InputData.Yn, InputData.Y1, InputData.Y2) },
                { InputData.M3_1 - FunctionF(InputData.Xn, InputData.X2, InputData.X3, InputData.Yn, InputData.Y2, InputData.Y3) }
            };
            matrD.Fill(arrayD);
        }

        private double FunctionF(double xn, double x1, double x2, double yn, double y1, double y2) =>
            Math.Sqrt((Math.Pow(xn - x2, 2) + Math.Pow(yn - y2, 2)))
                - Math.Sqrt((Math.Pow(xn - x1, 2) + Math.Pow(yn - y1, 2)));

        private double FunctionA(double xn, double x1, double x2, double r1, double r2) =>
            (x1 - xn) / r1 - (x2 - xn) / r2;

        private double FunctionR(double xn, double x1, double yn, double y1) =>
            Math.Sqrt(Math.Pow(xn - x1, 2) + Math.Pow(yn - y1, 2));

        public OutputData<double> Solve()
        {
            var resultDelta = new Matrix<double>(2, 1);
            do
            {
                resultDelta = GetResultDelta();
                InputData.Xn += resultDelta.GetRow(0)[0];
                InputData.Yn += resultDelta.GetRow(1)[0];
                SetData();
            }
            while (Math.Abs(resultDelta.GetRow(0)[0]) > InputData.delta || Math.Abs(resultDelta.GetRow(1)[0]) > InputData.delta);

            return new OutputData<double>(FunctionR(InputData.Xn, InputData.X1, InputData.Yn, InputData.Y1), InputData.Xn, InputData.Yn);
        }

        private Matrix<double> GetResultDelta()
        {
            //Копиривание матрицы А и транспонирование ее
            var transporatedMatrA = (Matrix<double>)matrA.Clone();
            transporatedMatrA.Transporate();

            var inversedMatrQ = (Matrix<double>.Inverse(matrQ));

            var firstMultiplicationMatr = transporatedMatrA * inversedMatrQ * matrA;
            var inversedFirstMultiplicationMatr = (Matrix<double>.Inverse(firstMultiplicationMatr));

            return inversedFirstMultiplicationMatr * transporatedMatrA * inversedMatrQ * matrD;
        }
    }
}
