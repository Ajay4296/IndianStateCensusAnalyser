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
    /// this is a fibonacci class
    /// </summary>
    class Fibonacci    
    {
        /// <summary>
        /// a
        /// </summary>
        int a = 0, b = 1, i, c;
        public void isFibo()
        {
            Console.WriteLine("enter the number till you want series");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + " " + b); /// printing the first two term of series.
            while (i <n - 2)
            {
                c = a + b;
                Console.WriteLine(" " + c);
                a = b;
                b = c;
                i++;
            }

        }
      
    }
}
