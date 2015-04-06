using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    /// <summary>
    /// Enumeracija koja ke vodi smetka za tipot na TRANSAKCIJA
    /// TIP-ot na transakcija moze da bide TRANSFER (001) DEBIT (010) i CREDIT(100)
    /// </summary>
    public enum TransactionType
    {
        None = 0,
        Transfer = 1,
        Debit = 2,
        Credit = 4
    }
}
