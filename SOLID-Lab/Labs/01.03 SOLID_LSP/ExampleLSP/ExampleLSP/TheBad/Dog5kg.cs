﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLSP.TheBad
{
    public class Dog5kg : Dog
    {
        public override void Deworm()
        {
            //use CANIDON_type1 (5mg)
        }
        public override void FleaTickControl()
        {
            //use FRONTLINE Basic (5mg)
        }
    }
}
