using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace IndianCensusInformation
{
     public class CSVStateCensus :ICSVDataLoad
    {
        public  string CSVDataUsingIEnumerator(string CSVPath, char delimiter = ',')
        {
            FileInfo fileInfo = new FileInfo(CSVPath);
            if (Path.GetExtension(CSVPath) != ".csv")
                throw new StateCensusException(Exception_Type.Wrong_Type_Exception.ToString());
            if (!File.Exists(CSVPath))
                throw new StateCensusException(Exception_Type.wrong_path_Exception.ToString());

            string[] Lines = File.ReadAllLines(CSVPath);
            //  List<string> list = File.ReadAllLines(CSVPath).ToList();
            Dictionary<int, csvdata> dict = new Dictionary<int, csvdata>();
            var k = 0;
            for (int i = 1; i < Lines.Length; i++)
            {
                csvdata data = new csvdata()
                {
                    state = Lines[i].Split(',')[0].ToString(),
                    population = int.Parse(Lines[i].Split(',')[1]),
                    AreaInSqKm = int.Parse(Lines[i].Split(',')[2]),
                    DensityInSqKm = int.Parse(Lines[i].Split(',')[3]),
                };
                dict.Add(k, data);
                k++;
            }
            if (Lines[0] != "State,Population,AreaInSqKm,DensityPerSqKm")
                throw new StateCensusException(Exception_Type.Wrong_Header_Exception.ToString());

            foreach (var line in File.ReadLines(CSVPath))
            {

                string[] LineCount = line.Split(delimiter);
                if (LineCount.Length != 4 && LineCount.Length != 2)
                    throw new StateCensusException(Exception_Type.delimeter_exception.ToString());
            }


            IEnumerable<string> iterator = Lines;
            int count = 0;
            foreach (var item in iterator)
                count++;
            return count.ToString();
        }
       
    }
}
