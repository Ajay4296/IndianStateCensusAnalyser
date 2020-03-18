using NUnit.Framework;
using IndianCensusInformation;
using System.IO;
using Newtonsoft.Json.Linq;

namespace TestStateCensus
{
    public class Tests
    {
        string CorrectFilePath_UC_1 = @"C:\Users\Bridgelabz\Downloads\StateCensusData.csv";
        string WrongFilePath_UC_1 = @"C:\Users\\Downloads\StateCensusData.csv";
        string TypeWrongFilePath_UC_1 = @"C:\Users\Bridgelabz\Downloads\StateCensusData.txt";
        string WrongHeaderFilePath_UC_1 = @"C:\Users\Bridgelabz\Documents\StateCensusData.csv";
        string delimeterMismatch_UC_1 = @"C:\Users\Bridgelabz\Downloads/StateCensusData.csv";

        string CorrectFilePath_UC_2 = @"C:\Users\Bridgelabz\Downloads\StateCode1.csv";
        string WrongFilePath_UC_2 = @"C:\Users\\Downloads\StateCode.csv";
        string TypeWrongFilePath_UC_2 = @"C:\Users\Bridgelabz\Downloads\StateCode.txt";
        string WrongHeaderFilePath_UC_2 = @"C:\Users\Bridgelabz\Documents\StateCode.csv";
        string delimeterMismatch_UC_2 = @"C:\Users\Bridgelabz\Downloads\StateCode1.csv";
        /// <summary>
        /// match number of line
        /// </summary>
        [Test]
        public void UC_1_Match_number_of_Line()
        {
            CSVFactory factory = new CSVFactory();
            AnayseDataUsingDelegate del = ConcreatBuilder.BuilderMethod;
            string actual = del.Invoke(factory.ReturnObjectUsingFactory("CSVStateCensus"),CorrectFilePath_UC_1);
            string expected = StateCensusAnalyser.CountLines(CorrectFilePath_UC_1);
            Assert.AreEqual(expected,actual);
        }

        /// <summary>
        /// test case 1.2
        ///Given the State Census CSV File if incorrect Returns a custom Exception
        /// </summary>
        [Test]
        public void UseCase1_when_File_is_wrong_throw_exception()
        {
            CSVFactory factory = new CSVFactory();
            AnayseDataUsingDelegate del = ConcreatBuilder.BuilderMethod;
            var actual = Assert.Throws<StateCensusException>(() => del(factory.ReturnObjectUsingFactory("CSVStateCensus"),WrongFilePath_UC_1));
           // string expected = Exception_Type.wrong_path_Exception.ToString();
            Assert.AreEqual(actual.Message, Exception_Type.wrong_path_Exception.ToString());
        }
        
        /// <summary>
        /// test case 1.3
        ///Given the State Census CSV File when correct but type incorrect Returns a custom Exception
        /// </summary>
        [Test]
        public void UseCase1_whenGivenType_wrong_throw_Exception()
        {
            CSVFactory factory = new CSVFactory();
            AnayseDataUsingDelegate del = ConcreatBuilder.BuilderMethod;
            var actual = Assert.Throws<StateCensusException>(() =>del(factory.ReturnObjectUsingFactory("CSVStateCensus"),TypeWrongFilePath_UC_1));
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
            CSVFactory factory = new CSVFactory();
            AnayseDataUsingDelegate del = ConcreatBuilder.BuilderMethod;
            var actual = Assert.Throws<StateCensusException>(() => del(factory.ReturnObjectUsingFactory("CSVStateCensus"),delimeterMismatch_UC_1,';'));
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
            CSVFactory factory = new CSVFactory();
            AnayseDataUsingDelegate del = ConcreatBuilder.BuilderMethod;
            var actual = Assert.Throws<StateCensusException>(() => del(factory.ReturnObjectUsingFactory("CSVStateCensus"),WrongHeaderFilePath_UC_1));

            var expected = Exception_Type.Wrong_Header_Exception.ToString();
            Assert.AreEqual(actual.Message, expected);
        }
        
        /// <summary>
        /// test case 2.1
        ///Given the States Census CSV file, Check to ensure the Number of Record matches
        /// </summary>
        [Test]
        public void UC_2_whenAnalyse_ItMatchesTheRecord()
        {
            CSVFactory factory = new CSVFactory();
            AnayseDataUsingDelegate del = ConcreatBuilder.BuilderMethod;
            string actual = del(factory.ReturnObjectUsingFactory("CSVStates"),CorrectFilePath_UC_2);
            string count = StateCensusAnalyser.CountLines(CorrectFilePath_UC_2);
            Assert.AreEqual(count,actual);
        }

