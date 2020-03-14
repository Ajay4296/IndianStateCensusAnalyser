using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ChoETL;

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
        public static string[] SortFileAlfabetically(string[] str)
        {
            string temp;
            for(int i=1;i<str.Length-1;i++)
            {
               for(int j =i+1;j<str.Length;j++)
                {
                    
                    if(str[j].CompareTo(str[i])<0)
                    {
                        temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;
                    }
                }
                
            }
            return str;
        }
        public static void ConvertcsvtoJSON()
        {
            string re = File.ReadAllText(@"C:\Users\Bridgelabz\Downloads\SortedCSV.csv");
            StringBuilder sb = new StringBuilder();
            using (var p = ChoCSVReader.LoadText(re).WithFirstLineHeader())
            {
                using var w = new ChoJSONWriter(sb);
                w.Write(p);
            }

            File.WriteAllText(@"C:\IndianCensusInformation\Ajay\IndianCensusInformation\tsconfig1.json", sb.ToString());
        }
    }
}
