using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    /// <summary>
    /// Struktura koja e za opredelena namena
    /// </summary>
    public struct CurrencyAmount
    {
        /// <summary>
        /// Amount ili  VISINA na valutata vo daden mig
        /// </summary>
        public decimal amount;

        /// <summary>
        /// Ime na samata valuta
        /// </summary>
        public string currency;       

        public CurrencyAmount(decimal amount, string currency)
        {
            // TODO: Complete member initialization
            this.amount = amount;
            this.currency = currency;
        }

    }
}
