using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTest
    {
        [TestMethod]
        public void TestGradeBookInitialize()
        {
            Grades.GradeBook g = new Grades.GradeBook();
            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestHighestGrade()
        {
            Grades.GradeBook g = new Grades.GradeBook();
            g.AddGrade(91);
            g.AddGrade(84.5f);
            Assert.AreEqual(g.ComputeStatistics().Highest, 91f);
        }

        [TestMethod]
        public void TestLowesttGrade()
        {
            Grades.GradeBook g = new Grades.GradeBook();
            g.AddGrade(91);
            g.AddGrade(84.5f);
            GradeBookStatistics s = g.ComputeStatistics();
            Assert.AreEqual(s.Lowest, 84.5f, 0.00001);
        }

        public void TestAveragetGrade()
        {
            Grades.GradeBook g = new Grades.GradeBook();
            g.AddGrade(91);
            g.AddGrade(89.5f);
            g.AddGrade(75);

            GradeBookStatistics s = g.ComputeStatistics();
            Assert.AreEqual(s.Average, 85.166666666667f, 0.01);
        }
    }
}
