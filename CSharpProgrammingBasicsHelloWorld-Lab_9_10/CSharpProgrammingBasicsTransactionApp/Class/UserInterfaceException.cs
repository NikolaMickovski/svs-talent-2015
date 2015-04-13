using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsTransactionApp
{
    public class UserInterfaceException:ApplicationException
    {
        
        public UserInterfaceException(String message, Exception e) : base(message,e) { }
    }
}
