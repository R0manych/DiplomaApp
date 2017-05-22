using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskUtilsLib.DataStructures;

namespace TaskUtilsLib.Services.Interfaces
{
    public interface ISolutionService<T>
    {
       OutputData<double> Solve();        
    }
}
