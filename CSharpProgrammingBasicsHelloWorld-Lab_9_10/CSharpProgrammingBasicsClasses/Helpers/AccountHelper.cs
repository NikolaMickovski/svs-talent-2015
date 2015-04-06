﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    /// <summary>
    /// Helper klasa koja generira nov (sleden) INT broj za ID na Account
    /// </summary>
    public static class AccountHelper
    {
        /// <summary>
        /// Field od tip INT
        /// </summary>
        private static int s_Account_ID;
        /// <summary>
        /// Static method koj go vraka s_Account_ID;
        /// </summary>
        /// <returns>s_Account_ID</returns>
        public static int GenerateAccountID ()
        {
            s_Account_ID++;
            return s_Account_ID;
        }
        public static string GenerateAccountNumber(Type accountType, long accountID)
        {
            if (accountType is TransactionAccount) return "TR0000" + accountID;
            if(accountType is DepositAccount) return "DP0000" + accountID;
            if (accountType is LoanAccount) return "LN0000" + accountID;
            return "n/a";
        }
        static AccountHelper()
        {
            s_Account_ID = 0;
        }
    }
}