using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib.MathProviders
{
    public class DoubleMathProvider : MathProvider<double>
    {
        public override double Divide(double a, double b) => a / b;

        public override double Multiply(double a, double b) => a * b;

        public override double Add(double a, double b) => a + b;

        public override double Negate(double a) => -a;

        public override double MultiplyByKoef(int k, double a) => k * a;

        public override double Abs(double a) => Math.Abs(a);

        public override bool GreaterZero(double a) => a > 0;

        public override double Sqrt(double a) => Math.Sqrt(a);
    }
}
