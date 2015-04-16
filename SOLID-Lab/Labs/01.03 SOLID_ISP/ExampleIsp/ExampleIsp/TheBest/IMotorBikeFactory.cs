using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheBest
{
    public interface IMotorBikeFactory : IFactory
    {
        /// <summary>
        /// Produces the frame for the motorcycles
        /// </summary>
        /// <returns></returns>
        int ProduceFrame();

        /// <summary>
        /// Produce handles for the motorcycles
        /// </summary>
        /// <returns></returns>
        int ProduceHandles();

        /// <summary>
        /// Produces the tank for the motorcycle
        /// </summary>
        /// <returns></returns>
        int ProduceTank();

        /// <summary>
        /// Produces the engine for the motorcycle
        /// </summary>
        /// <returns></returns>
        int ProduceEngine();

        /// <summary>
        /// Produce the gears for the motorcycle
        /// </summary>
        /// <returns></returns>
        int ProduceGears();

        /// <summary>
        /// Paints the motorcycle
        /// </summary>
        /// <param name="paintColour"></param>
        /// <returns></returns>
        int Paint(int paintColour);
    }
}
