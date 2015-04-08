using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    /// <summary>
    /// Interface za rabora so Transakcii
    /// </summary>
    public interface ITransactionProcessor
    {
        //properties
        TransactionLogEntry LastTransaction { get; set; }
        int TransactionCount { get; set; }
        int this [TransactionLogEntry key] {get;}


        /// <summary>
        /// Metod koj treba da ja izvrsi celata TRANSAKCIJA
        /// </summary>
        /// <param name="TransactionType">TIP NA TRANSAKCIJA</param>
        /// <param name="Amount">KOLKU (vrednost, valuta)</param>
        /// <param name="AccountFrom">Od koja Smetka</param>
        /// <param name="AccountTo">Kon koja smetka</param>
        /// <returns></returns>
        TransactionStatus ProcessTransaction(TransactionType TransactionType, CurrencyAmount Amount,
            IAccount AccountFrom, IAccount AccountTo);

        TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts);


    }
}
