using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    public static class ProcessorExtensions
    {
        public static TransactionStatus ChargeProcessingFee(this ITransactionProcessor processor, CurrencyAmount amount, IAccount[] accounts)
        {
            return processor.ProcessGroupTransaction(TransactionType.Debit,amount,accounts);
        }
    }
}
