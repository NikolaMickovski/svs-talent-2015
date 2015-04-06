using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    public class TransactionProcessor : ITransactionProcessor
    {
        public TransactionStatus ProcessTransaction(TransactionType TransactionType, CurrencyAmount Amount, IAccount AccountFrom, IAccount AccountTo)
        {
            //throw new NotImplementedException();
            switch (TransactionType)
            {
                case TransactionType.Transfer:
                    {
                        TransactionStatus eden = AccountTo.CreditAmount(Amount);
                        TransactionStatus dva = AccountFrom.DebitAmount(Amount);
                        if (eden == dva) return TransactionStatus.Completed;
                        else return TransactionStatus.Failed;
                    }
                case TransactionType.Debit:
                    {
                        return AccountFrom.DebitAmount(Amount);
                    }
                case TransactionType.Credit:
                    {
                        return AccountFrom.CreditAmount(Amount);
                    }
                default: return TransactionStatus.None;
            }
        }
    }
}
