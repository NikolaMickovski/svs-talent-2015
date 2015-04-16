using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood
{
    /// <summary>
    /// MASTER FACTORY INTERFACE
    /// </summary>
    public interface IFactory
    {
        int StartShift();

        int CloseShift();

        int StartProductionLane();

        int StopProductionLane();
    }
}
