namespace CSharpProgrammingBasicsTransactionApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateTransactionAccount = new System.Windows.Forms.Button();
            this.btnCreateDepositAccount = new System.Windows.Forms.Button();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.lblAccountCurrency = new System.Windows.Forms.Label();
            this.lblAccountLimit = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtAmountPeriod = new System.Windows.Forms.TextBox();
            this.txtUnitOfTimePeriod = new System.Windows.Forms.TextBox();
            this.txtAmountInterestRate = new System.Windows.Forms.TextBox();
            this.txtUnitOfTimeInterestRate = new System.Windows.Forms.TextBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblAccountInformation = new System.Windows.Forms.Label();
            this.lblTranscationAccountInformation = new System.Windows.Forms.Label();
            this.lblDepositAccountInformation = new System.Windows.Forms.Label();
            this.lblDepositAccountStartDate = new System.Windows.Forms.Label();
            this.lblDepositAccountEndDate = new System.Windows.Forms.Label();
            this.lblDepositAccountPercent = new System.Windows.Forms.Label();
            this.lblDepositAccountUnit = new System.Windows.Forms.Label();
            this.lblDepositAccountPeriod = new System.Windows.Forms.Label();
            this.lblDepositAccountUnitOfTime = new System.Windows.Forms.Label();
            this.lblAccountID_Base = new System.Windows.Forms.Label();
            this.lblAccountNumber_Base = new System.Windows.Forms.Label();
            this.lblAccountCurency_Base = new System.Windows.Forms.Label();
            this.lblTransactionAccount_Base_Limit = new System.Windows.Forms.Label();
            this.lblTransactionAccount_Base_Currency = new System.Windows.Forms.Label();
            this.lblAccountCurency_Base_TO = new System.Windows.Forms.Label();
            this.lblAccountNumber_Base_TO = new System.Windows.Forms.Label();
            this.lblAccountID_Base_TO = new System.Windows.Forms.Label();
            this.lblAccountInformation_TO = new System.Windows.Forms.Label();
            this.btnMakeTransaction = new System.Windows.Forms.Button();
            this.lblAccount_Base_Number = new System.Windows.Forms.Label();
            this.lblAccount_Base_Number_TO = new System.Windows.Forms.Label();
            this.btnMakeGroupTransaction = new System.Windows.Forms.Button();
            this.lblTotalTransactionCount = new System.Windows.Forms.Label();
            this.lblTransactionLogEntrydetails = new System.Windows.Forms.Label();
            this.lblTLETransactionType = new System.Windows.Forms.Label();
            this.lblTLE_CA_amount = new System.Windows.Forms.Label();
            this.lblTLE_CA_currency = new System.Windows.Forms.Label();
            this.lblTLE_Accounts = new System.Windows.Forms.Label();
            this.lblTLE_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateTransactionAccount
            // 
            this.btnCreateTransactionAccount.Location = new System.Drawing.Point(49, 245);
            this.btnCreateTransactionAccount.Name = "btnCreateTransactionAccount";
            this.btnCreateTransactionAccount.Size = new System.Drawing.Size(183, 23);
            this.btnCreateTransactionAccount.TabIndex = 0;
            this.btnCreateTransactionAccount.Text = "Create Transaction Account";
            this.btnCreateTransactionAccount.UseVisualStyleBackColor = true;
            this.btnCreateTransactionAccount.Click += new System.EventHandler(this.btnCreateTransactionAccount_Click);
            // 
            // btnCreateDepositAccount
            // 
            this.btnCreateDepositAccount.Location = new System.Drawing.Point(49, 275);
            this.btnCreateDepositAccount.Name = "btnCreateDepositAccount";
            this.btnCreateDepositAccount.Size = new System.Drawing.Size(183, 23);
            this.btnCreateDepositAccount.TabIndex = 1;
            this.btnCreateDepositAccount.Text = "Create Deposit Account";
            this.btnCreateDepositAccount.UseVisualStyleBackColor = true;
            this.btnCreateDepositAccount.Click += new System.EventHandler(this.btnCreateDepositAccount_Click);
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(132, 42);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(100, 20);
            this.txtCurrency.TabIndex = 2;
            this.txtCurrency.Text = "MKD";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(132, 68);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(100, 20);
            this.txtLimit.TabIndex = 3;
            this.txtLimit.Text = "10000";
            // 
            // lblAccountCurrency
            // 
            this.lblAccountCurrency.AutoSize = true;
            this.lblAccountCurrency.Location = new System.Drawing.Point(34, 45);
            this.lblAccountCurrency.Name = "lblAccountCurrency";
            this.lblAccountCurrency.Size = new System.Drawing.Size(42, 13);
            this.lblAccountCurrency.TabIndex = 4;
            this.lblAccountCurrency.Text = "Валута";
            // 
            // lblAccountLimit
            // 
            this.lblAccountLimit.AutoSize = true;
            this.lblAccountLimit.Location = new System.Drawing.Point(34, 72);
            this.lblAccountLimit.Name = "lblAccountLimit";
            this.lblAccountLimit.Size = new System.Drawing.Size(95, 13);
            this.lblAccountLimit.TabIndex = 5;
            this.lblAccountLimit.Text = "Лимит на сметка";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(132, 99);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 6;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(132, 128);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 7;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(34, 101);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(82, 13);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Почетен датум";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(34, 131);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(71, 13);
            this.lblEndDate.TabIndex = 9;
            this.lblEndDate.Text = "Краен датум";
            // 
            // txtAmountPeriod
            // 
            this.txtAmountPeriod.Location = new System.Drawing.Point(132, 155);
            this.txtAmountPeriod.Name = "txtAmountPeriod";
            this.txtAmountPeriod.Size = new System.Drawing.Size(100, 20);
            this.txtAmountPeriod.TabIndex = 10;
            this.txtAmountPeriod.Text = "Amount";
            // 
            // txtUnitOfTimePeriod
            // 
            this.txtUnitOfTimePeriod.Location = new System.Drawing.Point(255, 154);
            this.txtUnitOfTimePeriod.Name = "txtUnitOfTimePeriod";
            this.txtUnitOfTimePeriod.Size = new System.Drawing.Size(100, 20);
            this.txtUnitOfTimePeriod.TabIndex = 11;
            this.txtUnitOfTimePeriod.Text = "Unit of Time";
            // 
            // txtAmountInterestRate
            // 
            this.txtAmountInterestRate.Location = new System.Drawing.Point(132, 182);
            this.txtAmountInterestRate.Name = "txtAmountInterestRate";
            this.txtAmountInterestRate.Size = new System.Drawing.Size(100, 20);
            this.txtAmountInterestRate.TabIndex = 12;
            this.txtAmountInterestRate.Text = "Amount";
            // 
            // txtUnitOfTimeInterestRate
            // 
            this.txtUnitOfTimeInterestRate.Location = new System.Drawing.Point(255, 182);
            this.txtUnitOfTimeInterestRate.Name = "txtUnitOfTimeInterestRate";
            this.txtUnitOfTimeInterestRate.Size = new System.Drawing.Size(100, 20);
            this.txtUnitOfTimeInterestRate.TabIndex = 13;
            this.txtUnitOfTimeInterestRate.Text = "Unit of Time";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(34, 161);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(45, 13);
            this.lblPeriod.TabIndex = 14;
            this.lblPeriod.Text = "Период";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(34, 182);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(89, 13);
            this.lblInterestRate.TabIndex = 15;
            this.lblInterestRate.Text = "Каматна стапка";
            // 
            // lblAccountInformation
            // 
            this.lblAccountInformation.AutoSize = true;
            this.lblAccountInformation.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAccountInformation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAccountInformation.Location = new System.Drawing.Point(405, 13);
            this.lblAccountInformation.Name = "lblAccountInformation";
            this.lblAccountInformation.Size = new System.Drawing.Size(148, 13);
            this.lblAccountInformation.TabIndex = 21;
            this.lblAccountInformation.Text = "Информации за сметка ОД";
            // 
            // lblTranscationAccountInformation
            // 
            this.lblTranscationAccountInformation.AutoSize = true;
            this.lblTranscationAccountInformation.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblTranscationAccountInformation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTranscationAccountInformation.Location = new System.Drawing.Point(405, 141);
            this.lblTranscationAccountInformation.Name = "lblTranscationAccountInformation";
            this.lblTranscationAccountInformation.Size = new System.Drawing.Size(202, 13);
            this.lblTranscationAccountInformation.TabIndex = 22;
            this.lblTranscationAccountInformation.Text = "Информации за трансакциска сметка";
            // 
            // lblDepositAccountInformation
            // 
            this.lblDepositAccountInformation.AutoSize = true;
            this.lblDepositAccountInformation.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblDepositAccountInformation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepositAccountInformation.Location = new System.Drawing.Point(405, 215);
            this.lblDepositAccountInformation.Name = "lblDepositAccountInformation";
            this.lblDepositAccountInformation.Size = new System.Drawing.Size(184, 13);
            this.lblDepositAccountInformation.TabIndex = 25;
            this.lblDepositAccountInformation.Text = "Информации за депозитна сметка";
            // 
            // lblDepositAccountStartDate
            // 
            this.lblDepositAccountStartDate.AutoSize = true;
            this.lblDepositAccountStartDate.Location = new System.Drawing.Point(408, 231);
            this.lblDepositAccountStartDate.Name = "lblDepositAccountStartDate";
            this.lblDepositAccountStartDate.Size = new System.Drawing.Size(85, 13);
            this.lblDepositAccountStartDate.TabIndex = 26;
            this.lblDepositAccountStartDate.Text = "Почетен датум:";
            // 
            // lblDepositAccountEndDate
            // 
            this.lblDepositAccountEndDate.AutoSize = true;
            this.lblDepositAccountEndDate.Location = new System.Drawing.Point(408, 250);
            this.lblDepositAccountEndDate.Name = "lblDepositAccountEndDate";
            this.lblDepositAccountEndDate.Size = new System.Drawing.Size(74, 13);
            this.lblDepositAccountEndDate.TabIndex = 27;
            this.lblDepositAccountEndDate.Text = "Краен датум:";
            // 
            // lblDepositAccountPercent
            // 
            this.lblDepositAccountPercent.AutoSize = true;
            this.lblDepositAccountPercent.Location = new System.Drawing.Point(405, 309);
            this.lblDepositAccountPercent.Name = "lblDepositAccountPercent";
            this.lblDepositAccountPercent.Size = new System.Drawing.Size(53, 13);
            this.lblDepositAccountPercent.TabIndex = 28;
            this.lblDepositAccountPercent.Text = "Процент:";
            // 
            // lblDepositAccountUnit
            // 
            this.lblDepositAccountUnit.AutoSize = true;
            this.lblDepositAccountUnit.Location = new System.Drawing.Point(405, 285);
            this.lblDepositAccountUnit.Name = "lblDepositAccountUnit";
            this.lblDepositAccountUnit.Size = new System.Drawing.Size(112, 13);
            this.lblDepositAccountUnit.TabIndex = 29;
            this.lblDepositAccountUnit.Text = "Временска единица:";
            // 
            // lblDepositAccountPeriod
            // 
            this.lblDepositAccountPeriod.AutoSize = true;
            this.lblDepositAccountPeriod.Location = new System.Drawing.Point(408, 268);
            this.lblDepositAccountPeriod.Name = "lblDepositAccountPeriod";
            this.lblDepositAccountPeriod.Size = new System.Drawing.Size(48, 13);
            this.lblDepositAccountPeriod.TabIndex = 30;
            this.lblDepositAccountPeriod.Text = "Период:";
            // 
            // lblDepositAccountUnitOfTime
            // 
            this.lblDepositAccountUnitOfTime.AutoSize = true;
            this.lblDepositAccountUnitOfTime.Location = new System.Drawing.Point(406, 328);
            this.lblDepositAccountUnitOfTime.Name = "lblDepositAccountUnitOfTime";
            this.lblDepositAccountUnitOfTime.Size = new System.Drawing.Size(112, 13);
            this.lblDepositAccountUnitOfTime.TabIndex = 31;
            this.lblDepositAccountUnitOfTime.Text = "Временска единица:";
            // 
            // lblAccountID_Base
            // 
            this.lblAccountID_Base.AutoSize = true;
            this.lblAccountID_Base.Location = new System.Drawing.Point(408, 42);
            this.lblAccountID_Base.Name = "lblAccountID_Base";
            this.lblAccountID_Base.Size = new System.Drawing.Size(76, 13);
            this.lblAccountID_Base.TabIndex = 32;
            this.lblAccountID_Base.Text = "ID на сметка:";
            // 
            // lblAccountNumber_Base
            // 
            this.lblAccountNumber_Base.AutoSize = true;
            this.lblAccountNumber_Base.Location = new System.Drawing.Point(408, 68);
            this.lblAccountNumber_Base.Name = "lblAccountNumber_Base";
            this.lblAccountNumber_Base.Size = new System.Drawing.Size(113, 13);
            this.lblAccountNumber_Base.TabIndex = 34;
            this.lblAccountNumber_Base.Text = "Средства на сметка:";
            // 
            // lblAccountCurency_Base
            // 
            this.lblAccountCurency_Base.AutoSize = true;
            this.lblAccountCurency_Base.Location = new System.Drawing.Point(408, 99);
            this.lblAccountCurency_Base.Name = "lblAccountCurency_Base";
            this.lblAccountCurency_Base.Size = new System.Drawing.Size(100, 13);
            this.lblAccountCurency_Base.TabIndex = 35;
            this.lblAccountCurency_Base.Text = "Валута на сметка:";
            // 
            // lblTransactionAccount_Base_Limit
            // 
            this.lblTransactionAccount_Base_Limit.AutoSize = true;
            this.lblTransactionAccount_Base_Limit.Location = new System.Drawing.Point(408, 162);
            this.lblTransactionAccount_Base_Limit.Name = "lblTransactionAccount_Base_Limit";
            this.lblTransactionAccount_Base_Limit.Size = new System.Drawing.Size(98, 13);
            this.lblTransactionAccount_Base_Limit.TabIndex = 36;
            this.lblTransactionAccount_Base_Limit.Text = "Лимит на сметка:";
            // 
            // lblTransactionAccount_Base_Currency
            // 
            this.lblTransactionAccount_Base_Currency.AutoSize = true;
            this.lblTransactionAccount_Base_Currency.Location = new System.Drawing.Point(408, 185);
            this.lblTransactionAccount_Base_Currency.Name = "lblTransactionAccount_Base_Currency";
            this.lblTransactionAccount_Base_Currency.Size = new System.Drawing.Size(100, 13);
            this.lblTransactionAccount_Base_Currency.TabIndex = 37;
            this.lblTransactionAccount_Base_Currency.Text = "Валута на сметка:";
            // 
            // lblAccountCurency_Base_TO
            // 
            this.lblAccountCurency_Base_TO.AutoSize = true;
            this.lblAccountCurency_Base_TO.Location = new System.Drawing.Point(578, 99);
            this.lblAccountCurency_Base_TO.Name = "lblAccountCurency_Base_TO";
            this.lblAccountCurency_Base_TO.Size = new System.Drawing.Size(100, 13);
            this.lblAccountCurency_Base_TO.TabIndex = 41;
            this.lblAccountCurency_Base_TO.Text = "Валута на сметка:";
            // 
            // lblAccountNumber_Base_TO
            // 
            this.lblAccountNumber_Base_TO.AutoSize = true;
            this.lblAccountNumber_Base_TO.Location = new System.Drawing.Point(578, 68);
            this.lblAccountNumber_Base_TO.Name = "lblAccountNumber_Base_TO";
            this.lblAccountNumber_Base_TO.Size = new System.Drawing.Size(113, 13);
            this.lblAccountNumber_Base_TO.TabIndex = 40;
            this.lblAccountNumber_Base_TO.Text = "Средства на сметка:";
            // 
            // lblAccountID_Base_TO
            // 
            this.lblAccountID_Base_TO.AutoSize = true;
            this.lblAccountID_Base_TO.Location = new System.Drawing.Point(578, 42);
            this.lblAccountID_Base_TO.Name = "lblAccountID_Base_TO";
            this.lblAccountID_Base_TO.Size = new System.Drawing.Size(76, 13);
            this.lblAccountID_Base_TO.TabIndex = 39;
            this.lblAccountID_Base_TO.Text = "ID на сметка:";
            // 
            // lblAccountInformation_TO
            // 
            this.lblAccountInformation_TO.AutoSize = true;
            this.lblAccountInformation_TO.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAccountInformation_TO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAccountInformation_TO.Location = new System.Drawing.Point(575, 13);
            this.lblAccountInformation_TO.Name = "lblAccountInformation_TO";
            this.lblAccountInformation_TO.Size = new System.Drawing.Size(148, 13);
            this.lblAccountInformation_TO.TabIndex = 38;
            this.lblAccountInformation_TO.Text = "Информации за сметка ДО";
            // 
            // btnMakeTransaction
            // 
            this.btnMakeTransaction.Location = new System.Drawing.Point(49, 309);
            this.btnMakeTransaction.Name = "btnMakeTransaction";
            this.btnMakeTransaction.Size = new System.Drawing.Size(183, 23);
            this.btnMakeTransaction.TabIndex = 42;
            this.btnMakeTransaction.Text = "Transfer Transacton";
            this.btnMakeTransaction.UseVisualStyleBackColor = true;
            this.btnMakeTransaction.Click += new System.EventHandler(this.btnMakeTransaction_Click);
            // 
            // lblAccount_Base_Number
            // 
            this.lblAccount_Base_Number.AutoSize = true;
            this.lblAccount_Base_Number.Location = new System.Drawing.Point(408, 119);
            this.lblAccount_Base_Number.Name = "lblAccount_Base_Number";
            this.lblAccount_Base_Number.Size = new System.Drawing.Size(86, 13);
            this.lblAccount_Base_Number.TabIndex = 43;
            this.lblAccount_Base_Number.Text = "Број на сметка:";
            // 
            // lblAccount_Base_Number_TO
            // 
            this.lblAccount_Base_Number_TO.AutoSize = true;
            this.lblAccount_Base_Number_TO.Location = new System.Drawing.Point(578, 119);
            this.lblAccount_Base_Number_TO.Name = "lblAccount_Base_Number_TO";
            this.lblAccount_Base_Number_TO.Size = new System.Drawing.Size(86, 13);
            this.lblAccount_Base_Number_TO.TabIndex = 44;
            this.lblAccount_Base_Number_TO.Text = "Број на сметка:";
            // 
            // btnMakeGroupTransaction
            // 
            this.btnMakeGroupTransaction.Location = new System.Drawing.Point(49, 401);
            this.btnMakeGroupTransaction.Name = "btnMakeGroupTransaction";
            this.btnMakeGroupTransaction.Size = new System.Drawing.Size(183, 23);
            this.btnMakeGroupTransaction.TabIndex = 45;
            this.btnMakeGroupTransaction.Text = "Make group transactions";
            this.btnMakeGroupTransaction.UseVisualStyleBackColor = true;
            this.btnMakeGroupTransaction.Click += new System.EventHandler(this.btnMakeGroupTransaction_Click);
            // 
            // lblTotalTransactionCount
            // 
            this.lblTotalTransactionCount.AutoSize = true;
            this.lblTotalTransactionCount.Location = new System.Drawing.Point(49, 431);
            this.lblTotalTransactionCount.Name = "lblTotalTransactionCount";
            this.lblTotalTransactionCount.Size = new System.Drawing.Size(124, 13);
            this.lblTotalTransactionCount.TabIndex = 46;
            this.lblTotalTransactionCount.Text = "Total Transaction Count:";
            // 
            // lblTransactionLogEntrydetails
            // 
            this.lblTransactionLogEntrydetails.AutoSize = true;
            this.lblTransactionLogEntrydetails.Location = new System.Drawing.Point(408, 373);
            this.lblTransactionLogEntrydetails.Name = "lblTransactionLogEntrydetails";
            this.lblTransactionLogEntrydetails.Size = new System.Drawing.Size(141, 13);
            this.lblTransactionLogEntrydetails.TabIndex = 47;
            this.lblTransactionLogEntrydetails.Text = "TransactionLogEntry details:";
            // 
            // lblTLETransactionType
            // 
            this.lblTLETransactionType.AutoSize = true;
            this.lblTLETransactionType.Location = new System.Drawing.Point(411, 390);
            this.lblTLETransactionType.Name = "lblTLETransactionType";
            this.lblTLETransactionType.Size = new System.Drawing.Size(35, 13);
            this.lblTLETransactionType.TabIndex = 48;
            this.lblTLETransactionType.Text = "label1";
            // 
            // lblTLE_CA_amount
            // 
            this.lblTLE_CA_amount.AutoSize = true;
            this.lblTLE_CA_amount.Location = new System.Drawing.Point(411, 411);
            this.lblTLE_CA_amount.Name = "lblTLE_CA_amount";
            this.lblTLE_CA_amount.Size = new System.Drawing.Size(35, 13);
            this.lblTLE_CA_amount.TabIndex = 49;
            this.lblTLE_CA_amount.Text = "label2";
            // 
            // lblTLE_CA_currency
            // 
            this.lblTLE_CA_currency.AutoSize = true;
            this.lblTLE_CA_currency.Location = new System.Drawing.Point(411, 431);
            this.lblTLE_CA_currency.Name = "lblTLE_CA_currency";
            this.lblTLE_CA_currency.Size = new System.Drawing.Size(35, 13);
            this.lblTLE_CA_currency.TabIndex = 50;
            this.lblTLE_CA_currency.Text = "label3";
            // 
            // lblTLE_Accounts
            // 
            this.lblTLE_Accounts.AutoSize = true;
            this.lblTLE_Accounts.Location = new System.Drawing.Point(411, 453);
            this.lblTLE_Accounts.Name = "lblTLE_Accounts";
            this.lblTLE_Accounts.Size = new System.Drawing.Size(35, 13);
            this.lblTLE_Accounts.TabIndex = 51;
            this.lblTLE_Accounts.Text = "label4";
            // 
            // lblTLE_Status
            // 
            this.lblTLE_Status.AutoSize = true;
            this.lblTLE_Status.Location = new System.Drawing.Point(411, 473);
            this.lblTLE_Status.Name = "lblTLE_Status";
            this.lblTLE_Status.Size = new System.Drawing.Size(35, 13);
            this.lblTLE_Status.TabIndex = 52;
            this.lblTLE_Status.Text = "label5";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 554);
            this.Controls.Add(this.lblTLE_Status);
            this.Controls.Add(this.lblTLE_Accounts);
            this.Controls.Add(this.lblTLE_CA_currency);
            this.Controls.Add(this.lblTLE_CA_amount);
            this.Controls.Add(this.lblTLETransactionType);
            this.Controls.Add(this.lblTransactionLogEntrydetails);
            this.Controls.Add(this.lblTotalTransactionCount);
            this.Controls.Add(this.btnMakeGroupTransaction);
            this.Controls.Add(this.lblAccount_Base_Number_TO);
            this.Controls.Add(this.lblAccount_Base_Number);
            this.Controls.Add(this.btnMakeTransaction);
            this.Controls.Add(this.lblAccountCurency_Base_TO);
            this.Controls.Add(this.lblAccountNumber_Base_TO);
            this.Controls.Add(this.lblAccountID_Base_TO);
            this.Controls.Add(this.lblAccountInformation_TO);
            this.Controls.Add(this.lblTransactionAccount_Base_Currency);
            this.Controls.Add(this.lblTransactionAccount_Base_Limit);
            this.Controls.Add(this.lblAccountCurency_Base);
            this.Controls.Add(this.lblAccountNumber_Base);
            this.Controls.Add(this.lblAccountID_Base);
            this.Controls.Add(this.lblDepositAccountUnitOfTime);
            this.Controls.Add(this.lblDepositAccountPeriod);
            this.Controls.Add(this.lblDepositAccountUnit);
            this.Controls.Add(this.lblDepositAccountPercent);
            this.Controls.Add(this.lblDepositAccountEndDate);
            this.Controls.Add(this.lblDepositAccountStartDate);
            this.Controls.Add(this.lblDepositAccountInformation);
            this.Controls.Add(this.lblTranscationAccountInformation);
            this.Controls.Add(this.lblAccountInformation);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.txtUnitOfTimeInterestRate);
            this.Controls.Add(this.txtAmountInterestRate);
            this.Controls.Add(this.txtUnitOfTimePeriod);
            this.Controls.Add(this.txtAmountPeriod);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblAccountLimit);
            this.Controls.Add(this.lblAccountCurrency);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.btnCreateDepositAccount);
            this.Controls.Add(this.btnCreateTransactionAccount);
            this.Name = "frmMain";
            this.Text = "Account Details Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTransactionAccount;
        private System.Windows.Forms.Button btnCreateDepositAccount;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label lblAccountCurrency;
        private System.Windows.Forms.Label lblAccountLimit;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtAmountPeriod;
        private System.Windows.Forms.TextBox txtUnitOfTimePeriod;
        private System.Windows.Forms.TextBox txtAmountInterestRate;
        private System.Windows.Forms.TextBox txtUnitOfTimeInterestRate;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblAccountInformation;
        private System.Windows.Forms.Label lblTranscationAccountInformation;
        private System.Windows.Forms.Label lblDepositAccountInformation;
        private System.Windows.Forms.Label lblDepositAccountStartDate;
        private System.Windows.Forms.Label lblDepositAccountEndDate;
        private System.Windows.Forms.Label lblDepositAccountPercent;
        private System.Windows.Forms.Label lblDepositAccountUnit;
        private System.Windows.Forms.Label lblDepositAccountPeriod;
        private System.Windows.Forms.Label lblDepositAccountUnitOfTime;
        private System.Windows.Forms.Label lblAccountID_Base;
        private System.Windows.Forms.Label lblAccountNumber_Base;
        private System.Windows.Forms.Label lblAccountCurency_Base;
        private System.Windows.Forms.Label lblTransactionAccount_Base_Limit;
        private System.Windows.Forms.Label lblTransactionAccount_Base_Currency;
        private System.Windows.Forms.Label lblAccountCurency_Base_TO;
        private System.Windows.Forms.Label lblAccountNumber_Base_TO;
        private System.Windows.Forms.Label lblAccountID_Base_TO;
        private System.Windows.Forms.Label lblAccountInformation_TO;
        private System.Windows.Forms.Button btnMakeTransaction;
        private System.Windows.Forms.Label lblAccount_Base_Number;
        private System.Windows.Forms.Label lblAccount_Base_Number_TO;
        private System.Windows.Forms.Button btnMakeGroupTransaction;
        private System.Windows.Forms.Label lblTotalTransactionCount;
        private System.Windows.Forms.Label lblTransactionLogEntrydetails;
        private System.Windows.Forms.Label lblTLETransactionType;
        private System.Windows.Forms.Label lblTLE_CA_amount;
        private System.Windows.Forms.Label lblTLE_CA_currency;
        private System.Windows.Forms.Label lblTLE_Accounts;
        private System.Windows.Forms.Label lblTLE_Status;
    }
}

