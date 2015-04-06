using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    /// <summary>
    /// Klasa za rabota so KREDITI
    /// </summary>
    public class LoanAccount : DepositAccount
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public LoanAccount() { }

        #region PUBLIC METHODS
        public override TransactionStatus DebitAmount(CurrencyAmount amount)
        {
            return base.CreditAmount(amount);
        }

        public override TransactionStatus CreditAmount(CurrencyAmount amount)
        {
            return base.DebitAmount(amount);
        }


        #endregion
    }
}
