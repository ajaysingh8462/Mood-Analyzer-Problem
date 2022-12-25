using Mood_Analyzer_Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TestProject1
{
    [TestClass]
    public class MoodAnlyzerTest
    {

        [TestMethod]
        public void Testcase1_1()
        {
            string expected = "SAD";
            string message = "I am in SAD Mood";
            MoodAnalyser moodAnalyse = new MoodAnalyser(message);

            string mood = moodAnalyse.AnalyseMood();

            Assert.AreEqual(expected, mood);
        }

        [TestMethod]
        public void Testcase1_2()
        {        
            string expected = "HAPPY";
            string message = "I am in HAPPY Mood";
            MoodAnalyser moodAnalyse = new MoodAnalyser(message);

            string mood = moodAnalyse.AnalyseMood();

            Assert.AreEqual(expected, mood);
        }
    }
}
