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
    /// this is a temperature class
    /// </summary>
    class Temperature
    {
        /// <summary>
        /// Conversioms this instance.
        /// </summary>
        public void conversiom()
        {
            Console.WriteLine("enter the temperature in fahrenhiet");
            double t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the temperature in celcius");
            double r = Convert.ToInt32(Console.ReadLine());
            double fat = (t * 9 / 5) + 32;
            double cel = (r - 32) * 5 / 9;
            Console.WriteLine("temperature in fahrenhiet is:" + fat);
            Console.WriteLine("temperature in celcius is :" + cel);
        }
    }
}
