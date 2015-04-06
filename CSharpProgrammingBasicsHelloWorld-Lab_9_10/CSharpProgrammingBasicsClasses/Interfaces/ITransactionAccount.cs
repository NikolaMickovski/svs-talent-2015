using System;
namespace CSharpProgrammingBasicsClasses
{
    /// <summary>
    /// Interface za TransactionAccount
    /// </summary>
    public interface ITransactionAccount : IAccount
    {
        CurrencyAmount Limit { get; }
    }
}
