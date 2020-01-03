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
    /// this is sumofthree class
    /// </summary>
    class sumofthree
    {
        /// <summary>
        /// Iszeroes this instance.
        /// </summary>
        public void iszero()
        {
            int[] a = { 0, 2, -1, 4, -3, -2, 5, -10, 9, 8, -7, 1 };
            int s = a.Length;
            for (int i= 0; i < s; i++)
            {
                for (int j =i+1; j < s; j++)
                {
                    for (int k = j+1; k<s; k++)
                    {
                       
                      
                            if (a[i] + a[j] + a[k] == 0)
                            {
                                Console.WriteLine("the pairs are");
                                Console.WriteLine(a[i]);
                                Console.WriteLine(a[j]);
                                Console.WriteLine(a[k]);
                            }
                    }
                }
            }
        }
    }
}
