using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
namespace TestMood
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// test to check sad mood
        /// </summary>
        [TestMethod]
        public void MoodHappy_ReturnSad()
        {
            string expected = "HAPPY";
            string message = "I am in happy mood";

            PersonMoodAnalyzer moodAnalyzer = new PersonMoodAnalyzer(message);
            
            string mood = moodAnalyzer.AnalyzeMood();//act

            Assert.AreEqual(expected, mood);//assert 
        }
        /// <summary>
        /// test to check - given is I am in happy mood and null message should return happy
        /// </summary>
        /// <param name="message"></param>
        [TestMethod]
        [DataRow("I am in Happy Mood")]
        public void HAPPYMood_Should_ReturnHappy(string message)
        {
            string expected = "HAPPY";
            PersonMoodAnalyzer moodAnalyzer = new PersonMoodAnalyzer(message);

            string mood = moodAnalyzer.AnalyzeMood();//act


            Assert.AreEqual(expected, mood);//assert
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
