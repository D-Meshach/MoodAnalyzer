using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyzer;

namespace MoodAnalyzerMSTest
{
    //T.C 1.1
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            String expected = "Sad";
            String message = "I am very Sad";
            MoodAnalyzerdemo mode = new MoodAnalyzerdemo(message);
            String response = mode.MoodAnalyze();

            Assert.AreEqual(expected,response);
        }
        //T.C 1.2
        [TestMethod]
        public void TestMethod2()
        {
            String expected = "Happy";
            String message = "I am very Happy";
            MoodAnalyzerdemo mode = new MoodAnalyzerdemo(message);
            String response = mode.MoodAnalyze();

            Assert.AreEqual(expected, response);
        }
        //Refactor Test case  Refactor T.C 1.1
        [TestMethod]
        public void TestMethod3()
        {
            String expected = "Sad";
            MoodAnalyzerdemo mode = new MoodAnalyzerdemo();
            mode.message="I am Very Sad";
            String response = mode.MoodAnalyze();

            Assert.AreEqual(expected, response);
        }
        //Refactor Test case  Refactor T.C 1.2
        [TestMethod]
        public void TestMethod4()
        {
            String expected = "Happy";
            MoodAnalyzerdemo mode = new MoodAnalyzerdemo();
            mode.message = "I am Very Happy";
            String response = mode.MoodAnalyze();

            Assert.AreEqual(expected, response);
        }
        //UC2 Null Exception
        [TestMethod]
        [DataRow(null)]
        public void ExceptionHadleMood(String message)
        {
            String expected = "Happy";
            MoodAnalyzerdemo mode = new MoodAnalyzerdemo();
            mode.message = message;
            String response = mode.MoodAnalyze();

            Assert.AreEqual(expected, response);
        }
    }
}
