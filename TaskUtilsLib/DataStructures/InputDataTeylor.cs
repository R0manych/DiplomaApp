using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskUtilsLib.DataStructures
{
    public class InputDataTeylor<T>
    {
        public readonly T X1;
        public readonly T X2;
        public readonly T X3;

        public readonly T Y1;
        public readonly T Y2;
        public readonly T Y3;

        public readonly T M2_1;
        public readonly T M3_1;

        public readonly T delta;

        public T Xn;
        public T Yn;

        public InputDataTeylor(T X1, T X2, T X3, T Y1, T Y2, T Y3, T M2_1, T M3_1, T delta, T xn, T yn)
        {
            this.X1 = X1;
            this.X2 = X2;
            this.X3 = X3;

            this.Y1 = Y1;
            this.Y2 = Y2;
            this.Y3 = Y3;

            this.M2_1 = M2_1;
            this.M3_1 = M3_1;

            this.delta = delta;

            Xn = xn;
            Yn = yn;
        }

        public InputDataTeylor(InputData<T> inputData, T delta, T xn, T yn)
        {
            X1 = inputData.X1;
            X2 = inputData.X2;
            X3 = inputData.X3;

            Y1 = inputData.Y1;
            Y2 = inputData.Y2;
            Y3 = inputData.Y3;

            M2_1 = inputData.M2_1;
            M3_1 = inputData.M3_1;

            this.delta = delta;

            Xn = xn;
            Yn = yn;
        }
    }
}
