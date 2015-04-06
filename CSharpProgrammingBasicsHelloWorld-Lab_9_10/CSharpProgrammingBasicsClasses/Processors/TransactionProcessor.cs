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
        /// <summary>
        /// Metod koj treba da go proveri balansot dvete vlezni smetki i da vrati dali soodvetnata transakcija moze da se izvrsi
        /// </summary>
        /// <param name="TransactionType">Tip na transakcija</param>
        /// <param name="AccountFrom">Smetka od koja ke se vrsi transakcija</param>
        /// <param name="Accountto">Smetka koj koja ke se izvrsi transakcijas</param>
        /// <returns></returns>
        private bool CheckAccounts(TransactionType TransactionType,CurrencyAmount Amount, IAccount AccountFrom, IAccount Accountto)
    {        
            switch(TransactionType)
            {
                case TransactionType.Transfer:
                {
                     if(AccountFrom.Balance.amount < Amount.amount) 
                     {
                         return false;
                     }
                     else return true;
                }
                case TransactionType.Debit:
                {
                    if(AccountFrom.Balance.amount < Amount.amount)
                    {
                        return false;
                    }
                    else return true;
                }
                default :
                {
                    return true;
                }
            }
    }
    }
}
