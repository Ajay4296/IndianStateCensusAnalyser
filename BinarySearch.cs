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
    /// binary search class
    /// </summary>
    class BinarySearch          
    {
        /// <summary>
        /// Binaries the specified arra.
        /// </summary>
        /// <param name="arra">The arra.</param>
        /// <param name="L">The l.</param>
        /// <param name="r">The r.</param>
        /// <param name="x">The x.</param>
        /// <returns></returns>
        public static int binary(int[] arra, int L, int r, int x)
        {
            if (r > L)
            {
                int mid = L + (r - L) / 2;
                if (arra[mid] == x)
                    return mid;
                if (arra[mid] > x)
                    return binary(arra, L, mid - 1, x);
                else
                    return binary(arra, mid + 1 , r , x);

            }
            return -1;

        }
    }
}



    