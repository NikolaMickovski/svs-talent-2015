using System;
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
       
        /// <summary>
        /// Metod koj treba da postavi ACCOUNT.NUMBER
        /// </summary>
        /// <param name="accountType"></param>
        /// <param name="accountID"></param>
        /// <returns></returns>
        public static string GenerateAccountNumber(Type accountType, long accountID)
        {
            if (accountType == typeof(TransactionAccount)) return "TR0000" + accountID;
            if(accountType == typeof( DepositAccount)) return "DP0000" + accountID;
            if (accountType == typeof(LoanAccount)) return "LN0000" + accountID;
            return "n/a";
        }


        public static string GenerateAccountNumber <TypeOfAccount> (long accountID) where TypeOfAccount : IAccount, new ()
        {
            TypeOfAccount T = new TypeOfAccount();
           // Type generic = 
            return AccountHelper.GenerateAccountNumber(T.GetType(),accountID);
        }

        /// <summary>
        /// Static Constructor which helps implementing SINGLETON PATTERNs
        /// </summary>
        static AccountHelper()
        {
            s_Account_ID = 0;
        }
            


    }
}
