using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    public static class Make_Cloud_Log
    {
        public static void Inform_Error(string error)
        {
            Console.WriteLine("There was an error locking the car! :"+ error +"\n");
        }
    }
}
