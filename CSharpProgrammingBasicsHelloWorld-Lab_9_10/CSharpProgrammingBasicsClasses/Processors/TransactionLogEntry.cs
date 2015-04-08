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
        #region PROPERTIES
        public TransactionType TransactionType { get; private set; }
        public CurrencyAmount Amount { get; private set; }
        public Account Accounts { get; private set; }
        public TransactionStatus Status { get; private set; }
        #endregion

        public TransactionLogEntry()
        {

        }

    }
}
