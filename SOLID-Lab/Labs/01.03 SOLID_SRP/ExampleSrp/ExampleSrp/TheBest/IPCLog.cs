using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheBest
{
    public interface IPCLog : ILog
    {
        void ComputerLogChangeState(string stateChangeInfo);
    }
}
