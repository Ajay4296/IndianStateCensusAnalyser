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
    /// this is a class quadratic. 
    /// </summary>
    class Quadratic
    {
        /// <summary>
        /// Rootses this instance.
        /// </summary>
        public void Roots()
        {
            Console.WriteLine("Enter the value of a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of c");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Equation is :" + a + "x2 + " + b + "x + " + c);

            int delta = b * b - 4 * a * c;
            double d = Math.Sqrt(delta);

            double x1 = (-b + d) / 2 * a;
            double x2 = (-b - d) / 2 * a;

            Console.WriteLine("the roots of equation are :" + x1, +x2);

        }
    }
}
