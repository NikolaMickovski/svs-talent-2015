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
        public string IP_PC {get; set;}

        public AcmeCar(ILog logger_Cloud, ILog Logger_PC )
        {
            if (logger_PC.GetType() == typeof(IPCLog)) this.logger_PC = (IPCLog)logger;
            if (logger_PC.GetType() == typeof(ICloudPC)) this.logger = (ICloudLog)logger;
            sold = true;
            IP_PC = pc;
        }
        #region LOCK METHOD



        public void Lock()
        {
            try
            {
                this.IsLocked = LockState.Locked;
                logger.Log("On state changed: Locked");
            }
            catch(Exception e)
            {
                logger.Log("Greska pri zaklucuvanje "+e.Message);
            }
        }
        #endregion

        #region UNLOCK METHOD
        public void Unlock()
        {
            try
            {
                this.IsLocked = LockState.Unlocked;
                logger.Log("On state changed: Unlocked");
            }
            catch (Exception e)
            {
                logger.Log("Greska pri otklucuvanje "+e.Message);
            }
        }
        #endregion

       
    }
}
