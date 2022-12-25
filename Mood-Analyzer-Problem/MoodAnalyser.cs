using Mood_Analyzer_Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mood_Analyzer_Problem
{
    public class MoodAnalyser
    {

        public string message;
       

        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            if (this.message.Contains("SAD"))
            {
                Console.WriteLine("SAD");
                return "SAD";
                
            }
            else
            {
                Console.WriteLine("happy");
                return "HAPPY";
                
            }
        }
    }
}
