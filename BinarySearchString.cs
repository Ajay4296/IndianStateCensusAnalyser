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
    /// this is a binary search string class
    /// </summary>
    class BinarySearchString
    {
        /// <summary>
        /// Searches the specified s.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="x">The x.</param>
        /// <returns></returns>
        public int search(string[] s, string x)
        {
            {
                int l = 0, r = s.Length;
                while (l <= r - 1)
                {
                    int m = l + (r - l) / 2;
                    int res = x.CompareTo(s[m]);

                    if (res == 0)

                        return m;


                    if (res > 0)
                        l = m + 1;


                    else
                        r = m - 1;
                }

                return -1;

            }


        }
    }
}
