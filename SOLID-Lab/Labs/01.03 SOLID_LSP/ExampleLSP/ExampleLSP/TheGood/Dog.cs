using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLSP.TheGood
{
    public abstract class Dog:IDeworm,IFleaTickControl
    {

        public virtual void Deworm()
        {
           // throw new NotImplementedException();
        }

        public virtual void FleaTickControl()
        {
           // throw new NotImplementedException();
        }
    }
}
