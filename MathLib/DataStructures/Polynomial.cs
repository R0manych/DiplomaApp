using MathLib.MathProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib.DataStructures
{
    public struct Result<T>
    {
        public T R1;
        public T R2;
    }

    public class Polynomial<T> where T : struct
    {
        public T A { get; set; } //коэффициент при X^2

        public T B { get; set; } //коэффициент при X

        public T C { get; set; } //свободный член

        private MathProvider<T> _mathProvider;

        public Result<T> Result = new Result<T>();

        public Polynomial(T A, T B = default(T), T C = default(T))
        {
            this.A = A;
            this.B = B;
            this.C = C;

            if (typeof(T) == typeof(double))
                _mathProvider = new DoubleMathProvider() as MathProvider<T>;
            else if (typeof(T) == typeof(int))
                _mathProvider = new IntMathProvider() as MathProvider<T>;
            if (_mathProvider == null)
                throw new InvalidOperationException(
                    "Type " + typeof(T).ToString() + " is not supported by Fraction.");
        }

        public void Solve()
        {
            if (_mathProvider.GreaterZero(_mathProvider.Abs(A)))
            // квадратное уравнение
            {
                T Discriminant = _mathProvider.Add(_mathProvider.Multiply(B, B), _mathProvider.MultiplyByKoef(-4, _mathProvider.Multiply(A, C)));
                if (_mathProvider.GreaterZero(_mathProvider.Abs(Discriminant)))
                // два решения
                {
                    Result.R1 = _mathProvider.Divide(_mathProvider.Subtract(_mathProvider.Sqrt(Discriminant), B), _mathProvider.MultiplyByKoef(2, A));
                    Result.R2 = _mathProvider.Divide(_mathProvider.Subtract(_mathProvider.Negate(B), _mathProvider.Sqrt(Discriminant)), _mathProvider.MultiplyByKoef(2, A));
                }
                else
                // одно решение
                {
                    Result.R1 = _mathProvider.Divide(_mathProvider.Negate(B), _mathProvider.MultiplyByKoef(2, A));
                }
            }
            else if (_mathProvider.GreaterZero(_mathProvider.Abs(B)))
            // линейное уравнение
            {
                Result.R1 = _mathProvider.Divide(_mathProvider.Negate(C), B);
            }
            else
            // совсем вырожденный случай
            {
                if (_mathProvider.GreaterZero(_mathProvider.Abs(B)))
                    throw new ArgumentException("Отсутсвуют коэффициенты при неизвестных");
            }
        }
    }
}
