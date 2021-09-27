using System;

namespace MoodAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer");
            MoodAnalyzer1 mood = new MoodAnalyzer1("I am in happy mood");
            Console.WriteLine(mood.AnalyzeMood());
        }
    }
}
