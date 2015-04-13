using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsTransactionApp
{
    /// <summary>
    /// Klasa koja treba da gi Wrap-uva greskite vo business logikata
    /// </summary>
    public class BusinessLogicException:ApplicationException
    {        
        public BusinessLogicException(String message, Exception inner) : base(message, inner) { }
    }
}
