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
        [DataRow("I am in Happy Mood")]
        public void HAPPYMood_Should_ReturnHappy(string message)
        {
            string expected = "HAPPY";
            PersonMoodAnalyzer moodAnalyzer = new PersonMoodAnalyzer(message);

            string mood = moodAnalyzer.AnalyzeMood();


            Assert.AreEqual(expected, mood);
        }

        [TestMethod]
        public void MoodEmpty_Should_ThrowException()
        {
            try
            {
                string message = "";
                PersonMoodAnalyzer moodAnalyzer = new PersonMoodAnalyzer(message);
                string mood = moodAnalyzer.AnalyzeMood();
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }

        }
        [TestMethod]
        public void GivenMoodNull_ShouldThrowException()
        {
            try
            {
                string message = null;
                PersonMoodAnalyzer moodAnalyzer = new PersonMoodAnalyzer(message);
                string mood = moodAnalyzer.AnalyzeMood();
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }

        }
    }
}
