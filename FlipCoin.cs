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
    /// this is a flip coin class.
    /// </summary>
    class FlipCoin
    {
        /// <summary>
        /// Flips this instance.
        /// </summary>
        public void Flip()
        {
            Console.WriteLine("Enter the number of flip");
            int n = Convert.ToInt32(Console.ReadLine());
            int head = 0, tail = 0;
            Random r = new Random();
            for (int i = 1;i <= n; i++)
            {
                Console.WriteLine("{0} flip", i);
                double randNum = r.NextDouble();
                if(randNum < 0.5)
                {
                    Console.WriteLine("heads");
                    head++;
                }
                else
                {
                    Console.WriteLine("tails");
                    tail++;
                }
            }
            ///  percentage of head and tail.
            int perhead = head * 100 / n; 
            int pertail = tail * 100 / n;
            Console.WriteLine("head percentage :" + perhead);
            Console.WriteLine("tail percentage :" + pertail);

        }
    }
}
