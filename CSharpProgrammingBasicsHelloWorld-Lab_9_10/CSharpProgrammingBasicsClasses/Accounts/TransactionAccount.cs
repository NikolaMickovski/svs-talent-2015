using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    /// <summary>
    /// Klasata TransactionAccount nasleduva od klasata ACCOUNT
    /// </summary>
    public class TransactionAccount : Account, ITransactionAccount
    {
        public CurrencyAmount Limit { get; private set; }

        public TransactionAccount(string currency, decimal limmitAccount)
            : base(currency)
        {
            CurrencyAmount _temp = this.Limit;
            _temp.currency = currency;
            _temp.amount = limmitAccount;
            this.Limit = _temp;
        }
        /// <summary>
        /// Prepokrien metod od osnovnata klasa
        /// </summary>
        /// <returns></returns>
        protected override string GenerateAccountNumber()
        {
           return  AccountHelper.GenerateAccountNumber(this.GetType(), this.ID);
            //throw new NotImplementedException();
        }

    }
}
