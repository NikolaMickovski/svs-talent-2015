using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheBest
{
    public interface ICloudLog : ILog
    {
        void Inform_Error(string error);
    }
}
