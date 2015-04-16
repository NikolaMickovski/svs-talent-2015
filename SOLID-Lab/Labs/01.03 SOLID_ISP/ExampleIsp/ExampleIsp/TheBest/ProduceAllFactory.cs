using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheBest
{
    public class ProduceAllFactory :IFactory, ICarFactory, IBikeFactory, IMotorBikeFactory
    {
        
        
        
        #region IFACTORY
        int IFactory.StartShift()
        {
            throw new NotImplementedException();
        }

        int IFactory.CloseShift()
        {
            throw new NotImplementedException();
        }

        int IFactory.StartProductionLane()
        {
            throw new NotImplementedException();
        }

        int IFactory.StopProductionLane()
        {
            throw new NotImplementedException();
        }
        #endregion

        int ICarFactory.ProduceBody()
        {
            throw new NotImplementedException();
        }

        int ICarFactory.ProduceEngine()
        {
            throw new NotImplementedException();
        }

        int ICarFactory.ProduceGears()
        {
            throw new NotImplementedException();
        }

        int ICarFactory.ProduceHeadLamps()
        {
            throw new NotImplementedException();
        }

        int ICarFactory.ProduceElectronics()
        {
            throw new NotImplementedException();
        }

        int ICarFactory.ProduceTank()
        {
            throw new NotImplementedException();
        }

        int ICarFactory.Paint(int paintColour)
        {
            throw new NotImplementedException();
        }

        int IBikeFactory.ProduceFrame()
        {
            throw new NotImplementedException();
        }

        int IBikeFactory.ProduceHandles()
        {
            throw new NotImplementedException();
        }

        int IBikeFactory.ProduceGears()
        {
            throw new NotImplementedException();
        }

        int IBikeFactory.Paint(int paintColour)
        {
            throw new NotImplementedException();
        }

        int IMotorBikeFactory.ProduceFrame()
        {
            throw new NotImplementedException();
        }

        int IMotorBikeFactory.ProduceHandles()
        {
            throw new NotImplementedException();
        }

        int IMotorBikeFactory.ProduceTank()
        {
            throw new NotImplementedException();
        }

        int IMotorBikeFactory.ProduceEngine()
        {
            throw new NotImplementedException();
        }

        int IMotorBikeFactory.ProduceGears()
        {
            throw new NotImplementedException();
        }

        int IMotorBikeFactory.Paint(int paintColour)
        {
            throw new NotImplementedException();
        }
    }
}
