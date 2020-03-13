using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

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
            try
            {
                if (!File.Exists(FilePath))
                    throw new StateCensusException(Exception_Type.wrong_path_Exception.ToString());

                ////This line reads the CSV file and store it into the strings of array
                string[] Lines = File.ReadAllLines(FilePath);
                if (Lines[0] != "SrNo,State,Name,TIN,StateCode,")
                    throw new StateCensusException(Exception_Type.Wrong_Header_Exception.ToString());

               // foreach (var line in File.ReadLines(FilePath))
                //{
                    ////For delimeter
                  //  string[] LineCount = line.Split(delimiter);
                    if (delimiter!=',')
                        throw new StateCensusException(Exception_Type.delimeter_exception.ToString());
               // }

                ////store the list into iterator(IEnumerable)
                IEnumerable<string> iterator = Lines;
                int count = 0;
                foreach (var item in iterator)
                    count++;
                return count.ToString();
            }
            catch (StateCensusException ex)
            {
                return ex.Message;
            }
        }
    }
}
