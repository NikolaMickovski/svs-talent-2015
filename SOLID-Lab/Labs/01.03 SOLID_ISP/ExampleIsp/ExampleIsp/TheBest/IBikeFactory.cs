using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheBest
{
    public interface IBikeFactory : IFactory
    {
        /// <summary>
        /// Produces the frame for the bikes
        /// </summary>
        /// <returns></returns>
        int ProduceFrame();

        /// <summary>
        /// Produce handles for the bikes
        /// </summary>
        /// <returns></returns>
        int ProduceHandles();

        /// <summary>
        /// Produce gears for the bikes
        /// </summary>
        /// <returns></returns>
        int ProduceGears();

        /// <summary>
        /// Paints the bike
        /// </summary>
        /// <param name="paintColour"></param>
        /// <returns></returns>
        int Paint(int paintColour);
    }
}
