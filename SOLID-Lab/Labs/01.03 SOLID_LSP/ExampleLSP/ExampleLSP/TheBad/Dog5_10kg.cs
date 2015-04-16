using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLSP.TheBad
{
    public class Dog5_10kg : Dog
    {
        public override void Deworm()
        {
            //use CANIDON_type2 (10mg)
        }
        public override void FleaTickControl()
        {
            //use FRONTLINE PLUS (10mg)
        }
    }
}
