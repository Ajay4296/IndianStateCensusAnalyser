// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Rathore"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
namespace AlgorithmProgram
{
    /// <summary>
    /// this is a swapnibble class
    /// </summary>
    class Swapnibbles
    {
        /// <summary>
        /// Determines whether the specified x is swap.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <returns></returns>
        public static int isSwap(int x)
        {
             return ((x & 0x0F) << 4 |
                    (x & 0xF0) >> 4);
        }
    }
}
