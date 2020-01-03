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
    /// this is a replacestring class
    /// </summary>
    public class ReplaceString
    {
        /// <summary>
        /// Replaceses this instance.
        /// </summary>
        public void Replaces()
        {         
            string s = "Hello <<UserName>>, How are you?";
            Console.WriteLine("Enter name to replace");



            string name = Console.ReadLine();
            string replace = s.Replace("<<UserName>>", name);
            Console.WriteLine("" + replace);
        }
    }
}
