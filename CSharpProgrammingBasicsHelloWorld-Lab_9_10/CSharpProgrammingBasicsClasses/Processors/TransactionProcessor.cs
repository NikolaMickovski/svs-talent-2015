﻿using System;
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
        private static TransactionProcessor tp;

        private IList<TransactionLogEntry> _transactionLog;

        public IList<TransactionLogEntry> TransactionLog
        {
            get { return _transactionLog; }
            set { _transactionLog = value; }
        }

        /// <summary>
        /// Parametarless Constructor
        /// </summary>
        private TransactionProcessor()
        {
            _transactionLog = new List<TransactionLogEntry>();
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
        private TransactionLogEntry LogTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount account, TransactionStatus transacionStatus)
        {
            TransactionLogEntry tle = new TransactionLogEntry(transactionType, amount, account, transacionStatus);
            return tle;
        }

        /// <summary>
        /// Metod koj e odgovoren za EDNA TRANSAKCIJA
        /// 1) NA EDNA SMETKA, 2) OD EDNA SMETKA KON DRUGA
        /// </summary>
        /// <param name="TransactionType">Tip na transakcija</param>
        /// <param name="Amount">Amount & Currency</param>
        /// <param name="AccountFrom">Od smetka</param>
        /// <param name="AccountTo">Na smetka</param>
        /// <returns></returns>
        public TransactionStatus ProcessTransaction(TransactionType TransactionType, CurrencyAmount Amount, IAccount AccountFrom, IAccount AccountTo)
        {
            switch (TransactionType)
            {
                case TransactionType.Transfer:
                    {
                        TransactionStatus dva = AccountFrom.DebitAmount(Amount);
                        TransactionStatus eden = AccountTo.CreditAmount(Amount);

                        if (eden == dva)
                        {
                            TransactionLog.Add(LogTransaction(TransactionType, Amount, AccountFrom, TransactionStatus.Completed));
                            return TransactionStatus.Completed;
                        }
                        else
                        {
                            return TransactionStatus.Failed;
                        }
                    }
                case TransactionType.Debit:
                    {
                        //Prvo treba da izvrsime DEBIT, ako ne frli greska, treba da se logira transakcijata
                        TransactionStatus pom = AccountFrom.DebitAmount(Amount);
                        
                        //Tuka ke proverime dali Debit Transakcijata izvrsila namaluvanje
                        //na saldoto na smetkata, a pritoa saldoto doslo do 0 ili pod 0
                        //vo toj slucaj, treba da se "frli" Limit Reached Exception
                        if (AccountFrom.Balance.amount <= 0)
                        {
                            throw new LimitReached("LimitReached\n");
                        }


                        if (AccountFrom.GetType() == typeof(LoanAccount) || AccountFrom.GetType() == typeof(DepositAccount))
                        {
                            Console.WriteLine("Charged 15,00 MKD\n");
                            //Da se odzemat 15.00 MKD od smetkata
                            TransactionStatus pom1 = AccountFrom.DebitAmount(new CurrencyAmount(15, Amount.currency));
                        }
                        TransactionLog.Add(LogTransaction(TransactionType, Amount, AccountFrom, TransactionStatus.Completed));
                        CallExternalLogger(AccountFrom, TransactionType, Amount);
                        return pom;
                    }
                case TransactionType.Credit:
                    {
                        //Prvo treba da izvrsime CREDIT, ako ne frli greska, treba da se logira transakcijata
                        TransactionStatus pom = AccountFrom.CreditAmount(Amount);
                        TransactionLog.Add(LogTransaction(TransactionType, Amount, AccountFrom, TransactionStatus.Completed));
                        CallExternalLogger(AccountFrom, TransactionType, Amount);
                        return pom;
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

        private bool CheckAccounts(TransactionType TransactionType, CurrencyAmount Amount, IAccount AccountFrom, IAccount Accountto)
        {
            switch (TransactionType)
            {
                case TransactionType.Transfer:
                    {
                        if (AccountFrom.Balance.amount < Amount.amount)
                        {
                            return false;
                        }
                        else return true;
                    }
                case TransactionType.Debit:
                    {
                        if (AccountFrom.Balance.amount < Amount.amount)
                        {
                            return false;
                        }
                        else return true;
                    }
                default:
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


        /// <summary>
        /// Implementiranje na Property-to TransactionCount
        /// </summary>
        /// <returns>Overall number of transactions</returns> 
        public int TransactionCount
        {
            get
            {
                return TransactionLog.Count;
                //throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Implementiranje na Property-to TransactionLogEntry
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public TransactionLogEntry this[int key]
        {
            get
            {
                if (TransactionLog.Count <= key)
                {
                    return null;
                }
                else
                {
                    return this.TransactionLog[key];
                }
            }
        }

        /// <summary>
        /// Implementiranje na Property-to LastTransaction
        /// </summary>   
        public TransactionLogEntry LastTransaction
        {
            get
            {
                if (TransactionLog.Count == 0) return null;
                else return TransactionLog[TransactionLog.Count - 1];
                //throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        static TransactionProcessor()
        {
            tp = new TransactionProcessor();
            tp.ExternalLogger += AccountHelper.NotifyNationalBank;
            tp.ExternalLogger += AccountHelper.LogTransaction;
        }
        public static TransactionProcessor GetTransactionProcessor()
        {
            // ITransactionProcessor tp = new TransactionProcessor();
            return (TransactionProcessor)tp;
        }

        private void CallExternalLogger(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
            ExternalLogger(account, transactionType, amount);
        }

        public TransactionLogger ExternalLogger { get; set; }       


        //public TransactionStatus ChargeProcessingFee(CurrencyAmount amount, IAccount[] accounts)
        //{
        //    return ProcessGroupTransaction(TransactionType.Debit, amount, accounts);
        //}
    }
}
