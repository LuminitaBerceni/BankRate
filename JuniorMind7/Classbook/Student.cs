using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classbook
{
    class Student
    {
        private string nameOfStudent;
        private Subject[] subjects;

        public Student(string name, Subject[] subjects)
        {
            this.nameOfStudent = name;
            this.subjects = subjects;
        }

        public void AddSubject(Subject newSubject)
        {
            Array.Resize(ref subjects, subjects.Length + 1);
            subjects[subjects.Length - 1] = newSubject;
        }

        public double CalculateTotalGeneralAverage()
        {
            double totalGeneralAverage = 0;
            for (int i = 0; i < subjects.Length; i++)
            {
                totalGeneralAverage = totalGeneralAverage + subjects[i].GeneralAverage();
            }
            return totalGeneralAverage / subjects.Length;
        }

        public int CountAllGradesOfTen()
        {
            int gradesOfTen = 0;
            for (int i = 0; i < subjects.Length; i++)
            {
                gradesOfTen = gradesOfTen + subjects[i].CountGradesOfTen();
            }
            return gradesOfTen;
        }

        public bool IsSameStudent(string other)
        {
            return this.nameOfStudent.Equals(other);
        }

        public bool IsSameStudent(Student other)
        {
            return this.nameOfStudent.Equals(other.nameOfStudent);
        }

        public double GeneralAverageCompare(Student other)
        {
            return CalculateTotalGeneralAverage().CompareTo(other.CalculateTotalGeneralAverage());
        }

        public int WhoIsFirstAlphabetically(Student otherStudent)
        {
            return string.Compare(nameOfStudent, otherStudent.nameOfStudent);
        }
    }
}

