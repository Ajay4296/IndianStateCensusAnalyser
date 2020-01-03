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
    /// this is a class Powerof2
    /// </summary>
    class Powerof2
    {
        /// <summary>
        /// Powers this instance.
        /// </summary>
        public void Power()
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n<0 || n > 31)
            {
                Console.WriteLine("enter number between 0 and 31");
                return;
            }
            int i = 1;
            while(Math.Pow(2,i) <= Math.Pow(2,i))
            {
                Console.WriteLine("2^ {0} = {1}", i, Math.Pow(2, i));
                i++;
                break;
            }
        }
    }
}
