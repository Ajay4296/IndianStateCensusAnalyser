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
    /// this is a class of daysofweeks
    /// </summary>
    class DayofWeeks
    {
        /// <summary>
        /// Calenders this instance.
        /// </summary>
        public void Calender()
        {
            Console.WriteLine("enter the date");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the month ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the year");
            int y = Convert.ToInt32(Console.ReadLine());
            int y0 = y - (14 - m) / 12;
            int x = y0 +y0 / 4 - y0 / 100 + y0 / 400;
            int m0= m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            Console.WriteLine(" date is" + d0);

            if (m>12 || d > 31)
            {
                Console.WriteLine("invalid date and year");
                return;
            }
            switch (m0)
            {

                case 1:
                    Console.WriteLine("january");
                    break;
                case 2:
                    Console.WriteLine("february");
                    break;
                case 3:
                    Console.WriteLine("march");
                    break;
                case 4:
                    Console.WriteLine("april ");
                    break;
                case 5:
                    Console.WriteLine("may");
                    break;
                case 6:
                    Console.WriteLine("june   ");
                    break;
                case 7:
                    Console.WriteLine("july");
                    break;
                case 8:
                    Console.WriteLine("august ");
                    break;
                case 9:
                    Console.WriteLine("september");
                    break;
                case 10:
                    Console.WriteLine("october");
                    break;
                case 11:
                    Console.WriteLine("november");
                    break;
                case 12:
                    Console.WriteLine("december");
                    break;
                default:
                    Console.WriteLine("invalid case");
                    break;
            }
            switch (d0)
            {
                case 1:
                    Console.WriteLine("monday ");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            }

        }
    }
}
