using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(84.5f);

            GradeBookStatistics stat = book.ComputeStatistics();

            Console.WriteLine("Lowest Grade is " + stat.Lowest);
            Console.WriteLine("Highest Grade is " + stat.Highest);
            Console.WriteLine("Average Grade is " + stat.Average);

        }
    }
}
