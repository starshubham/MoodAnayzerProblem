using System;

namespace MoodAnalyzerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO MOOD ANALYZER PROGRAM");
            // UC1
            MoodAnalyse obj = new MoodAnalyse("Sad");
            obj.AnalyseMood();
        }
    }
}
