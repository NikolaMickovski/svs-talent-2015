using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheAvg
{
    public class CarCloudLog : AcmeCar
    {
        public override void Lock()
        {
            try
            {
                //
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
                //
            }
            catch (Exception)
            {
                Console.WriteLine("There was an error unlocking the car!");
            }
        }
    }
}
