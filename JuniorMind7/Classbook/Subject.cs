using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classbook
{
    public class Subject
    {
        private string nameOfSubject;
        private Grades grades;


        public Subject(string name, Grades grades)
        {
            this.nameOfSubject = name;
            this.grades = grades;
        }

        public void AddGrade(int newGrade)
        {
            grades.AddGrade(newGrade);
        }

        public double GeneralAverage()
        {
            return grades.GeneralAverage();
        }

        public int CountGradesOfTen()
        {
            return grades.CountGradesOfTen();
        }

        public bool IsSameSubject(string other)
        {
            return this.nameOfSubject.Equals(other);
        }
        public bool IsSameSubject(Subject other)
        {
            return this.nameOfSubject.Equals(other.nameOfSubject);
        }
    }
}
