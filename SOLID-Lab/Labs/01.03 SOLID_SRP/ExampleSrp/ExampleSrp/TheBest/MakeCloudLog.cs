using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheBest
{
    public class MakeCloudLog : ICloudLog
    {
        public void Inform_Error(string error)
        {
            Console.WriteLine("There was an error locking the car! :" + error + "\n");
        }

        public void Log(string error)
        {
            throw new NotImplementedException();
        }
    }
}
