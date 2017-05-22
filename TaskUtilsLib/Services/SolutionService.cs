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
    public class SolutionService : ISolutionService<double>
    {
        public InputData<double> InputData;
        public OutputData<double> OutputData;

        private SolutionData<double> SolutionData;

        private MathLib.MathProviders.MathProvider<double> _mathProvider = new DoubleMathProvider();

        public const int MATRIX_DIMENSION = 2;
        public const int VECTOR_DIMENSION = 1;

        public SolutionService()
        {            
            SetData();
        }

        private void SetData()
        {
            var x2 = _mathProvider.Subtract(InputData.X2, InputData.X1);
            var x3 = _mathProvider.Subtract(InputData.X3, InputData.X1);
            var y2 = _mathProvider.Subtract(InputData.Y2, InputData.Y1);
            var y3 = _mathProvider.Subtract(InputData.Y2, InputData.Y1);
            var k2 = _mathProvider.Add(_mathProvider.Multiply(x2, x2), _mathProvider.Multiply(y2, y2));
            var k3 = _mathProvider.Add(_mathProvider.Multiply(x3, x3), _mathProvider.Multiply(y3, y3));
            SolutionData = new SolutionData<double>(x2, x3, y2, y3, k2, k3);
        }


        public void Solve()
        {
            var matrA = new Matrix<double>(MATRIX_DIMENSION, MATRIX_DIMENSION);
            double[,] arrayA = { { SolutionData.X2, SolutionData.Y2 },
                           { SolutionData.X3, SolutionData.Y3 },
            };
            matrA.Fill(arrayA);

            var matrC = new Matrix<double>(MATRIX_DIMENSION, VECTOR_DIMENSION);
            double[,] arrayC = { { _mathProvider.Subtract(SolutionData.K2, _mathProvider.Multiply(InputData.M2_1, InputData.M2_1)) },
                           { _mathProvider.Subtract(SolutionData.K3, _mathProvider.Multiply(InputData.M3_1, InputData.M3_1)) }
            };
            matrC.Fill(arrayC);

            var matrD = new Matrix<double>(MATRIX_DIMENSION, VECTOR_DIMENSION);
            double[,] arrayD = { { _mathProvider.Negate(InputData.M2_1) },
                           { _mathProvider.Negate(InputData.M3_1) }
            };
            var transporatedMatrA = (Matrix<double>)matrA.Clone();
            transporatedMatrA.Transporate();
            var tempMatr = (Matrix<double>.Inverse(transporatedMatrA * matrA) * transporatedMatrA);

            var firstKoefMatr = tempMatr * matrC;
            var secKoefMatr = tempMatr * matrD;

            var koefA = firstKoefMatr.GetRow(0)[0];
            var koefB = secKoefMatr.GetRow(0)[0];
            var koefC = firstKoefMatr.GetRow(1)[0];
            var koefD = secKoefMatr.GetRow(1)[0];

            var polynomial = new Polynomial<double>(_mathProvider.Add(_mathProvider.Sqr(koefB), _mathProvider.Sqr(koefD)) - 1,
                _mathProvider.Add(_mathProvider.Multiply(koefA, koefB), _mathProvider.Multiply(koefC, koefD)),
                _mathProvider.Add(_mathProvider.Sqr(koefA), _mathProvider.Sqr(koefC)));
            polynomial.Solve();

            var r1 = polynomial.Result.R1;
            OutputData = new OutputData<double>(r1, _mathProvider.Subtract(_mathProvider.Add(koefA, _mathProvider.Multiply(koefB, r1)), InputData.X1), _mathProvider.Subtract(_mathProvider.Add(koefC, _mathProvider.Multiply(koefD, r1)), InputData.Y1));
        }
    }
}
