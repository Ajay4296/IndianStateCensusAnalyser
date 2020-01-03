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
    /// this is a rolldice class
    /// </summary>
    class Rolldie
    {
        /// <summary>
        /// dice this rolldie
        /// </summary>
        public void Dice()
        {
            Random r = new Random();
            int f1 = 0, f2 = 0, f3 = 0, f4 = 0, f5 = 0, f6 = 0, face;
            for (int i = 0; i <= 6000; i++)
            {
                int randNum = r.Next();
                face = 1 + r.Next(6);
                switch (face)
                {
                    case 1:
                        ++f1;
                        break;
                    case 2:
                        ++f2;
                        break;
                    case 3:
                        ++f3;
                        break;
                    case 4:
                        ++f4;
                        break;
                    case 5:
                        ++f5;
                        break;
                    case 6:
                        ++f6;
                        break;
                }
            }
            Console.WriteLine("face\tFrequency" + f1, f2, f3, f4, f5, f6);
        }
    }
}
