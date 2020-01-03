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
    /// thid is a even class
    /// </summary>
    class Even   
    {
        /// <summary>
        /// Determines whether this instance is even.
        /// </summary>
        public void isEven()
        {
            Console.WriteLine("enter the number");
            int n = Convert.ToInt32(Console.ReadLine());

            if(n%2 == 0)
            {
                Console.WriteLine("number is even number");
            }
            else
            {
                Console.WriteLine("number is not even number");
            }
        }
    }
}
