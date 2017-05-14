using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib.MathProviders
{
    public class DoubleMathProvider : MathProvider<double>
    {
        public override double Divide(double a, double b)
        {
            return a / b;
        }

        public override double Multiply(double a, double b)
        {
            return a * b;
        }

        public override double Add(double a, double b)
        {
            return a + b;
        }

        public override double Negate(double a)
        {
            return -a;
        }
    }
}
