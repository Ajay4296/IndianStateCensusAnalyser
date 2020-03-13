using System;
using System.Collections.Generic;
using System.Text;

namespace IndianCensusInformation
{
    public enum Exception_Type
    {
        wrong_path_Exception,
        delimeter_exception,
        Wrong_Type_Exception,
        Wrong_Header_Exception,
    }
    /// <summary>
    /// Custom stateCensusException
    /// </summary>
    public class StateCensusException : Exception
    {
        public StateCensusException(string msg) : base(msg)
        {

        }
    }

}

