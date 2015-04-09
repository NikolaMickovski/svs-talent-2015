using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    public delegate void TransactionLogger(IAccount account, TransactionType transactionType, CurrencyAmount amount);
    class Delegates
    {

    }
}
