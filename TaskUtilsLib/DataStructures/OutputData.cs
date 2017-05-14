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

        public OutputData(T R1)
        {
            this.R1 = R1;
        }
    }
}
