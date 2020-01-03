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
    /// sorting class to bubble sort
    /// </summary>
    class Bubblesort  
    {
        /// <summary>
        /// Sortings this instance.
        /// </summary>
        public void Sorting()
        {
            int[] a = { 23, 11, 45, 65, 34 };
            int n = a.Length;
            int temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j< n-i-1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            for (int i =0; i<a.Length; i++)
            {
                Console.WriteLine("Sorted array " + a[i]);  /// printing the sorting array.
            }
        }

        
    }
}
