﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood
{
    /// <summary>
    /// A MOTORBIKE PRODUCING FACTORY
    /// - bidejki ova e fabrika za motori, iminjata na metodite
    /// ne mora da imaat i Moto vo niv - toa e sredeno vo The Best
    /// </summary>
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
        int ProduceTankMoto();

        /// <summary>
        /// Produces the engine for the motorcycle
        /// </summary>
        /// <returns></returns>
        int ProduceEngineMoto();

        /// <summary>
        /// Produce the gears for the motorcycle
        /// </summary>
        /// <returns></returns>
        int ProduceGearsMoto();

        /// <summary>
        /// Paints the motorcycle
        /// </summary>
        /// <param name="paintColour"></param>
        /// <returns></returns>
        int PaintMoto(int paintColour);
    }
}
