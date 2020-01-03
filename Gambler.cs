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
    /// this is a gambler class 
    /// </summary>
    class Gambler
    {
        /// <summary>
        /// Determines whether this instance is gambler.
        /// </summary>
         public void isGambler()
        {
            Console.WriteLine("Enter the stack");
            int stake = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the goal");
            int goal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the trials");
            int trials = Convert.ToInt32(Console.ReadLine());
            int bet = 0; 
            int wins = 0;
            for ( int t = 0; t<= trials; t++)
            {
                int cash = stake;

                while (cash>0 && cash < goal)
                {
                    bet++;
                    Random r = new Random();
                    if (r.Next() < 0.5)
                    {
                        cash++;
                    }
                    else
                    {
                        cash--;
                    }
                }
                if (cash == goal)
                    wins++;
            }
            Console.WriteLine(wins + "wins of" + trials);
            Console.WriteLine("percentage of game winner" + (wins * 100) / trials);
            Console.WriteLine("average of bets" + 1.0 * bet / trials);
        }
    }
}
