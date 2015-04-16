using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLSP.TheBad
{
    public class Cat : Dog
    {
        /// <summary>
        /// We do not need Deworming cats!
        /// But as Cat is a Child Class of Dog, we MUST implement the virtual method :(
        /// </summary>
        public override void Deworm()
        {
            //?!?
        }
        public override void FleaTickControl()
        {
            //Perform FleaTickControl using different IF-s then Dog's IF-s...
        }
    }
}