        /// <summary> 
        /// test case 2.2
        ///Given the State Census CSV File if incorrect Returns a custom Exception
        /// </summary>
        [Test]
        public void UC_2_GivenCSVFilePath_Incorect_through_exception()
        {
            CSVFactory factory = new CSVFactory();
            AnayseDataUsingDelegate del = ConcreatBuilder.BuilderMethod;
            var actual = Assert.Throws<StateCensusException>(() => del(factory.ReturnObjectUsingFactory("CSVStates"),WrongFilePath_UC_2));
           // string actual = del(factory.ReturnObjectUsingFactory("CSVStates"),WrongFilePath_UC_2);
            var expected = Exception_Type.wrong_path_Exception.ToString();
            Assert.AreEqual(actual.Message, expected);
        }

        /// <summary>
        /// test case 2.3
        ///Given the State Census CSV File when correct but type incorrect Returns a custom Exception
        /// </summary>
        [Test]
        public void UC_2_TypeIsIncorrect_whenAnalyse_ItThrowsException()
        {
            CSVFactory factory = new CSVFactory();
            AnayseDataUsingDelegate del = ConcreatBuilder.BuilderMethod;
            var actual = Assert.Throws<StateCensusException>(() =>del(factory.ReturnObjectUsingFactory("CSVStates"),TypeWrongFilePath_UC_2));
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
            CSVFactory factory = new CSVFactory();
            AnayseDataUsingDelegate del = ConcreatBuilder.BuilderMethod;

            var actual = Assert.Throws<StateCensusException>(() =>del(factory.ReturnObjectUsingFactory("CSVStates"), delimeterMismatch_UC_2,';'));
          var expected = Exception_Type.delimeter_exception.ToString();
            Assert.AreEqual(actual.Message,expected);

        }

        /// <summary>
        /// test case 2.5   
        /// 
        ///Given the State Census CSV File when correct but csv header incorrect Returns a custom Exception
        /// </summary>
        [Test]
        public void UseCase2_GivenCSVFilePathCorrect_CSVHeaderIsIncorrect_whenAnalyse_ItThrowsException()
        {
            CSVFactory factory = new CSVFactory();
            AnayseDataUsingDelegate del = ConcreatBuilder.BuilderMethod;
            // string actual = del(factory.ReturnObjectUsingFactory("CSVStates"),WrongHeaderFilePath_UC_2);
            var actual = Assert.Throws<StateCensusException>(() => del(factory.ReturnObjectUsingFactory("CSVStates"),WrongHeaderFilePath_UC_2));
            var expected = Exception_Type.Wrong_Header_Exception.ToString();
            Assert.AreEqual(actual.Message, expected);
        }
        /// <summary>
        /// TestCase-3.1
        /// Sorteds the first name of the json file check json.
        /// </summary>
       [Test]
        public void Sorted_Json_File_check_Json_First_Name()
        {
            string JsonPath = @"C:\IndianCensusInformation\Ajay\IndianCensusInformation\tsconfig1.json";
            var json = File.ReadAllText(JsonPath);
            JArray array = JArray.Parse(json);
            var actual = array[0]["State"].ToString();
            var Expected = "Andhra Pradesh";
            Assert.AreEqual(actual, Expected);
        }
        /// <summary>
        /// TestCase_3.2
        /// Sorteds the last name of the json file check first state.
        /// </summary>
        [Test]
        public void Sorted_Json_File_Check_State_Last_Name()
        {
            string JsonPath = @"C:\IndianCensusInformation\Ajay\IndianCensusInformation\tsconfig1.json";
            var json = File.ReadAllText(JsonPath);
            JArray array = JArray.Parse(json);
            var actual = array[28]["State"].ToString();
            var Expected = "West Bengal";
            Assert.AreEqual(actual, Expected);
        }
       [Test]
        public void Sorted_StateCode_Check_First_state_Name()
        {
            string jsonpath = @"C:\IndianCensusInformation\Ajay\IndianCensusInformation\StateCodeJSON.json";
            var json = File.ReadAllText(jsonpath);
            JArray array = JArray.Parse(json);
            var actual = array[0]["StateCode"].ToString();
            var Expected = "AD";
            Assert.AreEqual(actual, Expected);
        }
        [Test]
        public void Sorted_StateCode_Check_Last_state_Name()
        {
            string jsonpath = @"C:\IndianCensusInformation\Ajay\IndianCensusInformation\StateCodeJSON.json";
            var json = File.ReadAllText(jsonpath);
            JArray array = JArray.Parse(json);
            var actual = array[36]["StateCode"].ToString();
            var Expected = "WB";
            Assert.AreEqual(actual, Expected);
        }
    }
}