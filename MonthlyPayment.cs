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
    /// this is a monthly payment class
    /// </summary>
    class MonthlyPayment
    {
        /// <summary>
        /// Calculates this instance.
        /// </summary>
        public void Calculate()
        {
            Console.WriteLine("enter the value of P");
            double p=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of Y");
            double y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of R");
            double r = Convert.ToInt32(Console.ReadLine());

            double n = 12 * y;
            double R = r / (12 * 100);

            double payment = (p * r) / (1 - (Math.Pow(1 + R, -n)));
            Console.WriteLine(payment);

        }
    }
}
