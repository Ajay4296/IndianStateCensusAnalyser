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
    /// this is a class of insertionsort
    /// </summary>
    class InsertionSort
    {
        /// <summary>
        /// Sortings the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        public static int[] sorting(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (a[j] > a[j+1])
                    {
                        int temp = a[j];
                        a[j] = a[j+1];
                        a[j+1] = temp;
                    }
                }
            }
            return a;
        }
        public static void inputArray(int[] a)
        {
            foreach (int i in a)
            {
                Console.Write(i.ToString() + "  ");
            }
        }
        public static int[] insertionsortbyshift(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int j;
                var value = a[i];
                for (j= i; j > 0; j--)
                {
                    if (a[j-1] > value)
                    {
                        a[j] = a[j - 1];
                    }
                }
                a[j] = value;
            }
            return a;
        }
    }
}
