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
        public MoodAnalyzerdemo(String message)
        {
            this.message = message;

        }
        public string MoodAnalyze()
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

    }
}
