using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
namespace TestMood
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MoodHappy()
        {
            string expected = "HAPPY";
            string message = "I am in happy mood";
            
            MoodAnalyzer1 moodAnalyzer = new MoodAnalyzer1(message);
            
            string mood = moodAnalyzer.AnalyzeMood();

            Assert.AreEqual(expected, mood);
        }
    }
}
