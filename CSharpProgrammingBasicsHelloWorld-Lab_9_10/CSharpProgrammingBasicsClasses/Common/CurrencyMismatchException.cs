using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    public class CurrencyMismatchException:ApplicationException
    {
        public string message { get; private set; }
        public CurrencyMismatchException(string s)
        {
            this.message = s;
        }

        
    }
}
