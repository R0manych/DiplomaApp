﻿using MathLib.MathProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib.DataStructures
{
    public class Matrix<T> : ICloneable
    {
        static MathProvider<T> _math;

        private T[,] _array;

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
            if (typeof(T) == typeof(double))
                _math = new DoubleMathProvider() as MathProvider<T>;
            else if (typeof(T) == typeof(int))
                _math = new IntMathProvider() as MathProvider<T>;
            if (_math == null)
                throw new InvalidOperationException(
                    "Type " + typeof(T).ToString() + " is not supported by Fraction.");
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
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr2.GetLength(1); j++)
                {
                    var sum = default(T);
                    for (int k = 0; k < matr1.GetLength(1); k++)
                        sum = _math.Add(sum, _math.Multiply(matr1[i, k], matr2[k, j]));
                    resultMatrix[i, j] = sum;
                }
            }
            return resultMatrix;
        }

        /// <summary>
        /// Умножение матрицы на значение value
        /// </summary>
        /// <param name="value"></param>
        public void MultiplyByValue(T value)
        {
            for (var i = 0; i < GetLength(0); i++)
            {
                for (var j = 0; j < GetLength(1); j++)
                {
                    _array[i, j] = _math.Multiply(_array[i, j], value);
                }
            }
        }

        /// <summary>
        /// Умножение матрицы на значение value
        /// </summary>
        /// <param name="value"></param>
        public void MultiplyByValue(int value)
        {
            for (var i = 0; i < GetLength(0); i++)
            {
                for (var j = 0; j < GetLength(1); j++)
                {
                    _array[i, j] = _math.MultiplyByKoef(value, _array[i, j]);
                }
            }
        }

        /// <summary>
        /// Возвращает матрицу обратную данной. Обратная матрица существует только для квадратных, невырожденных, матриц. round - количество цифр после запятой в обратной матрице.
        /// </summary>
        public static Matrix<double> Inverse(Matrix<double> matr)
        {
            if (matr.GetLength(0) != matr.GetLength(1))
                throw new ArgumentException("Обратная матрица существует только для квадратных, невырожденных, матриц.");
            Matrix<double> matrix = new Matrix<double>(matr.GetLength(0), matr.GetLength(1)); //Делаем копию исходной матрицы
            double determinant = matr.Determinant; //Находим детерминант

            if (determinant == 0) return matr; //Если определитель == 0 - матрица вырожденная

            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int t = 0; t < matr.GetLength(1); t++)
                {

                    Matrix<double> tmp = matr.Exclude(i, t);  //получаем матрицу без строки i и столбца t
                                                              //(1 / determinant) * Determinant(tmp) - формула поределения элемента обратной матрицы
                    
                    matrix[t, i] = Math.Round(Math.Pow(-1, i + t) * ((1 / determinant) * tmp.Determinant), 4);
                }
            }
            return matrix;
        }

        #region Determinant (вычисление определителя матрицы по Гауссу)

        /// <summary>
        /// Вычисление определителя матрицы
        /// </summary>
        public double Determinant
        {
            get
            {
                if (GetLength(0) == 1)
                {
                    return Convert.ToDouble(_array[0, 0]);
                }
                if (GetLength(0) == 2)
                {
                    return Determinant2();
                }
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Вычисление определителя для матрицы 2х2
        /// </summary>
        /// <returns></returns>
        private double Determinant2()
        {
            return Convert.ToDouble(_math.Subtract(_math.Multiply(_array[0, 0], _array[1,1]), _math.Multiply(_array[1, 0], _array[0, 1])));
        }
        #endregion

        /// <summary>
        /// Возвращает матрицу без указанных строки и столбца. Исходная матрица не изменяется.
        /// </summary>
        public Matrix<T> Exclude(int row, int column)
        {
            if (row > GetLength(0) || column > GetLength(1)) throw new IndexOutOfRangeException("Строка или столбец не принадлежат матрице.");
            Matrix<T> resultMatrix = new Matrix<T>(GetLength(0) - 1, GetLength(1) - 1);
            int offsetX = 0;
            for (int i = 0; i < GetLength(0); i++)
            {
                int offsetY = 0;
                if (i == row) { offsetX++; continue; }
                for (int t = 0; t < GetLength(1); t++)
                {
                    if (t == column)
                        { offsetY++; continue; }
                    resultMatrix[i - offsetX, t - offsetY] = this[i, t];
                }
            }
            return resultMatrix;
        }

        public object Clone()
        {
            var cloneMatr = new Matrix<T>(GetLength(0), GetLength(1));
            cloneMatr.Fill(_array);
            return cloneMatr;
        }       

        public T[] GetRow(int index)
        {
            var row = new T[GetLength(0)];
            for (var i = 0; i < GetLength(1); i++)
            {
                row[i] = _array[index, i];
            }
            return row;
        }
    }
}
