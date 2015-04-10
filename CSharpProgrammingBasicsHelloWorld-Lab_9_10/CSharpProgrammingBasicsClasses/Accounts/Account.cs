using System;
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
        public long ID { get; private set; }
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
                if(!(_balance.amount == 0 && _balance.currency == null))
                {
                    _old_value = _balance.amount;
                    if (_balance.amount != value.amount)
                    {
                        //if (this.Equals(null)) { Console.Write("Null e Objektot\n"); }
                        //if (value.Equals(null)) { Console.Write("Null e Value na Account\n"); }
                        BalanceChangedEventArguments b = new BalanceChangedEventArguments((IAccount)this, value);
                        //if (b.Equals(null)) { Console.Write("Null e B -object-ot\n"); }
                        OnBalanceChanged(this, b);
                        //this.OnBalanceChanged((IAccount)this, new BalanceChangedEventArguments((IAccount)this, value));
                    }
                }
                _balance = value;
                //this._balance = value;
               // CurrencyAmount _balance = this.Balance;
                
                         
                
            }
            //{
            //    CurrencyAmount _balance = this.Balance;
            //    decimal pom = this.Balance.amount;
            //    _balance.amount = 100000;
            //    _balance.currency = "EUR";
            //    this.Balance = _balance;
            //    if (value.amount != pom)
            //    {
            //        this.OnBalanceChanged(this, new BalanceChangedEventArguments(this, value));
            //    }
            //    /*
            //    CurrencyAmount _balance = this.Balance;
            //    _balance.amount = 100000;
            //    _balance.currency = "EUR";
            //    this.Balance = _balance;
            //     * */
            //}
        }



        /// <summary>
        /// Constructor with three parametars
        /// </summary>
        /// <param name="m_ID">ID na korisnik</param>
        /// <param name="m_Number">Broj</param>
        /// <param name="Currency">Valuta</param>
        public Account(long ID, string number, string currency)
        {
            Random rm = new Random();
            //initialize Properties and Fields
            this.ID = ID;
            this.Number = number;
            this.Currency = currency;
            CurrencyAmount _balance = this.Balance;
            _balance.amount = rm.Next(80000,100000);
            _balance.currency = "EUR";
            this.Balance = _balance;
        }

        /// <summary>
        /// Overloaded Constructor with one parametar only
        /// </summary>
        /// <param name="Currency"></param>
        public Account(string currency) : this(Convert.ToInt64(AccountHelper.GenerateAccountID()), "n/a", currency) 
        {
            this.Number = GenerateAccountNumber(); 
        }



        //Default Constructor
        public Account()
        {
            /*
            this.ID = Convert.ToInt64(AccountHelper.GenerateAccountID());
            this.Number = GenerateAccountNumber();
            this.Currency = "MKD";
            CurrencyAmount _balance = this.Balance;
            _balance.amount = 100000;
            _balance.currency = "EUR";
            this.Balance = _balance;
             */ 
        }

        #region PUBLIC METHODS
        /// <summary>
        /// metod koj go namaluva balansot na smetkata
        /// </summary>
        /// <param name="amount">Balansot na smetkata treba da se namali za AMOUNT - edinici</param>
        /// <returns></returns>
        public virtual TransactionStatus DebitAmount(CurrencyAmount amount)
        {
            CurrencyAmount _balance = this.Balance;
            _balance.amount -= amount.amount;
            this.Balance = _balance;

            //dokolku vleznata VALUTA e ista so valutata na smetkata, vrati COMPLETED
            if (CompareCurrency(amount)) return TransactionStatus.Completed;
            //vo sprotiven slucaj vrati FAILED
            else return TransactionStatus.Failed;
        }
        /// <summary>
        /// metod koj zgolemuva balansot na smetkata
        /// </summary>
        /// <param name="amount">Balansot na smetkata treba da se zgolemi za AMOUNT - edinici</param>
        /// <returns></returns>
        public virtual TransactionStatus CreditAmount(CurrencyAmount amount)
        {
            CurrencyAmount _balance = this.Balance;
            _balance.amount += amount.amount;
            this.Balance = _balance;

            //dokolku vleznata VALUTA e ista so valutata na smetkata, vrati COMPLETED
            if (CompareCurrency(amount)) return TransactionStatus.Completed;
            //vo sprotiven slucaj vrati FAILED
            else return TransactionStatus.Failed;
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

                public event EventHandler<BalanceChangedEventArguments> OnBalanceChanged;


                //event EventHandler<BalanceChangedEventArguments> IAccount.OnBalanceChanged
                //{
                //    add { throw new NotImplementedException(); }
                //    remove { throw new NotImplementedException(); }
                //}
    }
}
