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
    /// this is a class leapyear
    /// </summary>
    class LeapYear
    {
        /// <summary>
        /// Determines whether [is leap year].
        /// </summary>
        public void isLeapYear()
        {
            Console.WriteLine("enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            while (year!= 0)
            {
                if((year%4==0) && (year % 100 !=0) || (year % 400 == 0))
                {
                    Console.WriteLine("year is a leap year");
                }
                else
                {
                    Console.WriteLine("year is not a leap year");
                }
                break;
            }
        }
    }
}
