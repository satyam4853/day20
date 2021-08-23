using System;

namespace MoodAnalysesWithCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------This Is MoodAnalyses Problem-------------");
            MoodAnalyser analyser = new MoodAnalyser("I am in sad Mood");
            Console.WriteLine(analyser.AnalyserMethod());
            Console.ReadLine();
        }
    }
}
