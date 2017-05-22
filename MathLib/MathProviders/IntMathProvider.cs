using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib.MathProviders
{
    public class IntMathProvider : MathProvider<int>
    {
        public override int Divide(int a, int b) => a / b;

        public override int Multiply(int a, int b) => a * b;        

        public override int Add(int a, int b) => a + b;        

        public override int Negate(int a) => -a;

        public override int MultiplyByKoef(int k, int a) => k * a;

        public override int Abs(int a) => Math.Abs(a);

        public override bool GreaterZero(int a) => a > 0;

        public override int Sqrt(int a)
        {
            throw new NotImplementedException("Извлечение корня для целых чисел не является замкнутой операцией");
        }
    }
}
