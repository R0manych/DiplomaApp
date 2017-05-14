using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib.MathProviders
{
    public abstract class MathProvider<T> where T :struct
    {
        public abstract T Divide(T a, T b);

        public abstract T Multiply(T a, T b);

        public abstract T Add(T a, T b);

        public abstract T Negate(T a);

        public virtual T Subtract(T a, T b)
        {
            return Add(a, Negate(b));
        }
    }
}
