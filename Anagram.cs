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
    /// this is a anagram class
    /// </summary>
    class Anagram              
    {
        /// <summary>
        /// Anagram this instance
        /// </summary>
        public void isAnagram()  
        {
            Console.WriteLine("Enter the first string = ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter the second string = ");
            string s2 = Console.ReadLine();
            char[] ch1 = s1.ToLower().ToCharArray();
            char[] ch2 = s2.ToLower().ToCharArray();
            Array.Sort(ch1);    /// sorting the array
            Array.Sort(ch2);    /// sorting the array
            string val1 = new string(ch1);
            string val2 = new string(ch2);
            if (val1 == val2)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("not Anagram");
            }
        }
    }
}
