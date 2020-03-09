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
        /// <summary>
        /// test case 1.1
        ///Given the States Census CSV file, Check to ensure the Number of Record matches
        /// </summary>
        [Test]
        public void UseCase1_GivenCSVFilePathProper_whenAnalyse_ItMatchesTheRecord()
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
        public void UseCase1_GivenCSVFilePath_Imroper_whenAnalyse_ItThrowsException()
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
        public void UseCase1_GivenCSVFilePathCorrect_TypeIsIncorrect_whenAnalyse_ItThrowsException()
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
        public void UseCase1_GivenCSVFilePathCorrect_DelimiterIsIncorrect_whenAnalyse_ItThrowsException()
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
        public void UseCase1_GivenCSVFilePathCorrect_CSVHeaderIsIncorrect_whenAnalyse_ItThrowsException()
        {
            var actual = Assert.Throws<StateCensusException>(() => CSVStateCensus.CSVDataUsingIEnumerator(WrongHeaderFilePath_UC_1,','));
 
             var expected =Exception_Type.Wrong_Header_Exception.ToString();
            Assert.AreEqual(actual.Message,expected);
        }
        /*/// <summary>
        /// test case 2.1
        ///Given the States Census CSV file, Check to ensure the Number of Record matches
        /// </summary>
        [Test]
        public void UseCase2_GivenCSVFilePathProper_whenAnalyse_ItMatchesTheRecord()
        {
            LoadDataDelegate loadData = new LoadDataDelegate(CSVStates.CSVDataUsingIEnumerator);
            object Iteratoritems = loadData(CorrectFilePath_Usecase2);
            string[] myitems = File.ReadAllLines(@"C:\Users\Bridge Labz\Desktop\censusdata\StateCode.csv");
            int item = (int)myitems.Length;
            Assert.AreEqual(item, Iteratoritems);
        }

        /// <summary>
        /// test case 2.2
        ///Given the State Census CSV File if incorrect Returns a custom Exception
        /// </summary>
        [Test]
        public void UseCase2_GivenCSVFilePath_Imroper_whenAnalyse_ItThrowsException()
        {
            LoadDataDelegate loadData = new LoadDataDelegate(CSVStates.CSVDataUsingIEnumerator);
            object actual = loadData(IncorrectFilePath_Usecase2);
            var expected = MyEnum.ERROR_IN_FILE_READING.ToString();
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// test case 2.3
        ///Given the State Census CSV File when correct but type incorrect Returns a custom Exception
        /// </summary>
        [Test]
        public void UseCase2_GivenCSVFilePathCorrect_TypeIsIncorrect_whenAnalyse_ItThrowsException()
        {
            LoadDataDelegate loadData = new LoadDataDelegate(CSVStates.CSVDataUsingIEnumerator);
            var actual = Assert.Throws<CensusAnalyseException>(() => loadData(ErrorTypeFilePath_Usecase2));
            var expected = MyEnum.INCORRECT_TYPE.ToString();
            Assert.AreEqual(actual.Message, expected);
        }

        /// <summary>
        /// test case 2.4
        ///Given the State Census CSV File when correct but delimiter incorrect Returns a custom Exception
        /// </summary>
        [Test]
        public void UseCase2_GivenCSVFilePathCorrect_DelimiterIsIncorrect_whenAnalyse_ItThrowsException()
        {
            LoadDataDelegate loadData = new LoadDataDelegate(CSVStates.CSVDataUsingIEnumerator);
            string actual = (string)loadData(CorrectFilePath_Usecase2, '.');
            var expected = MyEnum.INVALID_DELIMITER.ToString();
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// test case 2.5   
        ///Given the State Census CSV File when correct but csv header incorrect Returns a custom Exception
        /// </summary>
        [Test]
        public void UseCase2_GivenCSVFilePathCorrect_CSVHeaderIsIncorrect_whenAnalyse_ItThrowsException()
        {
            LoadDataDelegate loadData = new LoadDataDelegate(CSVStates.CSVDataUsingIEnumerator);
            string actual = (string)loadData(FilePath_EmptyHeader_Usecase2);
            var expected = MyEnum.HEADER_IS_NOT_FOUND.ToString();
            Assert.AreEqual(actual, expected);
        }*/
    }
}