using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyzerdemo
    {
        public string message;
        public MoodAnalyzerdemo()
        {
            
        }
        public MoodAnalyzerdemo(String message)
        {
            this.message = message;

        }
        public string MoodAnalyze()
        {
            try
            {
                if (this.message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch
            {
                return "Happy";
            }
        }

    }

    public class MoodAnalyzerExceptionTest {
        public string message;
        public MoodAnalyzerExceptionTest(string message)
        {
            this.message = message;
        }
        public string MoodAnalyze()
        {
            try
            {
                if (this.message.Equals(String.Empty))
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.EMPTY_MESSAGE, "Mood is Empty");
                }
                else if (this.message.Contains("Sad"))
                {
                    return "Sad";
                }
                else 
                {
                    return "Happy";
                }
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }


    }
}
