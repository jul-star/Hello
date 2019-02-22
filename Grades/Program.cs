using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //SpeakUp();
            RunBookApp();
        }

        public delegate void Writer(GradeBook book);

        private static void RunBookApp()
        {
            GradeBook book = new GradeBook();
            // Events
            book.NameChanged += new NameChangedDelegate(OnNameChanged);
            book.NameChanged += new NameChangedDelegate(OnNameChanged2);
            book.NameChanged += OnNameChanged2;
            book.NameChanged += OnNameChanged2;
            book.NameChanged -= OnNameChanged2;
            /// Delegate
            Writer w = new Writer(WriteBookName);
            book.Name = "My book";
            // Exception
            try
            {
                book.Name = "";
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }

            book.AddGrade(91);
            book.AddGrade(84.5f);

            GradeBookStatistics stat = book.ComputeStatistics();
            w(book);
            //WriteBookName(book);
            WriteResult("Lowest Grade", stat.Lowest);
            WriteResult("Highest Grade", stat.Highest);
            WriteResult("Average Grade", stat.Average);
            WriteResult("LetterGrade" , stat.LetterGrade);
            book.WriteGrades(Console.Out);
            // Exception
            using (StreamWriter sw = File.CreateText("grades.txt"))
            {
                book.WriteGrades(sw);
                sw.Close();
            }
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("OnNameChanged: " + args.NewName);
        }

        static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("*********");
        }
        private static void WriteBookName(GradeBook book)
        {
            Console.WriteLine(book.Name);
        }

        private static void SpeakUp()
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Speak("Hello! This is the grade book program");
            synthesizer.Speak("Как дела?");
        }

        private static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + ": "+ result);
        }
        private static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }
        private static void WriteResult(string description, double result)
        {
            Console.WriteLine("{0}: {1:C}", description , result);
        }
        private static void WriteResult(string description, long result)
        {
            Console.WriteLine($"{description}: {result}");
        }
        private static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result}");
        }
        private static void WriteResult(string description, params float[] results)
        {
            Console.WriteLine(description + ": ");
            foreach (var v in results)
            {
                Console.WriteLine(v);
            }
        }
    }
}
