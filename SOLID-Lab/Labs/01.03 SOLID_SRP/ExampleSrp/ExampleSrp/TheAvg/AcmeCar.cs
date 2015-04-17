using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheAvg
{
    /// <summary>
    /// THE AVERAGE - use Inheritance
    /// </summary>
    public class AcmeCar
    {
        public LockState IsLocked { get; private set; }
        #region LOCK METHOD
        public virtual void Lock()
        {
            try
            {
                //
            }
            catch(Exception)
            {
                Console.WriteLine("There was an error locking the car!");
            }
        }
        #endregion

        #region UNLOCK METHOD
        public virtual void Unlock()
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
        #endregion

    }
}
