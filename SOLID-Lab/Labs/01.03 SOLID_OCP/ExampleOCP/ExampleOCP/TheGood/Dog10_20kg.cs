using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOCP.TheGood
{
    public class Dog10_20kg : Dog
    {
        public override void Deworm()
        {
            //use CANIDON_type3 (15mg)
        }
        public override void FleaTickControl()
        {
            //use FRONTLINE COMBO (15mg)
        }
    }
}
