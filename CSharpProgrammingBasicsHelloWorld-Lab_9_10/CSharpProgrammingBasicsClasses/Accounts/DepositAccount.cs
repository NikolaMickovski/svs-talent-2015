using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    /// <summary>
    /// Klasa za rabota so Deposit
    /// </summary>
    public class DepositAccount : Account, IDepositAccount
    {
        #region PROPERTIES & FIELDS
        public TimePeriod Period { get; private set; }
        public InterestRate Interest { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public ITransactionAccount TransactionAccount { get; private set; }
        #endregion

        //CONSTRUCTOR
        public DepositAccount(string currency, TimePeriod depositPeriod, InterestRate interestRate, DateTime startDate, DateTime endDate, TransactionAccount transactionAccount)
            : base(currency)
        {
            this.Period = depositPeriod;
            this.Interest = interestRate;
            this.StartDate = startDate;
            this.EndDate = endDate;
            TransactionAccount = transactionAccount;//dali e preoprovaren?
        }

        //Default Constructor
        public DepositAccount() { }

        protected override string GenerateAccountNumber()
        {
            return AccountHelper.GenerateAccountNumber(this.GetType(), this.ID);
            //throw new NotImplementedException();
        }
        
    }
}
