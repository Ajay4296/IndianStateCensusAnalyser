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
    /// this is a factorial class
    /// </summary>
    class Factorial
    {
        /// <summary>
        /// The fact
        /// </summary>
        int fact = 1;
        public void isfactorial()
        {
            Console.WriteLine("Enter the number for factorial");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                fact =  (n * fact);
                n--;
                Console.WriteLine("factorial is :" + fact);
                
            }
            
        }
    }
}
