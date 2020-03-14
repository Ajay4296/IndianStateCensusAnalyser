using System;
using System.IO;
using System.Collections.Generic;
namespace IndianCensusInformation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] lines = File.ReadAllLines(@"C:\Users\Bridgelabz\Downloads\StateCensusData.csv");
            string[] sortLines = StateCensusAnalyser.SortFileAlfabetically(lines);

            Console.WriteLine("string in alfabetical order");
            for (int i = 0; i <sortLines.Length - 1; i++)
            {
                Console.WriteLine(sortLines[i] + "");
            }
            File.WriteAllLines(@"C:\Users\Bridgelabz\Downloads\SortedCSV.csv", sortLines);
            StateCensusAnalyser.ConvertcsvtoJSON();

        }
    }
}
