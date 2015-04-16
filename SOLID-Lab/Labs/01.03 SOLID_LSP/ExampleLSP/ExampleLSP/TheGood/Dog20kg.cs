using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLSP.TheGood
{
    public class Dog20kg : Dog
    {
        public override void Deworm()
        {
            //use CANIDON_type4 (20mg)
        }
        public override void FleaTickControl()
        {
            //use FRONTLINE MAX (20mg) 
        }
    }
}
