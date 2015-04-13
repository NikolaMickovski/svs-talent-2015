using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsTransactionApp
{
    public class BusinessLogicException:ApplicationException
    {
        
        public BusinessLogicException(String message, Exception inner) : base(message, inner) { }
    }
}
