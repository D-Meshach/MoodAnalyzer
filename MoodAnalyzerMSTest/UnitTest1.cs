using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyzer;

namespace MoodAnalyzerMSTest
{
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

            Assert.AreEqual(response, expected);
        }
    }
}
