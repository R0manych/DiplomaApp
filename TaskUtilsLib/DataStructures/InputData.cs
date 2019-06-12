using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskUtilsLib.DataStructures
{
    public class InputData<T>
    {
        public readonly T X1;
        public readonly T X2;
        public readonly T X3;

        public readonly T Y1;
        public readonly T Y2;
        public readonly T Y3;

        public readonly T M2_1;
        public readonly T M3_1;

        public InputData (T X1, T X2, T X3, T Y1, T Y2, T Y3, T M2_1, T M3_1)
        {
            this.X1 = X1;
            this.X2 = X2;
            this.X3 = X3;

            this.Y1 = Y1;
            this.Y2 = Y2;
            this.Y3 = Y3;

            this.M2_1 = M2_1;
            this.M3_1 = M3_1;
        }
    }
}
