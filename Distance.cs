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
    ///  this is a distance class
    /// </summary>
    class Distance
    {
        /// <summary>
        /// The x
        /// </summary>
        int x = 0, y = 0;
        public void Dist()
        {
            Console.WriteLine("enter the point1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the point2");
            int y1 = Convert.ToInt32(Console.ReadLine());
            double z1 = Math.Pow(x1 - x, 2);
            double z2 = Math.Pow(y1 - y, 2);
            double z = Math.Sqrt(z1 + z2);
            Console.WriteLine(z);
        }
    }
}
