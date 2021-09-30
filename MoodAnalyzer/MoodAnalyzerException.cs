﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyzerException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            NO_SUCH_FIELD,
            NO_SUCH_METHOD,
            NO_SUCH_CLASS,
            OBJECT_CREATION_ISSUE
        }
        private readonly ExceptionType type;
        public MoodAnalyzerException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
