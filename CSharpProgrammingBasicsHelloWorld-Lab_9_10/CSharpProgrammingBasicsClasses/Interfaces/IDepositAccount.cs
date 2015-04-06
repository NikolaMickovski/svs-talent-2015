using System;
namespace CSharpProgrammingBasicsClasses
{
    /// <summary>
    /// Interface za DepositeAccount
    /// </summary>
    public interface IDepositAccount : IAccount
    {
        DateTime EndDate { get; }
        InterestRate Interest { get; }
        TimePeriod Period { get; }
        DateTime StartDate { get; }
        ITransactionAccount TransactionAccount { get; }
    }
}
