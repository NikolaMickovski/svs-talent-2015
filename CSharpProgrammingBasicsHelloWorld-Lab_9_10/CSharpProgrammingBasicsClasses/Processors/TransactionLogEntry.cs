using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    /// <summary>
    /// Klasa koja ke gi logira (zapisuva) greskite koi moze da nastanat pri izvrsuvanje na transakciite
    /// </summary>
    public class TransactionLogEntry
    {
       // private IAccount account;
      //  private TransactionStatus transacionStatus;

        #region PROPERTIES
        public TransactionType TransactionType { get; set; }
        public CurrencyAmount Amount { get; set; }
        public Account Accounts { get; set; }
        public TransactionStatus Status { get; set; }
        #endregion

        public TransactionLogEntry()
        {
           // TransactionType = TransactionType.Transfer;
        }

        public TransactionLogEntry(CSharpProgrammingBasicsClasses.TransactionType transactionType, CurrencyAmount amount, IAccount account, TransactionStatus transacionStatus)
        {
            // TODO: Complete member initialization
            this.TransactionType = transactionType;
            this.Amount = amount;
            this.Accounts = (Account)account;
            this.Status = transacionStatus;
        }

    }
}
