using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    /// <summary>
    /// Enumeracija koja go sledi procesot na TRANSAKCIJATA
    /// </summary>
    public enum TransactionStatus
    {
        None = 0,
        InProcess = 1,
        Completed = 2,
        CompletedWithWarning = 4,
        Failed = 8
    }
}
