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
    /// 
    [AccountMetadata(AccountDescription = "Ova e Debitna smetka", AccountLimitations = "LIMIT=/")]
    sealed public class LoanAccount : DepositAccount, ILoanAccount
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public LoanAccount() { }
        public LoanAccount(string currency, TimePeriod depositPeriod, InterestRate interestRate, DateTime startDate, DateTime endDate, TransactionAccount transactionAccount)
            : base(currency, depositPeriod, interestRate, startDate, endDate, transactionAccount) { }

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

        //protected override string GenerateAccountNumber()
        //{
        //    return AccountHelper.GenerateAccountNumber(this.GetType(), this.ID);
        //}

        protected override string GenerateAccountNumber()
        {
            return AccountHelper.GenerateAccountNumber <LoanAccount> (this.ID);
        }
    }
}
