using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    public static class ProcessorExtensions
    {
        /// <summary>
        /// Metod koj treba da namali 15 denari od smetka!
        /// </summary>
        /// <param name="processor"></param>
        /// <param name="amount"></param>
        /// <param name="accounts"></param>
        /// <returns></returns>
        public static TransactionStatus ChargeProcessingFee(this ITransactionProcessor processor, CurrencyAmount amount, IEnumerable<IAccount> accounts)
        {
            //upotreba na .ToArray()
            IAccount[] niza_smetki= accounts.ToArray();
            return processor.ProcessGroupTransaction(TransactionType.Debit,amount,niza_smetki);
        }
    }
}
