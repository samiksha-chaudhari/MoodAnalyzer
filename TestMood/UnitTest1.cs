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

            PersonMoodAnalyzer moodAnalyzer = new PersonMoodAnalyzer(message);
            
            string mood = moodAnalyzer.AnalyzeMood();

            Assert.AreEqual(expected, mood);
        }

        [TestMethod]
        [DataRow(null)]
        public void GivenHAPPYMoodShouldReturnHappy(string message)
        {
            string expected = "HAPPY";
            PersonMoodAnalyzer moodAnalyzer = new PersonMoodAnalyzer(message);

            string mood = moodAnalyzer.AnalyzeMood();


            Assert.AreEqual(expected, mood);
        }
    }
}
