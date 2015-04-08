using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    /// <summary>
    /// Klasa koja e odgovorna za rabota so transackciite vrz smetkite
    /// </summary>
    public class TransactionProcessor : ITransactionProcessor
    {
        //field _transactionLog;
        public IList _transactionLog;

        /// <summary>
        /// Parametarless Constructor
        /// </summary>
        public TransactionProcessor ()
        {
            _transactionLog = new ArrayList();
        }

        /// <summary>
        /// Privaten metod koj inicijalizira Objekt od klasata TransactionLogEntry
        /// Vleznite parametri se isti kako od metodot ProcessGroupTransaction,
        /// so dopolnitelen transactionStatus
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="amount"></param>
        /// <param name="accounts"></param>
        /// <param name="transacionStatus"></param>
        private void LogTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts, TransactionStatus transacionStatus){
            TransactionLogEntry tle = new TransactionLogEntry();
        }

        public TransactionStatus ProcessTransaction(TransactionType TransactionType, CurrencyAmount Amount, IAccount AccountFrom, IAccount AccountTo)
        {
            //throw new NotImplementedException();
            switch (TransactionType)
            {
                case TransactionType.Transfer:
                    {
                        TransactionStatus eden = AccountTo.CreditAmount(Amount);
                        TransactionStatus dva = AccountFrom.DebitAmount(Amount);
                        if (eden == dva)
                        {
                            return TransactionStatus.Completed;
                        }

                        else
                        {
                            return TransactionStatus.Failed;
                        }
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

        #region bool CheckAccounts
        /// <summary>
        /// Metod koj treba da go proveri balansot dvete vlezni smetki i da vrati dali soodvetnata transakcija moze da se izvrsi
        /// </summary>
        /// <param name="TransactionType">Tip na transakcija</param>
        /// <param name="AccountFrom">Smetka od koja ke se vrsi transakcija</param>
        /// <param name="Accountto">Smetka koj koja ke se izvrsi transakcijas</param>
        /// <returns></returns>
        /// 
        
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
        #endregion

        /// <summary>
        /// Metod koj ke napravi grupna transakcija za poveke smetki
        /// Treba da se vnimava deka na smetkite moze da se izvrsi samo DEBIT/CREDIT,
        /// no ne i TRANSFER
        /// </summary>
        /// <param name="transactionType">tip na transakcija</param>
        /// <param name="amount">vrednost</param>
        /// <param name="accounts">lista od smetki</param>
        /// <returns></returns>
        public TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts)
        {
            
            if ((transactionType != TransactionType.Debit) && (transactionType != TransactionType.Credit))
            {
                return TransactionStatus.Failed;  
            }
            else
            {
                for (int i = 0; i < accounts.Length; i++)
                {
                    if (accounts[i].Equals(null)) 
                    {
                        continue;
                    }
                    else
                    {
                        TransactionStatus tmp = ProcessTransaction(transactionType, amount, accounts[i], null);
                    } 
                }
                return TransactionStatus.Completed;
            }
        }
    }
}
