using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskUtilsLib.DataReaders.Input
{
    public abstract class InputReader<T>
    {
        public abstract InputReader<T> ReadData();
    }
}
