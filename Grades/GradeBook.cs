using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        List<float> grades;

        public GradeBookStatistics ComputeStatistics()
        {
            GradeBookStatistics stats = new GradeBookStatistics();
            float sum = 0;
            stats.Highest = grades[0];
            stats.Lowest = grades[0];
     
            foreach(float g in grades)
            {
                sum += g;
                stats.Highest = Math.Max(g, stats.Highest);
                stats.Lowest = Math.Min(g, stats.Lowest);
            }
            stats.Average = sum / grades.Count;
            return stats;
        }
       
    }
}
