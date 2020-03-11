using NUnit.Framework;
using IndianCensusAnalyser;

namespace StateCensusTest
{
    public class Tests
    {
        string CorrectFilePath_UC_1 = @"C:\Users\HP\Downloads\StateCensusData.csv";
        string WrongFilePath_UC_1 = @"C:\Users\\Downloads\StateCensusData.csv";
        string TypeWrongFilePath_UC_1 = @"C:\Users\HP\Downloads\StateCensusData.txt";
        string WrongHeaderFilePath_UC_1 = @"C:\Users\HP\Desktop\StateCensusData.csv";
        string delimeterMismatch_UC_1 = @"C:\Users\HP\Downloads\StateCensusData.csv";

        string CorrectFilePath_UC_2 = @"C:\Users\HP\Downloads\StateCode.csv";
        string WrongFilePath_UC_2 = @"C:\Users\\Downloads\StateCode.csv";
        string TypeWrongFilePath_UC_2 = @"C:\Users\HP\Downloads\StateCode.txt";
        string WrongHeaderFilePath_UC_2 = @"C:\Users\HP\Desktop\StateCode.csv";
        string delimeterMismatch_UC_2 = @"C:\Users\HP\Downloads\StateCode.csv";
        /// <summary>
        /// match number of line
        /// </summary>
        [Test]
        public void UC_1_Match_number_of_Line()
        {
            string expected = StateCensusAnalyser.CountLines(CorrectFilePath_UC_1);
            string actual = CSVStateCensus.CSVDataUsingIEnumerator(CorrectFilePath_UC_1,',');
            Assert.AreEqual(expected,actual);
        }

        /// <summary>
        /// test case 1.2
        ///Given the State Census CSV File if incorrect Returns a custom Exception
        /// </summary>
        [Test]
        public void UseCase1_when_File_is_wrong_throw_exception()
        {

            var actual = Assert.Throws<StateCensusException>(() => CSVStateCensus.CSVDataUsingIEnumerator(WrongFilePath_UC_1,','));
            string expected = Exception_Type.wrong_path_Exception.ToString();
            Assert.AreEqual(actual.Message,expected);
        }

        /// <summary>
        /// test case 1.3
        ///Given the State Census CSV File when correct but type incorrect Returns a custom Exception
        /// </summary>
        [Test]
        public void UseCase1_whenGivenType_wrong_throw_Exception()
        {
            var actual = Assert.Throws<StateCensusException>(() => CSVStateCensus.CSVDataUsingIEnumerator(TypeWrongFilePath_UC_1,','));
            string expected = Exception_Type.Wrong_Type_Exception.ToString();
            Assert.AreEqual(actual.Message, expected);
        }

        /// <summary>
        /// test case 1.4
        ///Given the State Census CSV File when correct but delimiter incorrect Returns a custom Exception
        /// </summary>
        [Test]
        public void UseCase1_When_delimeter_ItThrowsException()
        {
            var actual = Assert.Throws<StateCensusException>(() => CSVStateCensus.CSVDataUsingIEnumerator(delimeterMismatch_UC_1,';'));
             var expected = Exception_Type.delimeter_exception.ToString();
            Assert.AreEqual(actual.Message, expected);
        }

        /// <summary>
        /// test case 1.5   
        ///Given the State Census CSV File when correct but csv header incorrect Returns a custom Exception
        /// </summary>
        [Test]
        public void UseCase1_GivenHeader_is_not_correct()
        {
            var actual = Assert.Throws<StateCensusException>(() => CSVStateCensus.CSVDataUsingIEnumerator(WrongHeaderFilePath_UC_1,','));
 
             var expected =Exception_Type.Wrong_Header_Exception.ToString();
            Assert.AreEqual(actual.Message,expected);
        }
        /// <summary>
        /// test case 2.1
        ///Given the States Census CSV file, Check to ensure the Number of Record matches
        /// </summary>
        [Test]
        public void UC_2_G_whenAnalyse_ItMatchesTheRecord()
        {
            AnayseDataUsingDelegate del = CSVStates.CSVDataUsingIEnumerator;
            string Iterate = del(CorrectFilePath_UC_2,',');
            string count = StateCensusAnalyser.CountLines(CorrectFilePath_UC_2);
            Assert.AreEqual(Iterate,count);
        }

        /// <summary> 
        /// test case 2.2
        ///Given the State Census CSV File if incorrect Returns a custom Exception
        /// </summary>
        [Test]
        public void UC_2_GivenCSVFilePath_Incorect_through_exception()
        {
            AnayseDataUsingDelegate del = CSVStates.CSVDataUsingIEnumerator;
            string actual = del(WrongFilePath_UC_2,',');
            var expected = Exception_Type.wrong_path_Exception.ToString();
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// test case 2.3
        ///Given the State Census CSV File when correct but type incorrect Returns a custom Exception
        /// </summary>
        [Test]
        public void UC_2_TypeIsIncorrect_whenAnalyse_ItThrowsException()
        {
            AnayseDataUsingDelegate obj = new AnayseDataUsingDelegate(CSVStates.CSVDataUsingIEnumerator);
            var actual = Assert.Throws<StateCensusException>(() => obj(TypeWrongFilePath_UC_2,','));
            var expected = Exception_Type.Wrong_Type_Exception.ToString();
            Assert.AreEqual(actual.Message, expected);
        }

        /// <summary>
        /// test case 2.4
        ///Given the State Census CSV File when correct but delimiter incorrect Returns a custom Exception
        /// </summary>
        [Test]
        public void UseCase2_GivenCSVFilePathCorrect_DelimiterIsIncorrect()
        {
            AnayseDataUsingDelegate del = CSVStates.CSVDataUsingIEnumerator;
            string actual = del(delimeterMismatch_UC_2, '/');
            var expected = Exception_Type.delimeter_exception.ToString();
            Assert.AreEqual(actual, expected);

        }

        /// <summary>
        /// test case 2.5   
        /// 
        ///Given the State Census CSV File when correct but csv header incorrect Returns a custom Exception
        /// </summary>
        [Test]
        public void UseCase2_GivenCSVFilePathCorrect_CSVHeaderIsIncorrect_whenAnalyse_ItThrowsException()
        {
           AnayseDataUsingDelegate del = new AnayseDataUsingDelegate(CSVStates.CSVDataUsingIEnumerator);
            string actual = del(WrongHeaderFilePath_UC_2,',');
            var expected = Exception_Type.Wrong_Header_Exception.ToString();
            Assert.AreEqual(actual, expected);
        }
    }
}