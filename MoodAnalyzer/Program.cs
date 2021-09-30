using System;

namespace MoodAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer");
            PersonMoodAnalyzer mood = new PersonMoodAnalyzer("I am in happy mood");
            Console.WriteLine(mood.AnalyzeMood());
        }
    }
}
