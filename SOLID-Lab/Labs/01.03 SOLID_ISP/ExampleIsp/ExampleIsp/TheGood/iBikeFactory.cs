using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood
{
    /// <summary>
    /// A BIKE PRODUCING FACTORY
    /// - bidejki ova e fabrika za velosipedi, iminjata na metodite
    /// ne mora da imaat i Bike vo niv - toa e sredeno vo The Best
    /// </summary>
    public interface IBikeFactory : IFactory
    {
        /// <summary>
        /// Produces the frame for the bikes
        /// </summary>
        /// <returns></returns>
        int ProduceFrameBike();

        /// <summary>
        /// Produce handles for the bikes
        /// </summary>
        /// <returns></returns>
        int ProduceHandlesBike();

        /// <summary>
        /// Produce gears for the bikes
        /// </summary>
        /// <returns></returns>
        int ProduceGearsBike();

        /// <summary>
        /// Paints the bike
        /// </summary>
        /// <param name="paintColour"></param>
        /// <returns></returns>
        int PaintBike(int paintColour);

    }
}
