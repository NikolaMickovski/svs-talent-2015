using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    /// <summary>
    /// Klasa koja ke se spravuva so nadminat limit na Transakciska smetka
    /// </summary>
    public class TransactionLimitExceeded : ApplicationException
    {
        public string ErrorCode { get; set; }
        TransactionLimitExceeded(string ec)
        {
            this.ErrorCode = ec;
        }
    }
}
