using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    public static class Make_PC_Log
    {
        public static void ComputerLogChangeState(string stateChangeInfo)
        {
            Console.WriteLine("==============Car changed state:{0}", stateChangeInfo);
        }        
    }
}
