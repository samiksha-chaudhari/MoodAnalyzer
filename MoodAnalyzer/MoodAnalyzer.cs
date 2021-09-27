using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyzer1
    {
        private string message;
        public MoodAnalyzer1(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood()
        {
            if (this.message.Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
