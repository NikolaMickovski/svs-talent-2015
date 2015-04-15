using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheBest
{
    public class Make_PC_Log : IPCLog
    {
        public void ComputerLogChangeState(string stateChangeInfo)
        {
            Console.WriteLine("==============Car changed state:{0}", stateChangeInfo);
        }

        public void Log(string error)
        {
            throw new NotImplementedException();
        }
    }
}
