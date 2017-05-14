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
    public class SolutionService<T> : ISolutionService<T>
    {
        public InputData<T> InputData;
        public OutputData<T> OutputData;

        private SolutionData<T> SolutionData;

        public MathLib.MathProviders.MathProvider<T> _mathProvider;

        public const int MATRIX_DIMENSION = 2;
        public const int VECTOR_DIMENSION = 1;

        public SolutionService()
        {
            if (typeof(T) == typeof(double))
                _mathProvider = new DoubleMathProvider() as MathProvider<T>;
            else if (typeof(T) == typeof(int))
                _mathProvider = new IntMathProvider() as MathProvider<T>;
            if (_mathProvider == null)
                throw new InvalidOperationException(
                    "Type " + typeof(T).ToString() + " is not supported by Fraction.");
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
            SolutionData = new SolutionData<T>(x2, x3, y2, y3, k2, k3);
        }



        public void Solve()
        {
            var matrA = new Matrix<T>(MATRIX_DIMENSION, MATRIX_DIMENSION);
            T[,] matrArray = { { SolutionData.X2, SolutionData.Y2 },
                               { SolutionData.X3, SolutionData.Y3 },
            };
        }
    }
}
