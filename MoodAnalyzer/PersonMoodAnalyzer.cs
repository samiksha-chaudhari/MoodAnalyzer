using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class PersonMoodAnalyzer
    {
        private string message;
        public PersonMoodAnalyzer(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood()
        {
            try
            {
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch
            {
                return "HAPPY";
            }
        }
    }
}
