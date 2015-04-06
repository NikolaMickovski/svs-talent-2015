using System;
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

        private void btnCreateTransactionAccount_Click(object sender, EventArgs e)
        {
            //kreirame objekt od klasata TransactionAccount
            ITransactionAccount ta = new TransactionAccount(
                txtCurrency.Text, Convert.ToDecimal(txtLimit.Text));
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
            //lblAccountID_Base.Text = "";
            //lblAccountNumber_Base.Text = "";
            //lblAccountCurency_Base.Text = "";

            lblAccountID_Base.Text += " " + a.ID.ToString();
            lblAccountNumber_Base.Text += " " + a.Balance.amount.ToString();
            lblAccountCurency_Base.Text += " " + a.Currency;

            IsItDepositAccount(a);
            //lblAccountCurrency.Text = a.currency;
            //lblAccountLimit.Text = a.number;
          //  lblBalanceAmount.Text = a.Balance.amount.ToString();
            //lblAccountBalanceCurrency.Text = a.Balance.currency;
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            //PopulateAccounts(new Account("mkd"),new Account("usa"));
        }
        /// <summary>
        /// Metod koj kreira instanca od klasata DEPOSIT ACCOUNT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateDepositAccount_Click(object sender, EventArgs e)
        {
            IDepositAccount da = new DepositAccount
                (txtCurrency.Text,
                new TimePeriod(Convert.ToInt32(txtAmountPeriod.Text), (UnitOfTime)Enum.Parse(typeof(UnitOfTime), txtUnitOfTimePeriod.Text)),
                new InterestRate(Convert.ToDecimal(txtAmountInterestRate.Text),(UnitOfTime)Enum.Parse(typeof(UnitOfTime),txtUnitOfTimeInterestRate.Text)),
                (DateTime)dtpStartDate.Value,
                (DateTime)dtpEndDate.Value,
                new TransactionAccount(txtCurrency.Text, Convert.ToDecimal(txtLimit.Text))
                );
            IsItDepositAccount(da);
        }

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
            ITransactionAccount ta = new TransactionAccount(
                txtCurrency.Text, Convert.ToDecimal(txtLimit.Text));
            IDepositAccount da = new DepositAccount(txtCurrency.Text,
                new TimePeriod(Convert.ToInt32(txtAmountPeriod.Text), (UnitOfTime)Enum.Parse(typeof(UnitOfTime), txtUnitOfTimePeriod.Text)),
                new InterestRate(Convert.ToDecimal(txtAmountInterestRate.Text), (UnitOfTime)Enum.Parse(typeof(UnitOfTime), txtUnitOfTimeInterestRate.Text)),
                (DateTime)dtpStartDate.Value,
                (DateTime)dtpEndDate.Value,
                new TransactionAccount(txtCurrency.Text, Convert.ToDecimal(txtLimit.Text))
                );
            ILoanAccount la = CreateLoanAccount();
            ITransactionProcessor tp = new TransactionProcessor();
            tp.ProcessTransaction(TransactionType.Transfer, new CurrencyAmount(20000, "MKD"), ta, da);
            PopulateAccounts(ta, da);
           // tp.ProcessTransaction(TransactionType.Transfer, new CurrencyAmount(20000, "MKD"), da,la);
          //  PopulateAccounts(da, la);
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
            lblAccountCurency_Base.Text += " " + a.Currency;
            lblAccount_Base_Number.Text += " " + a.Number;            

            lblAccountID_Base_TO.Text += " " + b.ID.ToString();
            lblAccountNumber_Base_TO.Text += " " + b.Balance.amount.ToString();
            lblAccountCurency_Base_TO.Text += " " + b.Currency;
            lblAccount_Base_Number_TO.Text += " " + b.Number;
        }
        /// <summary>
        /// Metod koj kreira Objekt od klsata LoanAccount
        /// </summary>
        private LoanAccount CreateLoanAccount()
        {
            return new LoanAccount();
        }
    }
}
