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
    /// coupan number class
    /// </summary>
    class CoupanNumber
    {
        /// <summary>
        /// Coupans this instance.
        /// </summary>
        public void Coupan()   
        {
            
            Console.WriteLine("enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            string s = "";
            Random r = new Random();
            int no = 0;
            while(s.Length < n)
            {
                int i = r.Next(0, n);
                no++;
                if(s.Contains(i.ToString())== false)
                {
                    s = s + 1;
                }
            }
            Console.WriteLine("nunber of coupan number generated" + no);
            for (int i = 0; i <s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
    }
}
