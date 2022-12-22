using Mood_Analyzer_Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testcase1_1()
        {
            const string sadmood = "Sad";
            MoodAnalyser mood = new MoodAnalyser();
            string actual = mood.Mood(sadmood);
            string expected = "Sad";
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void Testcase1_2()
        {
            const string happymood = "Happy";
            MoodAnalyser mood = new MoodAnalyser();
            string actual = mood.Mood(happymood);
            string expected = "Happy";
            Assert.AreEqual(expected, actual);


        }
    }
}