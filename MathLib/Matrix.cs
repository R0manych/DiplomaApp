using MathLib.MathProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class Matrix<T> where T: struct 
    {
        static MathProvider<T> _math;

        public T[,] _array;

        public T[,] Array
        {
            get
            {
                return _array;
            }
        }

        public T this[int i, int j]
        {
            get { return _array[i, j]; }
            set { _array[i, j] = value; }
        }

        public Matrix(int mSize, int nSize)
        {
            _array = new T[mSize, nSize];
        }

        public int GetLength(int dimension) => _array.GetLength(dimension);
        
        public void Transporate()
        {
            int mSize = GetLength(0);
            int nSize = GetLength(1);
            var transporatedArray = new T[nSize, mSize];
            for (int i = 0; i < nSize; i++)
                for (int j = 0; j < mSize; j++)
                {
                    transporatedArray[i, j] = this[j, i];
                }
            System.Array.Copy(transporatedArray, _array, mSize * nSize);
        }

        public void Fill(T[,] matrix)
        {
            _array = new T[matrix.GetLength(0), matrix.GetLength(1)];
            System.Array.Copy(matrix, _array, matrix.Length);
        }

        public static Matrix<T> operator * (Matrix<T> matr1, Matrix<T> matr2)
        {
            if (matr1.GetLength(1) != matr2.GetLength(0))
                throw new ArgumentException("Матрицы не подходят по размеру");
            var resultMatrix = new Matrix<T>(matr1.GetLength(0), matr2.GetLength(1));
            if (typeof(T) == typeof(double))
                _math = new DoubleMathProvider() as MathProvider<T>;
            else if (typeof(T) == typeof(int))
                _math = new IntMathProvider() as MathProvider<T>;
            if (_math == null)
                throw new InvalidOperationException(
                    "Type " + typeof(T).ToString() + " is not supported by Fraction.");
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr2.GetLength(1); j++)
                {
                    var sum = default(T);
                    for (int k = 0; k < matr1.GetLength(1); k++)
                        _math.Subtract(sum, _math.Multiply(matr1[i, k], matr2[k, j]));
                    resultMatrix[i, j] = sum;
                }
            }
            return resultMatrix;
        }





    }
}
