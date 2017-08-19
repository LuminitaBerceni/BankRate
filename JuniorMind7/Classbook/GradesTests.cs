using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classbook
{
    [TestClass]
    public class GradesTests
    {
        [TestMethod]
        public void AddGradeTest()
        {
            int newGrade = 3;
            var grades = new Grades(new int[] { 1, 2});
            grades.AddGrade(newGrade);
            Assert.AreEqual(2, grades.GeneralAverage());
        }

        [TestMethod]
        public void CountGradesOfTenTests()
        {
            var grades = new Grades(new int[] { 10, 8, 9, 10, 7, 7 });
            Assert.AreEqual(2, grades.CountGradesOfTen());
        }
    }
}
