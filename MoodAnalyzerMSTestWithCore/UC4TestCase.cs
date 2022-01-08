using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerApp;

namespace MoodAnalyzerMSTestWithCore
{
    [TestClass]
    public class UC4TestCase
    {
        /// <summary>
        /// TC 4.1 : Given MoodAnalyse ClassName should Return MoodAnalyse Object.
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyse3(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerApp.MoodAnalyse3", "MoodAnalyse3");
            expected.Equals(obj);
        }
        /// <summary>
        /// TC 4.2 : Given Improper ClassName should throw MoodAnalysisException.
        /// </summary>
        [TestMethod]
        public void GivenImproperClassNameShouldThrowMoodAnalysisException()
        {
            string expected = "Class not Found";
            try
            {              
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerApp.DemoClass", "DemoClass");
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        /// <summary>
        /// TC 4.3 : Given Improper Constructor should throw MoodAnalysisException.
        /// </summary>
        [TestMethod]
        public void GivenImproperConstructorNameShouldThrowMoodAnalysisException()
        {
            string expected = "Constructor not Found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("DemoClass", "MoodAnalyse3");
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
