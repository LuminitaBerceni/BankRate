using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classbook
{
    [TestClass]
    public class ClassbookTests
    {
        [TestMethod]
        public void SortStudentsAlphabeticallyTest()
        {
            var students = new Student[] { new Student("Florin", new Subject[] { new Subject("Romana", new Grades(new int[] { 8, 9, 10 })),
                                                                                 new Subject("Matematica",new Grades(new int[] { 10, 10, 7 }))}),
                                           new Student("Marcel", new Subject[] { new Subject("Romana", new Grades(new int[] { 7, 6, 8 })),
                                                                                 new Subject("Matematica",new Grades(new int[] { 8, 5, 5 }))}),
                                           new Student("Alexandru", new Subject[] { new Subject("Romana", new Grades(new int[] { 8, 9, 7 })),
                                                                                    new Subject("Matematica",new Grades(new int[] { 10, 6, 5 }))})};
            var classbook = new Classbook(students);
            var expected = students[2];
            classbook.SortStudentsAlphabetically();
            Student student;
            Assert.IsTrue(classbook.GetNext(out student));
            Assert.AreEqual(true, expected.IsSameStudent(student));
        }

        [TestMethod]
        public void SortStudentsByGeneralAverageTest()
        {
            var students = new Student[] { new Student("Florin", new Subject[] { new Subject("Romana", new Grades(new int[] { 8, 9, 10 })),
                                                                                 new Subject("Matematica",new Grades(new int[] { 10, 10, 7 }))}),
                                           new Student("Marcel", new Subject[] { new Subject("Romana", new Grades(new int[] { 7, 6, 8 })),
                                                                                 new Subject("Matematica",new Grades(new int[] { 8, 5, 5 }))}),
                                           new Student("Alexandru", new Subject[] { new Subject("Romana", new Grades(new int[] { 8, 9, 7 })),
                                                                                    new Subject("Matematica",new Grades(new int[] { 10, 6, 5 }))})};
            var classbook = new Classbook(students);
            var expected = students[0];
            classbook.SortStudentsByGeneralAverage();
            Student student;
            Assert.IsTrue(classbook.GetNext(out student));
            Assert.AreEqual(true, expected.IsSameStudent(student));
        }

        [TestMethod]
        public void FindStudentsAfterSpecificAverageTest()
        {
            var students = new Student[] { new Student("Florin", new Subject[] { new Subject("Romana", new Grades(new int[] { 8, 9, 10 })),
                                                                                 new Subject("Matematica",new Grades(new int[] { 10, 10, 7 }))}),
                                           new Student("Marcel", new Subject[] { new Subject("Romana", new Grades(new int[] { 7, 6, 8 })),
                                                                                 new Subject("Matematica",new Grades(new int[] { 8, 5, 5 }))}),
                                           new Student("Alexandru", new Subject[] { new Subject("Romana", new Grades(new int[] { 8, 9, 7 })),
                                                                                    new Subject("Matematica",new Grades(new int[] { 10, 6, 5 }))})};
            var specificAverage = 9;
            var classbook = new Classbook(students);
            var expected = students[0];
            Student student;
            classbook.SearchForStudentsAfterSpecificAverage(specificAverage, out student);
            Assert.IsTrue(classbook.SearchForStudentsAfterSpecificAverage(specificAverage, out student));
            Assert.AreEqual(true, expected.IsSameStudent(student));
        }

        [TestMethod]
        public void FindStudentsWithHighestGradeTest()
        {
            var students = new Student[] { new Student("Florin", new Subject[] { new Subject("Romana", new Grades(new int[] { 8, 9, 10 })),
                                                                                 new Subject("Matematica",new Grades(new int[] { 10, 10, 7 }))}),
                                           new Student("Marcel", new Subject[] { new Subject("Romana", new Grades(new int[] { 7, 6, 8 })),
                                                                                 new Subject("Matematica",new Grades(new int[] { 8, 5, 5 }))}),
                                           new Student("Alexandru", new Subject[] { new Subject("Romana", new Grades(new int[] { 8, 9, 7 })),
                                                                                    new Subject("Matematica",new Grades(new int[] { 10, 6, 5 }))})};
            var classbook = new Classbook(students);
            var expected = students[0];
            Student student;
            classbook.SearchStudentsWithHighestGrade(out student);
            Assert.IsTrue(classbook.SearchStudentsWithHighestGrade(out student));
            Assert.AreEqual(true, expected.IsSameStudent(student));
        }

        [TestMethod]
        public void FindStudentsWithWithLowestAverageTest()
        {
            var students = new Student[] { new Student("Florin", new Subject[] { new Subject("Romana", new Grades(new int[] { 8, 9, 10 })),
                                                                                 new Subject("Matematica",new Grades(new int[] { 10, 10, 7 }))}),
                                           new Student("Marcel", new Subject[] { new Subject("Romana", new Grades(new int[] { 7, 6, 8 })),
                                                                                 new Subject("Matematica",new Grades(new int[] { 8, 5, 5 }))}),
                                           new Student("Alexandru", new Subject[] { new Subject("Romana", new Grades(new int[] { 8, 9, 7 })),
                                                                                    new Subject("Matematica",new Grades(new int[] { 10, 6, 5 }))})};
            var classbook = new Classbook(students);
            var expected = students[1];
            Student student;
            classbook.SearchStudentsWithLowestAverage(out student);
            Assert.IsTrue(classbook.SearchStudentsWithLowestAverage(out student));
            Assert.AreEqual(true, expected.IsSameStudent(student));
        }
    }
}
