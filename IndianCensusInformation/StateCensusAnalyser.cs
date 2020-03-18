using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;
using ChoETL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json.Serialization;
using System.Text.Encodings;
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
        public static void ConvertcsvtoJSONStateJson()
        {
            string re = File.ReadAllText(@"C:\Users\Bridgelabz\Downloads\StateCensusData.csv");
            StringBuilder sb = new StringBuilder();
            using (var p = ChoCSVReader.LoadText(re).WithFirstLineHeader())
            {
                using var w = new ChoJSONWriter(sb);
                w.Write(p);
            }

            File.WriteAllText(@"C:\IndianCensusInformation\Ajay\IndianCensusInformation\jsconfig1.json", sb.ToString());
        }
        public static void ConvertcsvtoJSONFormat()
        {
            string re = File.ReadAllText(@"C:\Users\Bridgelabz\Downloads\StateCensusData.csv");
            StringBuilder sb = new StringBuilder();
            using (var p = ChoCSVReader.LoadText(re).WithFirstLineHeader())
            {
                using var w = new ChoJSONWriter(sb);
                w.Write(p);
            }

            File.WriteAllText(@"C:\IndianCensusInformation\Ajay\IndianCensusInformation\temp.json", sb.ToString());
        }
        public static void ConvertStateCodecsvtoJSON()
        {
            string re = File.ReadAllText(@"C:\Users\Bridgelabz\Downloads\StateCode.csv");
            StringBuilder sb = new StringBuilder();
            using (var p = ChoCSVReader.LoadText(re).WithFirstLineHeader())
            {
                using var w = new ChoJSONWriter(sb);
                w.Write(p);
            }

            File.WriteAllText(@"C:\IndianCensusInformation\Ajay\IndianCensusInformation\StateCodeJSON.json", sb.ToString());
        }
        public static void SortStateCode(string path)
        {
            string json = File.ReadAllText(path);
            JArray jsonArray = JArray.Parse(json);
            for (int i = 0; i < jsonArray.Count - 1; i++)
            {
                for (int j = 0; j < jsonArray.Count-1-i; j++)
                {

                    if (jsonArray[j]["StateCode"].ToString().CompareTo(jsonArray[j+1]["StateCode"].ToString()) > 0)
                    {
                        var temp = jsonArray[j+1];
                        jsonArray[j+1] = jsonArray[j];
                        jsonArray[j] = temp;
                    }
                }

            }
            string jsonstring = JsonConvert.SerializeObject(jsonArray, Formatting.Indented);
            File.WriteAllText(path, jsonstring);

        }
      //  string json = JsonConvert.SerializeObject(jsonArray, Formatting.Indented);
      //  string jsonstring = JsonSerializer.Serialize(jsonArray);
     public static void SortStateCensus(String str)
        {
            
            var jsonfile = File.ReadAllText(@"C:\IndianCensusInformation\Ajay\IndianCensusInformation\temp.json");
            JArray jArray = JArray.Parse(jsonfile);
           
            for(int i =0;i<jArray.Count-1;i++)
             {
                 for(int j =0;j<jArray.Count-i-1;j++)
                 {
                    if ((int)jArray[j][str]<(int)jArray[j+1][str])
                     {
                       var  temp = jArray[j+1];
                         jArray[j+1] = jArray[j];
                         jArray[j] = temp;
                     }
                 }
             }
            string jsonString = JsonConvert.SerializeObject(jArray, Formatting.Indented);
            File.WriteAllText(@"C:\IndianCensusInformation\Ajay\IndianCensusInformation\temp.json",jsonString);
        }
    }
}
