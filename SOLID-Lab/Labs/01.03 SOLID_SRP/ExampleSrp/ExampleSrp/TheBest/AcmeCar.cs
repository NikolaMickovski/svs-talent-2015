using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheBest
{
   
    public class AcmeCar
    {
        public LockState IsLocked { get; private set; }
        public bool sold { get; private set; }
        ILog logger_Cloud { get; set; }
        ILog logger_PC { get; set; }
        

        /// <summary>
        /// Public Constructor
        /// </summary>
        /// <param name="logger_Cloud">Logger for Cloud</param>
        /// <param name="Logger_PC">Logger containing the IP address of the PC to log on</param>
        public AcmeCar(ILog logger_Cloud, ILog Logger_PC )
        {
            if (!logger_Cloud.Equals(null) && logger_Cloud.GetType() == typeof(ICloudLog))
            {
                this.logger_PC = (IPCLog)logger_Cloud;
            }

            if (!logger_PC.Equals(null) && logger_PC.GetType() == typeof(IPCLog))
            {
                this.logger_PC = (ICloudLog)Logger_PC;
            }
            sold = true;
            
        }
        #region LOCK METHOD

        public void Lock()
        {
            try
            {
                this.IsLocked = LockState.Locked;
                // Koristi metoda od IPCLog
                ((IPCLog)logger_PC).ComputerLogChangeState("On state changed: Locked");
                //Koristi metoda od ILog
                logger_PC.Log("/");
            }
            catch(Exception e)
            {
                //Koristi metoda od ICloudLog
                ((ICloudLog)logger_Cloud).Inform_Error("Greska pri zaklucuvanje "+e.Message);
                //koristi metoda od ILog
                logger_Cloud.Log("/");
            }
        }
        #endregion

        #region UNLOCK METHOD
        public void Unlock()
        {
            try
            {
                this.IsLocked = LockState.Unlocked;
                // Koristi metoda od IPCLog
                ((IPCLog)logger_PC).ComputerLogChangeState("On state changed: Unlocked");
                //Koristi metoda od ILog
                logger_PC.Log("/");
            }
            catch (Exception e)
            {
                //Koristi metoda od ICloudLog
                ((ICloudLog)logger_Cloud).Inform_Error("Greska pri otklucuvanje " + e.Message);
                //koristi metoda od ILog
                logger_Cloud.Log("/");
            }
        }
        #endregion

       
    }
}
