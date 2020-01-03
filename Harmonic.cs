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
    /// this is a harmonic class.
    /// </summary>
    class Harmonic
    {
        /// <summary>
        /// Determines whether this instance is harmonic.
        /// </summary>
        public void isHarmonic()
        {
            Console.WriteLine("enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            double num = 0;
            for (double i = 0; i <=n; i++)
            {
                num =num + 1 / i;
            }
            Console.WriteLine("the nth harmonic num= {0}", num);
        }
    }
}
