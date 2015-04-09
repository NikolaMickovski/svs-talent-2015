using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    /// <summary>
    /// Delegat koj se koristi vo prviot del od lab. vezba 13
    /// </summary>
    /// <param name="account"></param>
    /// <param name="transactionType"></param>
    /// <param name="amount"></param>
    public delegate void TransactionLogger(IAccount account, TransactionType transactionType, CurrencyAmount amount);

    /// <summary>
    /// Delegat koj se koristi vo vtoriot del od lab. vezba 13
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="eventArgs"></param>
    public delegate void BalanceChanged (Object sender, BalanceChangedEventArguments eventArgs);


    public class Delegates
    {

    }
    public class BalanceChangedEventArguments : System.EventArgs
    {
        public IAccount Account { get; private set; }
        public CurrencyAmount Change { get; private set; }

        //Constructor
        public BalanceChangedEventArguments(IAccount Account, CurrencyAmount Change)
        {
            this.Account = Account;
            this.Change = Change;
        }

       
    }
}
