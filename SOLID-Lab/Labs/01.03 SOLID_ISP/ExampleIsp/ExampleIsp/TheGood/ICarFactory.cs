using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood
{
    /// <summary>
    /// Ovoj interface gi ima site metodi koi gi ima vo IFactory
    /// </summary>
    public interface ICarFactory : IFactory
    {
        /// <summary>
        /// A CAR PRODUCING FACTORY        
        /// </summary>
        int ProduceBody();

        int ProduceEngine();

        int ProduceGears();

        int ProduceHeadLamps();

        int ProduceElectronics();

        /// <summary>
        /// Produce tanks for the car
        /// </summary>
        /// <returns></returns>
        int ProduceTank();

        //the painters
        int Paint(int paintColour);
    }
}
