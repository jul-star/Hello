using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public string Name {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Book name can't be null or empty");
                }

                if (_name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;
                        NameChanged(this, args);
                        _name = value;
                    }
                

            } }

        public void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }
        }
        public event NameChangedDelegate NameChanged;
        private string _name;
        private List<float> grades;

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
