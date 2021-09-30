using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyzerException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE
            
        }
        private readonly ExceptionType type;
        public MoodAnalyzerException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
