// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Rathore"/>
// ----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
namespace Program.cs
{
    /// <summary>
    /// this is a armstrong class
    /// </summary>
    class Armstrong
    {
        /// <summary>
        /// The Armstrong instance
        /// </summary>
        int r;
        public void isArmstrong()       
        {
            int num, sum = 0;
            Console.WriteLine("enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            num = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + r * r * r;
                n = n / 10;
              
            }
            if (sum == num)
            {
                Console.WriteLine("number is not armstromg");
            }
            else
            {
                Console.WriteLine("number is armstrong");
            }
        }
    }
}
