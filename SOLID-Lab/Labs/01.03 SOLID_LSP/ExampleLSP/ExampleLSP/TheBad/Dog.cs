using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLSP.TheBad
{
    public abstract class Dog
    {
        public virtual void Deworm() { }
        public virtual void FleaTickControl() { }
    }
}
