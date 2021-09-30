using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class PersonMoodAnalyzer
    {
        private string message;
        //constructor
        public PersonMoodAnalyzer(string message)
        {
            this.message = message;
        }

        /// <summary>
        /// method to analyze mood 
        /// </summary>
        /// <returns></returns>
        public string AnalyzeMood()
        {
            /*
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
            */
            //use try catch for exception handling for empty and null message
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }
    }
}
