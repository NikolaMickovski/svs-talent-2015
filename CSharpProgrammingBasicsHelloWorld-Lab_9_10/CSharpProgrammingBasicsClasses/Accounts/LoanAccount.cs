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
    sealed public class LoanAccount : DepositAccount, ILoanAccount
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

        protected override string GenerateAccountNumber()
        {
            return AccountHelper.GenerateAccountNumber(this.GetType(), this.ID);
        }
    }
}
