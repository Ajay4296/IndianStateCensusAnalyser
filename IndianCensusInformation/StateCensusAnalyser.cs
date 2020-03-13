using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace IndianCensusInformation
{
   public class StateCensusAnalyser
    {
        public static string CountLines(string CSVPath)
        {
            int Count = 0;

            foreach (string line in File.ReadLines(CSVPath))
            {
                Console.WriteLine(line);
                Count++;
            }
            return Count.ToString();
        }
    }
}
