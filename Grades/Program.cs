using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeakUp();
            //RunBookApp();
        }

        private static void RunBookApp()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(84.5f);

            GradeBookStatistics stat = book.ComputeStatistics();

            Console.WriteLine("Lowest Grade is " + stat.Lowest);
            Console.WriteLine("Highest Grade is " + stat.Highest);
            Console.WriteLine("Average Grade is " + stat.Average);
        }

        private static void SpeakUp()
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Speak("Hello! This is the grade book program");
            synthesizer.Speak("Как дела?");
        }
    }
}
