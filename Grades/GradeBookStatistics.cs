namespace Grades
{
    public class GradeBookStatistics
    {
        public float Average;
        public float Highest = 0;
        public float Lowest = float.MaxValue;

        public string LetterGrade
        {
            get
            {
                if (Average >= 90)
                {
                    return "A";
                }
                else if (Average >= 80)
                {
                    return "B";
                }
                else if (Average >= 70)
                {
                    return "C";
                }
                else if (Average >= 60)
                {
                    return "D";
                }

                return "F";
            }
        }
    }
}