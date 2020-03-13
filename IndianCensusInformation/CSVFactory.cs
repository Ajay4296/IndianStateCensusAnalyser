using System;
using System.Collections.Generic;
using System.Text;

namespace IndianCensusInformation
{
   public class CSVFactory
    {
        ICSVDataLoad loaddata = null;
        public ICSVDataLoad ReturnObjectUsingFactory(string str)
        {

            switch(str)
            {
                case "CSVStates":
                    {
                        loaddata= new CSVStates();
                        return loaddata;  
                    }
                case "CSVStateCensus":
                    {
                        loaddata= new CSVStateCensus();
                        return loaddata;
                    }
                default:
                    {
                       return loaddata;
                    }
            }
        }
    }
}
