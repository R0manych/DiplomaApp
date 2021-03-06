﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib.MathProviders
{
    public abstract class MathProvider<T>
    {
        /// <summary>
        /// Деление
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public abstract T Divide(T a, T b);

        /// <summary>
        /// Умножение
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public abstract T Multiply(T a, T b);

        /// <summary>
        /// Сложение
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public abstract T Add(T a, T b);

        /// <summary>
        /// Отрицание
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public abstract T Negate(T a);

        /// <summary>
        /// Вычитание
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public virtual T Subtract(T a, T b)
        {
            return Add(a, Negate(b));
        }

        /// <summary>
        /// Умножение на коэффициент
        /// </summary>
        /// <param name="k"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public abstract T MultiplyByKoef(int k, T a);

        /// <summary>
        /// Извлечение модуля
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public abstract T Abs(T a);

        /// <summary>
        /// Знак числа
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public abstract bool GreaterZero(T a);

        public abstract T Sqrt(T a);

        public virtual T Sqr(T a)
        {
            return Multiply(a, a);
        }
    }
}
