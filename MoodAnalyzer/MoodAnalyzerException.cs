using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyzerException : Exception
    {
        /// <summary>
        /// enum for exception type
        /// </summary>
        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE
            
        }
        //creating type variable of type ExceptionType
        ExceptionType type;
        /// <summary>
        /// parameterized constructor sets the exception type
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="message"></param>
        public MoodAnalyzerException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
