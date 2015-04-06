using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    /// <summary>
    /// Struktura koja cuva informacii za kamatnata stapka za opredelen vremenski moment
    /// </summary>
    public struct InterestRate
    {
        public decimal percent;
        public UnitOfTime Unit;

        public InterestRate(decimal percent, UnitOfTime Unit)
        {
            this.percent = percent;
            this.Unit = Unit;
        }


    }
}
