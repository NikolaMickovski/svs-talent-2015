﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    /// <summary>
    /// (Apstraktna) Klasa koja ke pretstavuva smetka za opredelen korisnik
    /// </summary>
    public abstract class Account : IAccount
    {
        #region FIELDS & PROPERTIES
        public long ID { get; private set; }
        [FormatRestriction(MaxLength = 16, formatString = "XXXX-XXXX-XXXX-XXXX")]
        public string Number { get; private set; }
        public string Currency { get; private set; }

        //Bidejki ke pravime proverki za opredelen uslov vo SET - metodot,
        //za da ne dojde do STACKOVERFLOW - Exception (t.e. edna
        //f-ja rekurzivno da se povikuva samata sebe), treba da kreirame i edno
        //privatno pole _balance koe ke se postavuva i ke se zema
        //vo SET i GET metodite
        //HINT: Balance is a VALUE TYPE (it is a struct)
        private CurrencyAmount _balance;
        /// <summary>
        /// Property koe e STRUCT
        /// </summary>
        public CurrencyAmount Balance
        {
            get
            {
                return _balance;
            }
            private set
            {
                decimal _old_value = 0;
                //Koga se kreira za prv pat objekt od izvedena klasa od Account
                //default-nite vrednosti za decimal i string se 0 i null
                //znaci, dokolku _balance.amount i _balance.string se 0 i null, soodvetno,
                //togas ne treba da se povika OnBalanceChanged, tuku treba da se postavi
                //vrednost "za prv pat"
                if (!(_balance.amount == 0 && _balance.currency == null))
                {
                    _old_value = _balance.amount;
                    if (_balance.amount != value.amount)
                    {
                        BalanceChangedEventArguments b = new BalanceChangedEventArguments((IAccount)this, value);
                        OnBalanceChanged(this, b);
                    }
                }
                _balance = value;
            }
        }//End Property

        #endregion

        /// <summary>
        /// Constructor with three parametars
        /// </summary>
        /// <param name="m_ID">ID na korisnik</param>
        /// <param name="m_Number">Broj</param>
        /// <param name="Currency">Valuta</param>
        public Account(long ID, string number, string currency)
        {
            //Konstruktorot ke im dava proizvolna suma na smetka od 80.000 do 100.000 denari
            Random rm = new Random();
            //initialize Properties and Fields
            this.ID = ID;
            this.Number = number;
            this.Currency = currency;
            CurrencyAmount _balance = this.Balance;
            _balance.amount = rm.Next(80000, 100000);
            _balance.currency = "MKD";
            this.Balance = _balance;
        }

        /// <summary>
        /// Overloaded Constructor with one parametar only
        /// </summary>
        /// <param name="Currency"></param>
        public Account(string currency)
            : this(Convert.ToInt64(AccountHelper.GenerateAccountID()), "n/a", currency)
        {
            //Klasata Account e apstraktna klasa, pa spored toa od nea ne mozeme da
            //instancirame objekt.
            //Zatoa vo ovoj konstruktor, na mestoto na "n/a", ne moze da stanivme
            //objekt_od_Account.GenerateAccountNumber()
            //Prvicno postavuvame nekoj dummy ACC_Number, a potoa preku set metodot
            //go postavuvame vistinskiot ACC_Number
            this.Number = GenerateAccountNumber();
        }


        //Default Constructor
        public Account()
        {

        }

        #region PUBLIC METHODS
        /// <summary>
        /// metod koj go namaluva balansot na smetkata
        /// </summary>
        /// <param name="amount">Balansot na smetkata treba da se namali za AMOUNT - edinici</param>
        /// <returns></returns>
        public virtual TransactionStatus DebitAmount(CurrencyAmount amount)
        {


            //dokolku vleznata VALUTA e ista so valutata na smetkata, vrati COMPLETED
            if (CompareCurrency(amount))
            {
                CurrencyAmount _balance = this.Balance;
                _balance.amount -= amount.amount;
                this.Balance = _balance;
                return TransactionStatus.Completed;
            }
            //vo sprotiven slucaj vrati FAILED
            else
            {
                throw new CurrencyMismatchException("Originalna valuta: " + this._balance.currency +
                ", a vlezna valuta: " + amount.currency);
            }
        }
        /// <summary>
        /// metod koj zgolemuva balansot na smetkata
        /// </summary>
        /// <param name="amount">Balansot na smetkata treba da se zgolemi za AMOUNT - edinici</param>
        /// <returns></returns>
        public virtual TransactionStatus CreditAmount(CurrencyAmount amount)
        {

            //dokolku vleznata VALUTA e ista so valutata na smetkata, vrati COMPLETED
            if (CompareCurrency(amount))
            {
                CurrencyAmount _balance = this.Balance;
                _balance.amount += amount.amount;
                this.Balance = _balance;
                return TransactionStatus.Completed;
            }

            //vo sprotiven slucaj vrati FAILED
            else
            {
                throw new CurrencyMismatchException("Originalna valuta: " + this._balance.currency +
                ", a vlezna valuta: " + amount.currency);
            }

        }
        #endregion
        #region PRIVATE METHODS
        /// <summary>
        /// Privaten metod (dostapen samo vo ramkite na ovaa klasa) koj sporeduva dali
        /// vlezniot kredit e od ISTA VALUTA so valutata na kreditot na tekovnata smetka
        /// </summary>
        /// <param name="c_amount">Vlezen parametar</param>
        /// <returns></returns>
        private bool CompareCurrency(CurrencyAmount c_amount)
        {
            return (c_amount.currency.Equals(this.Balance.currency));
        }

        #endregion
        #region PROTECTED METHODS
        /// <summary>
        /// Sakame da iskoristime POLY-morfizam
        /// </summary>
        /// <returns></returns>
        protected abstract string GenerateAccountNumber();

        #endregion

        /// <summary>
        /// Implementacija na event-ot
        /// </summary>
        public event EventHandler<BalanceChangedEventArguments> OnBalanceChanged;



    }
}
