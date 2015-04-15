using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheAvg
{
    public class CarComputerLog : AcmeCar
    {
        public override void Lock()
        {
            try
            {
                Console.WriteLine("==============Car changed state to: LOCK\n");
            }
            catch (Exception)
            {
                Console.WriteLine("There was an error locking the car!");
            }
        }


        
        public override void Unlock()
        {
            try
            {
                Console.WriteLine("==============Car changed state to: UNLOCK\n");
            }
            catch (Exception)
            {
                Console.WriteLine("There was an error unlocking the car!");
            }
        }
       
    }
}
