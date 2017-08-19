using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classbook
{
    [TestClass]
    public class SubjectTests
    {
        [TestMethod]
        public void AddGradeToSubject()
        {
            var subject = new Subject("Romana", new Grades(new int[] { 7, 8 }));
            subject.AddGrade(9);
            Assert.AreEqual(8, subject.GeneralAverage());
        }

        [TestMethod]
        public void CountGradesOfTenFromSubject()
        {
            var subject = new Subject("Romana", new Grades(new int[] { 10, 7, 8, 10 }));
            Assert.AreEqual(2, subject.CountGradesOfTen());
        }
    }
}
