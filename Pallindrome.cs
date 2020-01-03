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
    /// class pallindrome to find the pallindrome number.
    /// </summary>
    class Pallindrome
    {
        /// <summary>
        /// Determines whether this instance is pallindrome.
        /// </summary>
        public void isPallindrome()
        {
            int num, r, sum = 0;
            Console.WriteLine("enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            num = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum * 10 + r;
                n = n / 10;
            }
            if (sum == num)
            {
                Console.WriteLine("number is pallindrome ");
            }
            else
            {
                Console.WriteLine("number is not pallindrome");
            }
        }
    }
}
