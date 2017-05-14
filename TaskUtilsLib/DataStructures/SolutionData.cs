using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskUtilsLib.DataStructures
{
    public struct SolutionData<T>
    {
        public readonly T X2;
        public readonly T X3;

        public readonly T Y2;
        public readonly T Y3;

        public readonly T K2;
        public readonly T K3;

        public SolutionData(T X2, T X3, T Y2, T Y3, T K2, T K3)
        {
            this.X2 = X2;
            this.X3 = X3;

            this.Y2 = Y2;
            this.Y3 = Y3;

            this.K2 = K2;
            this.K3 = K3;
        }
    }
}
