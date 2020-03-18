using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace IndianCensusInformation
{
   
   public class CSVStates : ICSVDataLoad
    {
        public  string CSVDataUsingIEnumerator(string FilePath, char delimiter = ',')
        {
            FileInfo fileInfo = new FileInfo(FilePath);
            string type = fileInfo.Extension;
            if (type != ".CSV" && type != ".csv")
                throw new StateCensusException(Exception_Type.Wrong_Type_Exception.ToString());
          
            
                if (!File.Exists(FilePath))
                    throw new StateCensusException(Exception_Type.wrong_path_Exception.ToString());

            ////This line reads the CSV file and store it into the strings of array
            //   string[] Lines = File.ReadAllLines(FilePath);
            // List<string> list = File.ReadAllLines(FilePath).ToList();
            string[] iFile = File.ReadAllLines(FilePath);
            var list = new List<string>(iFile);
            Dictionary<int, csvdata> dict = new Dictionary<int, csvdata>();
            var k = 0;
           /* for (int i = 1; i < iFile.Length; i++)
            {
                csvdata data = new csvdata()
                {
                    state = iFile[i].Split(',')[0].ToString(),
                    population = int.Parse(iFile[i].Split(',')[1]),
                    AreaInSqKm = int.Parse(iFile[i].Split(',')[2]),
                    DensityInSqKm = int.Parse(iFile[i].Split(',')[3]),
                };
                dict.Add(k, data);
                k++;
            }*/
            if (list[0] != "SrNo,State,Name,TIN,StateCode,")
                    throw new StateCensusException(Exception_Type.Wrong_Header_Exception.ToString());

               // foreach (var line in File.ReadLines(FilePath))
                //{
                    ////For delimeter
                  //  string[] LineCount = line.Split(delimiter);
                    if (delimiter!=',')
                        throw new StateCensusException(Exception_Type.delimeter_exception.ToString());
            // }

            ////store the list into iterator(IEnumerable)
           
                IEnumerable<string> iterator = list;
                int count = 0;
                foreach (var item in iterator)
                    count++;
                return count.ToString();
            
           
        }
    }
}
