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
    /// this is vending class
    /// </summary>
    class Vending
    {
        /// <summary>
        /// Ismachines the specified amount.
        /// </summary>
        /// <param name="amount">The amount.</param>
        public void ismachine(int amount)
        {
            int notes = 0;
            Console.WriteLine("amount is :" + amount);
            if (amount == 0)
            {
                return;
            }
            if(amount> 1000)
            {
                notes += amount / 1000;
                Console.WriteLine("number of 1000 notes are:" + notes);
                if (amount == 0)
                    return;
                else
                    ismachine(amount % 1000);
            }
            else if(amount > 500)
            {
                notes += amount / 500;
                Console.WriteLine("number of 500 notes are: " + notes);
                if (amount == 0)
                    return;
                else
                    ismachine(amount / 500);
            }
            else if (amount > 200)
            {
                notes += amount / 200;
                Console.WriteLine("number of 200 notes are:" + notes);
                if (amount == 0)
                    return;
                else
                    ismachine(amount % 200);
            }
            else if (amount > 100)
            {
                notes += amount / 100;
                Console.WriteLine("number of 100 notes are:" + notes);
                if (amount == 0)
                    return;
                else
                    ismachine(amount % 100);
            }
            else if (amount > 50)
            {
                notes += amount / 50;
                Console.WriteLine("number of 50 notes are:" + notes);
                if (amount == 0)
                    return;
                else
                    ismachine(amount % 50);
            }
            else if (amount > 10)
            {
                notes += amount / 10;
                Console.WriteLine("number of 10 notes are:" + notes);
                if (amount == 0)
                    return;
                else
                    ismachine(amount % 10);
            }
            else if (amount > 1000)
            {
                notes += amount / 5;
                Console.WriteLine("number of 5 notes are:" + notes);
                if (amount == 5)
                    return;
                else
                    ismachine(amount % 5);
            }
            else if (amount > 2)
            {
                notes += amount / 2;
                Console.WriteLine("number of 2 notes are:" + notes);
                if (amount == 0)
                    return;
                else
                    ismachine(amount % 2);
            }
            else if (amount > 1000)
            {
                notes += amount / 1;
                Console.WriteLine("number of 1 notes are:" + notes);
                if (amount == 0)
                    return;
                else
                    ismachine(amount % 1);
            }
        }
    }
}


