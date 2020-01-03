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
    /// this is a 2d array class.
    /// </summary>
    class _2dArray    
    {
        /// <summary>
        /// Prints the array.
        /// </summary>
        public void PrintArray()     
        {
            Console.WriteLine("enter the number of rows");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of columns");
            int c = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[r, c];
            try     /// using try catch method to avoid exception.
            {
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        Console.WriteLine("enter the number");
                        a[i, j] = Convert.ToInt32(Console.ReadLine());

                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.WriteLine("the value in array are");
            for (int i=0;i< r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(a[i, j]+ " ");  /// printing the sorted 2d array.
                    
                }
                Console.WriteLine();
            }
        }
    }
}
