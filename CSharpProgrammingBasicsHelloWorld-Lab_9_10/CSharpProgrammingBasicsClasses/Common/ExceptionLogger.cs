using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsClasses
{
    /// <summary>
    /// Klasa koja nasleduva od ApplicationExc
    /// a treba da ja pecati vo konsola VNATRESNATA greska koja nastanala vo stack od 2 Greski
    /// </summary>
    public class ExceptionLogger : ApplicationException
    {
            public static void LogException(Exception e){
            Console.WriteLine("Excepton Logger was called: " + e.Message+"\n");
        }
        
    
    }    
}
