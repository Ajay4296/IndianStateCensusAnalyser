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
    /// this is a primerange class
    /// </summary>
    class Primerange
    {
        /// <summary>
        /// Isprimes this instance.
        /// </summary>
        public void isprime()
        {
            Console.WriteLine("enter the start point");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the end point");
            int m = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int num, r, sum = 0;
            for (int i = 2; i <= m; i++)
            {
                count = 0;
                for (int j= 2; j<=i/2; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                num = i;
                while (i > 0)
                {
                    r = i % 10;
                    sum = sum * 10 + i;
                    i = i / 10;
                }
                if(count == 0 && sum == num)
                {
                    Console.WriteLine(i + " ");
                }
                
                
            }
        }
    }
}
