using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood
{
    public class ProduceCarFactory : ICarFactory
    {
        public int CloseShift()
        {
            throw new NotImplementedException();
        }

        public int Paint(int paintColour)
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

        public int ProduceGears()
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

        public int StartProductionLane()
        {
            throw new NotImplementedException();
        }

        public int StartShift()
        {
            throw new NotImplementedException();
        }

        public int StopProductionLane()
        {
            throw new NotImplementedException();
        }
    }
}
