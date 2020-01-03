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
    /// this is a prime class
    /// </summary>
    class Prime
    {
        /// <summary>
        /// Determines whether this instance is prime.
        /// </summary>
        public void isPrime()
        {
            int count = 0;
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i= 2; i <= n; i++)
            {
                if(n%i == 0)
                {
                    count++;
                }
            }
            if(count == 1)
            {
                Console.WriteLine("number is prime");
            }
            else
            {
                Console.WriteLine("number is not prime");
            }
        }
    }
}
