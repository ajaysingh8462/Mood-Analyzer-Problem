using Mood_Analyzer_Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyzer_Problem
{
    class program
    {
        public static void Main(string[] args)
        {
            MoodAnalyser Md = new MoodAnalyser();
                Md.Mood("sad");
                Md.Mood("happy");
        }
    }
}