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
            Console.WriteLine("Welcome to Mood Analyzer");
            MoodAnalyser mo =new MoodAnalyser("i am sad");
            mo.AnalyseMood();
               

        }
    }
}