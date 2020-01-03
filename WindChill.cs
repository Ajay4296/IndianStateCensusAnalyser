// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Rathore"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
namespace Program.cs
{
    /// <summary>
    /// this is a windchill class
    /// </summary>
    class WindChill
    {
        /// <summary>
        /// Chills this instance.
        /// </summary>
        public void Chill()
        {
            Console.WriteLine("Enter the temperature in Fahrenheit");
            double t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the speed in miles per hour");
            double v = Convert.ToDouble(Console.ReadLine());
            double w = 0;

            if(t>50 || (v > 120 && v < 3))
            {
                Console.WriteLine("enter data is not valid");
            }
            else
            {
                w = 35.74 + .6215 * t + (0.4725 * t - 37.75) * Math.Pow(v, 0.16);
            }
            Console.WriteLine("the temperature is :" + t);
            Console.WriteLine("the speed of windchill is :" + v);
            Console.WriteLine("the effective temperature of wind chill is :" + w);
        }
    }
}
