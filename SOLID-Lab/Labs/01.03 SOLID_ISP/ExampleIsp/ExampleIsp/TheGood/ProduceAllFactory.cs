using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood
{
    public class ProduceAllFactory : IFactory, IMotorBikeFactory, ICarFactory, IBikeFactory
    {
        //koi metodi treba da se implementiraat, a koi Implicitno da se implementiraat?
        public int Paint(int paintColour)
        {
            throw new NotImplementedException();
        }

        public int PaintBike(int paintColour)
        {
            throw new NotImplementedException();
        }

        public int PaintMoto(int paintColour)
        {
            throw new NotImplementedException();
        }

        public int ProduceBody()
        {
            throw new NotImplementedException();
        }

        public int ProduceElectronics()
        {
            throw new NotImplementedException();
        }

        public int ProduceEngine()
        {
            throw new NotImplementedException();
        }

        public int ProduceEngineMoto()
        {
            throw new NotImplementedException();
        }

        public int ProduceFrame()
        {
            throw new NotImplementedException();
        }

        public int ProduceFrameBike()
        {
            throw new NotImplementedException();
        }

        public int ProduceGears()
        {
            throw new NotImplementedException();
        }

        public int ProduceGearsBike()
        {
            throw new NotImplementedException();
        }

        public int ProduceGearsMoto()
        {
            throw new NotImplementedException();
        }

        public int ProduceHandles()
        {
            throw new NotImplementedException();
        }

        public int ProduceHandlesBike()
        {
            throw new NotImplementedException();
        }

        public int ProduceHeadLamps()
        {
            throw new NotImplementedException();
        }

        public int ProduceTank()
        {
            throw new NotImplementedException();
        }

        public int ProduceTankMoto()
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

        int IFactory.StartShift()
        {
            throw new NotImplementedException();
        }

        int IFactory.StopProductionLane()
        {
            throw new NotImplementedException();
        }
    }
}
