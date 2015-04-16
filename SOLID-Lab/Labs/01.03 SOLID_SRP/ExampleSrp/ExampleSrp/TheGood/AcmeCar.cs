using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    /// <summary>
    /// The GOOD - use static classes
    /// EVEN BETTER - implement Singletn in the static classes
    /// </summary>
    public class AcmeCar
    {
        public LockState IsLocked { get; private set; }
        #region LOCK METHOD
        public void Lock()
        {
            try
            {
                this.IsLocked = LockState.Locked;
                //za lokalno logiranje se grizi druga klasa
                Make_PC_Log.ComputerLogChangeState("The car has been locked\n");
            }
            catch(Exception e)
            {
                //za logiranje vo Cloud se grizi druga klasa
                Make_Cloud_Log.Inform_Error("While locking the car, this happened: "+e.Message);
            }
        }
        #endregion

        #region UNLOCK METHOD
        public void Unlock()
        {
            try
            {
                this.IsLocked = LockState.Unlocked;
                Make_PC_Log.ComputerLogChangeState("The car has been unlocked\n");
            }
            catch (Exception e)
            {
                Make_Cloud_Log.Inform_Error("While unlocking the car, this happened: " + e.Message);
            }
        }
        #endregion

    }
}
