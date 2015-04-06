using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    /// <summary>
    /// Struk
    /// </summary>
    public struct TimePeriod
    {
        /// <summary>
        /// dva Fields koi go opisuvaat periodot i "edinicite" vreme
        /// </summary>
        public int period;
        public UnitOfTime unit;

        /// <summary>
        /// Public constructor
        /// </summary>
        /// <param name="period">Period</param>
        /// <param name="unit">Vremenska edinica</param>
        public TimePeriod(int period, UnitOfTime unit)
        {
            this.period = period;
            this.unit = unit;
        }
    }
}
