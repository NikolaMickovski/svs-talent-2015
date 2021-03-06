﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpProgrammingBasicsClasses;

namespace CSharpProgrammingBasicsTransactionApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metod koj kreiра Transaction Account i prikazuva informacii za istata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateTransactionAccount_Click(object sender, EventArgs e)
        {
            //kreirame objekt od klasata TransactionAccount
            ITransactionAccount ta = CreateTransactionAccount();

            //new TransactionAccount(
            //txtCurrency.Text, Convert.ToDecimal(txtLimit.Text));

            //iako metodot PopulateAccountCommon prima objekt od klasata ACCOUNT
            //(koja e Abstract class), koristejki NASLEDUVANJE i APSTRAKCIJATA, moze da go 
            //povikame istiot metod so Objekt od izvedenata klasa (se dvizime nadole
            //niz hierarhijata)
            PopulateAccountCommon(ta);
            IsItTransactionAccount(ta);
        }

        /// <summary>
        /// Metod koj gi popolnuva informciite za baznata klasa ACCOUNT
        /// </summary>
        /// <param name="a"></param>
        private void PopulateAccountCommon(IAccount a)
        {
            lblAccountID_Base.Text += " " + a.ID.ToString();
            lblAccountNumber_Base.Text += " " + a.Balance.amount.ToString();
            lblAccountCurency_Base.Text += " " + a.Balance.currency;
            lblAccount_Base_Number.Text += " " + a.Number;
           // IsItDepositAccount(a);
        }

        /// <summary>
        /// Metod koj dobiva na vlez opredelen objekt, proveruva dali e
        /// od TransactionAccount i soodvetno gi popolnuva vrednostite
        /// </summary>
        /// <param name="a"></param>
        private void IsItTransactionAccount(IAccount a)
        {
            if (a is TransactionAccount)
            {
                lblTransactionAccount_Base_Limit.Text += " " + ((ITransactionAccount)a).Limit.amount.ToString();
                lblTransactionAccount_Base_Currency.Text += " " + ((ITransactionAccount)a).Limit.currency;
            }
            else
            {
                lblTransactionAccount_Base_Limit.Text += " /";
                lblTransactionAccount_Base_Currency.Text += " /";
            }
        }
        /// <summary>
        /// Frame_Load - samo se koristi za nekoi inicijaliziranja za test slucai
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            // IDepositAccount Ida = CreateDeposit_Loan_Account<LoanAccount>(new TransactionAccount());
            //  Console.WriteLine(Ida.Number.ToString());

        }
        /// <summary>
        /// Metod koj kreira instanca od klasata DEPOSIT ACCOUNT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateDepositAccount_Click(object sender, EventArgs e)
        {
            IDepositAccount da = CreateDebitAccount();
            PopulateAccountCommon(da);
            IsItDepositAccount(da);
        }
        /// <summary>
        /// Proverka i ispisuvanje na informacii za DepositAccount
        /// </summary>
        /// <param name="a"></param>
        private void IsItDepositAccount(IAccount a)
        {
            if (a is DepositAccount)
            {
                lblDepositAccountStartDate.Text += " " + ((IDepositAccount)a).StartDate.Date.ToShortDateString();
                lblDepositAccountEndDate.Text += " " + ((IDepositAccount)a).EndDate.Date.ToLongDateString();
                lblDepositAccountPeriod.Text += " " + ((IDepositAccount)a).Period.period;
                lblDepositAccountUnit.Text += " " + ((IDepositAccount)a).Period.unit;
                lblDepositAccountPercent.Text += " " + ((IDepositAccount)a).Interest.percent;
                lblDepositAccountUnitOfTime.Text += " " + ((IDepositAccount)a).Interest.Unit;
            }
            else
            {
                lblDepositAccountStartDate.Text += " /";
                lblDepositAccountEndDate.Text += " /";
                lblDepositAccountPeriod.Text += " /";
                lblDepositAccountUnitOfTime.Text += " /";
                lblDepositAccountPercent.Text += " /";
                lblDepositAccountUnit.Text += " /";
            }
        }

        /// <summary>
        /// Transakcija 20.000,00 MKD megu dve smetki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeTransaction_Click(object sender, EventArgs e)
        {
            //Kreirame objekt od klasata TransactionAccount (default ke ima Random den na smetka, ID ke e auto-generated - Account Constructor with ONE PARAM)
            ITransactionAccount ta = new TransactionAccount(
                txtCurrency.Text, Convert.ToDecimal(txtLimit.Text));
            ta.OnBalanceChanged += OnBalanceChanged_Handler;

            //Kreirame objekt od klasata DepositAccount (default ke ima Random den na smetka, ID ke e auto-generated - DEFAULT Account Constructor)
            IDepositAccount da = CreateDebitAccount();
            da.OnBalanceChanged += OnBalanceChanged_Handler;
            //Kreirame objekt od klasata LoanAccount, (default ke ima Random den na smetka, ID ke e auto-generated,
            //Default constructor na LoanAccount --> Default Constructor na DepositAccount --> Default Constructor na Account)
            ILoanAccount la = CreateLoanAccount();
            la.OnBalanceChanged += OnBalanceChanged_Handler;

            //Kreirame objekt od klasata TransactionProcessor koj ke e odgovoren za izvrsuvanje transakcija
            // ITransactionProcessor tp = new TransactionProcessor();
            ITransactionProcessor tp = TransactionProcessor.GetTransactionProcessor();

            tp.ProcessTransaction(TransactionType.Transfer, new CurrencyAmount(28000, "MKD"), ta, da);
            PopulateAccounts(ta, da);

            // tp.ProcessTransaction(TransactionType.Transfer, new CurrencyAmount(20000, "MKD"), da,la);
            // PopulateAccounts(da, la);
            DisplayLastTransactionDetails(tp);
        }
        /// <summary>
        /// Prikaz na dve smetki
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private void PopulateAccounts(IAccount a, IAccount b)
        {
            lblAccountID_Base.Text += " " + a.ID.ToString();
            lblAccountNumber_Base.Text += " " + a.Balance.amount.ToString();
            lblAccountCurency_Base.Text += " " + a.Balance.currency;
            lblAccount_Base_Number.Text += " " + a.Number;

            lblAccountID_Base_TO.Text += " " + b.ID.ToString();
            lblAccountNumber_Base_TO.Text += " " + b.Balance.amount.ToString();
            lblAccountCurency_Base_TO.Text += " " + b.Balance.currency;
            lblAccount_Base_Number_TO.Text += " " + b.Number;
        }
        /// <summary>
        /// Metod koj kreira Objekt od klsata LoanAccount
        /// </summary>
        private LoanAccount CreateLoanAccount()
        {
            return new LoanAccount(txtCurrency.Text,
                new TimePeriod(Convert.ToInt32(txtAmountPeriod.Text), (UnitOfTime)Enum.Parse(typeof(UnitOfTime), txtUnitOfTimePeriod.Text)),
                new InterestRate(Convert.ToDecimal(txtAmountInterestRate.Text), (UnitOfTime)Enum.Parse(typeof(UnitOfTime), txtUnitOfTimeInterestRate.Text)),
                (DateTime)dtpStartDate.Value,
                (DateTime)dtpEndDate.Value,
                new TransactionAccount(txtCurrency.Text, Convert.ToDecimal(txtLimit.Text)));
        }
        /// <summary>
        /// Vo ovoj metod ke bide pokazana upotrebata na WRAPPING Exceptions
        /// i iskoristeno svojstvoto InnerException
        /// </summary>
        /// <returns></returns>
        private TransactionAccount CreateTransactionAccount()
        {

            CurrencyAmount ca;
            //Nadvoresen TRY - OUTSIDE WRAPPER
            try
            {
                try //Vnatresen try koj ke frli greska od tip UserInterfaceException
                {
                    ca = ReadLimitTransaction(txtLimit.Text, txtCurrency.Text);
                    return new TransactionAccount(ca.currency, ca.amount);
                }
                catch (FormatException e)
                {

                    throw new UserInterfaceException("Level UP", e);
                }
                catch (NullReferenceException e)
                {

                    throw new UserInterfaceException("Level UP", e);
                }
            }
            catch (UserInterfaceException e)
            {
                //Zapisi ja VNATRESNATA greska vo nekoj Logger
                ExceptionLogger.LogException(e.InnerException);
                //Vrati Currency Aount - default
                txtCurrency.Text = "MKD";
                txtLimit.Text = "100";
                return new TransactionAccount("MKD", 100);
            }

        }

        /// <summary>
        /// Metod za genericko generiranje na nova smetka Deposit ili Loan
        /// </summary>
        /// <typeparam name="Class_Type"></typeparam>
        /// <param name="ta"></param>
        /// <returns></returns>
        private IDepositAccount CreateDeposit_Loan_Account<Class_Type>(TransactionAccount ta) where Class_Type : DepositAccount, new()
        {
            Class_Type c_t = new Class_Type();
            if (c_t.GetType() == typeof(DepositAccount))
            {
                return new DepositAccount(txtCurrency.Text,
                new TimePeriod(Convert.ToInt32(txtAmountPeriod.Text), (UnitOfTime)Enum.Parse(typeof(UnitOfTime), txtUnitOfTimePeriod.Text)),
                new InterestRate(Convert.ToDecimal(txtAmountInterestRate.Text), (UnitOfTime)Enum.Parse(typeof(UnitOfTime), txtUnitOfTimeInterestRate.Text)),
                (DateTime)dtpStartDate.Value,
                (DateTime)dtpEndDate.Value,
                new TransactionAccount(txtCurrency.Text, Convert.ToDecimal(txtLimit.Text)));
            }
            else
            {
                if (c_t.GetType() == typeof(LoanAccount))
                {
                    return new LoanAccount(txtCurrency.Text,
                    new TimePeriod(Convert.ToInt32(txtAmountPeriod.Text), (UnitOfTime)Enum.Parse(typeof(UnitOfTime), txtUnitOfTimePeriod.Text)),
                    new InterestRate(Convert.ToDecimal(txtAmountInterestRate.Text), (UnitOfTime)Enum.Parse(typeof(UnitOfTime), txtUnitOfTimeInterestRate.Text)),
                    (DateTime)dtpStartDate.Value,
                    (DateTime)dtpEndDate.Value,
                    new TransactionAccount(txtCurrency.Text, Convert.ToDecimal(txtLimit.Text)));
                }
                else
                {
                    c_t = default(Class_Type);
                }
            }
            return c_t;
        }
        /// <summary>
        /// Metod koj vraka instanca od Deposit Account
        /// </summary>
        /// <returns></returns>
        private DepositAccount CreateDebitAccount()
        {
            return new DepositAccount(txtCurrency.Text,
                new TimePeriod(Convert.ToInt32(txtAmountPeriod.Text), (UnitOfTime)Enum.Parse(typeof(UnitOfTime), txtUnitOfTimePeriod.Text)),
                new InterestRate(Convert.ToDecimal(txtAmountInterestRate.Text), (UnitOfTime)Enum.Parse(typeof(UnitOfTime), txtUnitOfTimeInterestRate.Text)),
                (DateTime)dtpStartDate.Value,
                (DateTime)dtpEndDate.Value,
                new TransactionAccount(txtCurrency.Text, Convert.ToDecimal(txtLimit.Text)));

        }

        /// <summary>
        /// Kopce za pravenje na grupna transakcija
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeGroupTransaction_Click(object sender, EventArgs e)
        {
            bool err = false;
            string _errorMsg = null;
            bool _errorOccurred = false;
            try
            {
                IAccount[] niza_smetki;
                niza_smetki = new IAccount[2];

                //Kreirame ITansactionAccount
                ITransactionAccount ta = CreateTransactionAccount();
                ta.OnBalanceChanged+=OnBalanceChanged_Handler;
                niza_smetki[0] = ta;


                //Kreirame IDepositAccount
                IDepositAccount da = CreateDebitAccount();
                da.OnBalanceChanged += OnBalanceChanged_Handler;

                niza_smetki[1] = da;

                //ILoanAccount la = CreateLoanAccount();
                //la.OnBalanceChanged += OnBalanceChanged_Handler;

                //niza_smetki[1] = la;

                ITransactionProcessor tp = TransactionProcessor.GetTransactionProcessor();
                try
                {
                    tp.ProcessGroupTransaction(TransactionType.Debit, new CurrencyAmount(Convert.ToDecimal(txtTransactionAmount.Text), txtTransactionCurrency.Text), niza_smetki);
                }
                catch (Exception ex)
                {
                    if (ex.GetType() == typeof(CurrencyMismatchException))
                    {
                        throw;
                    }
                    if (ex.GetType() == typeof(LimitReached))
                    {
                        Console.WriteLine(((LimitReached)ex).ErrorCode + "\n");
                    }
                    Console.WriteLine(ex.Message + "\n");
                    txtTransactionAmount.Text = "10";
                    txtTransactionCurrency.Text = "MKD";
                    err = true;
                }

                if (!err)
                {
                    PopulateAccounts(da, ta);DisplayLastTransactionDetailsWithKey(tp);
                    CreateAccounts(CreateAccountType.DepositAccount | CreateAccountType.LoanAccount, null);
                }
            }
            catch (CurrencyMismatchException cme)
            {
                _errorOccurred = true;
                _errorMsg = cme.message;
                // throw new UserInterfaceException(cme.Message, new CurrencyMismatchException("/"));

            }
            catch (ApplicationException ae)
            {

                _errorMsg += ae.Message;
                throw;
            }
            finally
            {
                if (_errorOccurred)
                {
                    MessageBox.Show(_errorMsg);
                }
            }
        }


        /// <summary>
        /// Privaten metod koj ke "frla" greski koi UI Exception Handler ke treba da gi WRAP-uva
        /// Konkretno, tuka se frlaat NullException i InvalidCOnversion
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="currency"></param>
        /// <returns></returns>
        private CurrencyAmount ReadLimitTransaction(string amount, string currency)
        {
            if (amount == "" || currency == "")
            {
                throw new NullReferenceException("Проблем во Корисничкиот интефејс - NULL VALUES\n");
            }
            decimal d = 0;

            if (!decimal.TryParse(amount, out d))
            {
                throw new FormatException("Проблем во Корисничкиот интефејс - DECIMAL NOT PARSED\n");
            }

            CurrencyAmount ca = new CurrencyAmount(d, currency);
            return ca;

        }

        /// <summary>
        /// Metod koj prikazuva informacii za poslednata transakcija,
        /// koristejki go Property-to LastTransaction
        /// </summary>
        private void DisplayLastTransactionDetails(ITransactionProcessor in_tp)
        {
            lblTotalTransactionCount.Text += " " + in_tp.TransactionCount.ToString();
            lblTLETransactionType.Text = in_tp.LastTransaction.TransactionType.ToString();
            lblTLE_CA_amount.Text = in_tp.LastTransaction.Amount.amount.ToString();
            lblTLE_CA_currency.Text = in_tp.LastTransaction.Amount.currency.ToString();
            lblTLE_Accounts.Text = in_tp.LastTransaction.Accounts.Number;
            lblTLE_Status.Text = in_tp.LastTransaction.Status.ToString();
        }

        /// <summary>
        /// Metod koj koristi INDEXERS, so Property-to TransactionCount kako kluc
        /// za prikaz na informacii za POSLEDNO IZVRSENATA TRANSAKCIJA
        /// </summary>
        /// <param name="in_tp"></param>
        private void DisplayLastTransactionDetailsWithKey(ITransactionProcessor in_tp)
        {
            lblTotalTransactionCount.Text += " " + in_tp.TransactionCount.ToString();
            //koristime indexers
            lblTLETransactionType.Text = in_tp[in_tp.TransactionCount - 1].TransactionType.ToString();
            lblTLE_CA_amount.Text = in_tp[in_tp.TransactionCount - 1].Amount.amount.ToString();
            lblTLE_CA_currency.Text = in_tp[in_tp.TransactionCount - 1].Amount.currency.ToString();
            lblTLE_Accounts.Text = in_tp[in_tp.TransactionCount - 1].Accounts.Number;
            lblTLE_Status.Text = in_tp[in_tp.TransactionCount - 1].Status.ToString();
        }
        /// <summary>
        /// Handler for BalanceChanged Event (when Event fires)
        /// </summary>
        /// <param name="o"></param>
        /// <param name="eventArgs"></param>
        private static void OnBalanceChanged_Handler(Object o, BalanceChangedEventArguments eventArgs)
        {
            Console.WriteLine(
                "Arg 1 (Account Number): " + eventArgs.Account.Number + "\n" +
                "Arg 2 (Tekovnoto saldo bilo): " + eventArgs.Account.Balance.amount.ToString() + "\n" +
                "Arg 3 (A sega iznesuva): " + eventArgs.Change.amount.ToString()+"\n");
        }

        /// <summary>
        /// Metod koj na vlez treba da dobie odreden FLAG,
        /// a potoa vrz osnova na nego da kreira soodvetni smetki
        /// </summary>
        /// <param name="accountTypesToCreate">INPUT FLAG</param>
        /// <param name="transactionAccount"></param>
        /// <returns></returns>
        private Dictionary<CreateAccountType, IAccount> CreateAccounts(CreateAccountType accountTypesToCreate, ITransactionAccount transactionAccount)
        {
            IDictionary<CreateAccountType, IAccount> dic = new Dictionary<CreateAccountType, IAccount>();

            switch (accountTypesToCreate)
            {
                case CreateAccountType.DepositAccount:
                    {
                        dic.Add(CreateAccountType.DepositAccount, CreateDebitAccount());
                        return (Dictionary<CreateAccountType, IAccount>)dic;
                    }
                case CreateAccountType.LoanAccount:
                    {
                        dic.Add(CreateAccountType.LoanAccount, CreateLoanAccount());
                        return (Dictionary<CreateAccountType, IAccount>)dic;
                    }
                case CreateAccountType.TransactionAccount:
                    {
                        dic.Add(CreateAccountType.TransactionAccount, CreateTransactionAccount());
                        return (Dictionary<CreateAccountType, IAccount>)dic;
                    }
                case CreateAccountType.DepositAccount | CreateAccountType.LoanAccount:
                    {
                        dic.Add(CreateAccountType.DepositAccount, CreateDebitAccount());
                        dic.Add(CreateAccountType.LoanAccount, CreateLoanAccount());
                        return (Dictionary<CreateAccountType, IAccount>)dic;
                    }
                case CreateAccountType.DepositAccount | CreateAccountType.TransactionAccount:
                    {
                        dic.Add(CreateAccountType.DepositAccount, CreateDebitAccount());
                        dic.Add(CreateAccountType.LoanAccount, CreateTransactionAccount());
                        return (Dictionary<CreateAccountType, IAccount>)dic;
                    }
                case CreateAccountType.LoanAccount | CreateAccountType.TransactionAccount:
                    {
                        dic.Add(CreateAccountType.LoanAccount, CreateLoanAccount());
                        dic.Add(CreateAccountType.TransactionAccount, CreateTransactionAccount());
                        return (Dictionary<CreateAccountType, IAccount>)dic;
                    }
                case CreateAccountType.LoanAccount | CreateAccountType.TransactionAccount | CreateAccountType.DepositAccount:
                    {
                        dic.Add(CreateAccountType.LoanAccount, CreateLoanAccount());
                        dic.Add(CreateAccountType.TransactionAccount, CreateTransactionAccount());
                        dic.Add(CreateAccountType.DepositAccount, CreateDebitAccount());
                        return (Dictionary<CreateAccountType, IAccount>)dic;
                    }
                default:
                    {
                        dic = null;
                        return (Dictionary<CreateAccountType, IAccount>)dic;
                    }

            }

        }

        /// <summary>
        /// Del od kodot koj bese i kaj Make_groupTransaction e kopiran,
        /// samo za da se pokaze koristenjeto na Extension method-ot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChargeFee_Click(object sender, EventArgs e)
        {
            bool err = false;
            IAccount[] niza_smetki;
            niza_smetki = new IAccount[2];

            //Kreirame IDepositAccount
            IDepositAccount da = CreateDebitAccount();
            da.OnBalanceChanged += OnBalanceChanged_Handler;

            niza_smetki[0] = da;
            ILoanAccount la = CreateLoanAccount();
            la.OnBalanceChanged += OnBalanceChanged_Handler;

            niza_smetki[1] = la;
            IList<IAccount> niza = new List<IAccount>(niza_smetki);
            ITransactionProcessor tp = TransactionProcessor.GetTransactionProcessor();
            // tp.ProcessGroupTransaction(TransactionType.Debit, new CurrencyAmount(Convert.ToDecimal(txtTransactionAmount.Text), txtTransactionCurrency.Text), niza_smetki);
            //ProcessorExtension.ChargeProcessingFee(new CurrencyAmount(Convert.ToDecimal(txtTransactionAmount.Text), txtTransactionCurrency.Text), niza_smetki);

            //Call the extension method
            //ProcessorExtensions.ChargeProcessingFee(tp,new CurrencyAmount(Convert.ToDecimal(txtTransactionAmount.Text), txtTransactionCurrency.Text), niza);

            //Call the method
            try
            {
                tp.ChargeProcessingFee(new CurrencyAmount(Convert.ToDecimal(txtTransactionAmount.Text), txtTransactionCurrency.Text), niza);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
                txtTransactionAmount.Text = "10";
                txtTransactionCurrency.Text = "MKD";
                err = true;
            }

            if (!err)
            {
                PopulateAccounts(da, la);

                DisplayLastTransactionDetailsWithKey(tp);
                CreateAccounts(CreateAccountType.DepositAccount | CreateAccountType.LoanAccount, null);

                // TransactionProcessor.GetTransactionProcessor().ChargeProcessingFee(new CurrencyAmount(Convert.ToDecimal(txtTransactionAmount.Text), txtTransactionCurrency.Text), niza_smetki);
            }
        }


    }
}
