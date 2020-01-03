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
    /// this is a decimal to binary class
    /// </summary>
    class DecimalToBinary 
    {
        /// <summary>
        /// Determines whether this instance is binary.
        /// </summary>
        public void isBinary()
        {
            int[] r = new int[10];
            int i;
            Console.WriteLine("Enter the number to convert");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; n > 0; i++)
            {
                r[i] = n % 2;
                n = n / 2;
            }
            Console.Write("binary of the number ");
            for(i = i-1; i >=0; i--)
            {
                Console.Write(r[i]);
            }
        }
    }
}
