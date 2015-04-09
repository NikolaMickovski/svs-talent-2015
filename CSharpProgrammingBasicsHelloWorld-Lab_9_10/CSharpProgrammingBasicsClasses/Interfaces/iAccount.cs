using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    /// <summary>
    /// Interface za glavnata smetka
    /// </summary>
    public interface IAccount
    {
        long ID {get;}
        string Number { get; }
        string Currency { get; }
        CurrencyAmount Balance { get; }

        TransactionStatus CreditAmount(CurrencyAmount amount);
        TransactionStatus DebitAmount(CurrencyAmount amount);

        event BalanceChanged OnBalanceChanged;
    }
}
