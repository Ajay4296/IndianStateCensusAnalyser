using System;
using System.Collections.Generic;
using System.Text;

namespace IndianCensusInformation
{
     public interface ICSVDataLoad
    {
        public string CSVDataUsingIEnumerator(string FilePath, char delimiter = ',');
    }
}
