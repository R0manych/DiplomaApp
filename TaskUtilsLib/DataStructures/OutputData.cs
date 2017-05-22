using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskUtilsLib.DataStructures
{
    public struct OutputData<T>
    {
        public readonly T R1;

        public readonly T X;

        public readonly T Y;

        public OutputData(T R1, T X, T Y)
        {
            this.R1 = R1;
            this.X = X;
            this.Y = Y;
        }
    }
}
