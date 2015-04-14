using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    /// <summary>
    /// Klasa koja ke e odgovorna za sledenje na DEBIT transakciite,
    /// za toa dali nekoja smetka stignala do 0 ili pod 0
    /// </summary>
    public class LimitReached:ApplicationException
    {
        public string ErrorCode { get; set; }
        public LimitReached(string msg)
        {
            ErrorCode = msg;
        }
    }
}
