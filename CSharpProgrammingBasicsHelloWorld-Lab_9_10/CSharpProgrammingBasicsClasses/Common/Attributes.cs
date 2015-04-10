using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    
        /// <summary>
        /// Klasa koja nasleduva od System.Attribute
        /// </summary>
        /// 
        [AttributeUsage(AttributeTargets.Class)]
        public class AccountMetadataAttribute : System.Attribute
        {
            
            public string AccountDescription {get; set;}
            
            public string AccountLimitations { get; set; }
        }

        [AttributeUsage(AttributeTargets.Property|AttributeTargets.Field)]
        public class FormatRestrictionAttribute : System.Attribute
        {
            public string formatString {get; set; }
            public int MaxLength { get; set; }
        }
    
}
