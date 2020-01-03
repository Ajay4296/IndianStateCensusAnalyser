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
    /// this is sqrt class
    /// </summary>
    class Sqrt
    {
        /// <summary>
        /// Determines whether this instance is SQRT.
        /// </summary>
        public void isSqrt()
        {
            Console.WriteLine("Enter the number");
            double c = Convert.ToInt32(Console.ReadLine());

            double t = c;
            double epilsion = 1e-15;

            while (Math.Abs(t-c/t) >epilsion * t)
            {
                t = (c / t + t) / 2.0;
            }
            Console.WriteLine(t);
        }
    }
}
