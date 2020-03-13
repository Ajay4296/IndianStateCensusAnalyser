using System;
using System.Collections.Generic;
using System.Text;

namespace IndianCensusInformation
{
    public delegate string AnayseDataUsingDelegate(ICSVDataLoad loaddata, string path, char delimeter = ',');
    public class ConcreatBuilder
    {
        public static string  BuilderMethod(ICSVDataLoad loaddata,string path,char delimeter = ',')
        {
            string result = loaddata.CSVDataUsingIEnumerator(path, delimeter);
                return result.ToString();
        }

    }
}
