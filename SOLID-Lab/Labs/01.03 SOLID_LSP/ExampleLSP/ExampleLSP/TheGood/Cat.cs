using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLSP.TheGood
{
    public class Cat : IFleaTickControl
    {
        public void FleaTickControl()
        {
            //Perform FleaTickControl using different IF-s then Dog's IF-s
        }
    }
}
