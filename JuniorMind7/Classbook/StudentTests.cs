using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classbook
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AddSubjectTest()
        {
            var student = new Student("Florin", new Subject[] { new Subject("Romana", new Grades(new int[] { 7, 8, 9 }))});
            var newSubject = new Subject("Matematica", new Grades(new int[] { 7, 8, 7, }));
            student.AddSubject(newSubject);
            var totalGeneralAverage = student.CalculateTotalGeneralAverage();

            Assert.AreEqual(7.67, totalGeneralAverage, 0.01);
        }

        [TestMethod]
        public void CountGradesOfTenFromAllSubjectsTest()
        {
            var student = new Student("Florin", new Subject[] {
                new Subject("Romana", new Grades(new int[] { 7, 8, 9, 10 })),
                new Subject("Matematica", new Grades(new int[] { 7, 8, 9, 10 })) });

            Assert.AreEqual(2, student.CountAllGradesOfTen());
        }
    }
}
