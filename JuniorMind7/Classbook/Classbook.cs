using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classbook
{
    class Classbook 
    {
        private Student[] students;
        private int index = 0;

        public Classbook(Student[] students)
        {
            this.students = students;
        }

        public bool GetNext(out Student student)
        {
            if (index < this.students.Length)
            {
                student = this.students[index++];
                return true;
            }
            student = null;
            return false;
        }

        public void SortStudentsAlphabetically()
        {
            HeapSort();
        }

        public void SortStudentsByGeneralAverage()
        {
            SelectionSort();
        }

        private void HeapSort()
        {
            int n = students.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(n, i);
            }
            for (int i = n - 1; i >= 0; i--)
            {
                Swap(ref students[0], ref students[i]);

                Heapify(i, 0);
            }
        }

        private void Heapify(int n, int root)
        {
            int largest = root;
            int left = 2 * root + 1;
            int right = 2 * root + 2;

            if (left < n && students[left].WhoIsFirstAlphabetically(students[largest]) != -1)
            {
                largest = left;
            }
            if (right < n && students[right].WhoIsFirstAlphabetically(students[largest]) != -1)
            {
                largest = right;
            }
            if (largest != root)
            {
                Swap(ref students[root], ref students[largest]);
                Heapify(n, largest);
            }
        }

        private static void Swap(ref Student student1, ref Student student2)
        {
            var temp = student1;
            student1 = student2;
            student2 = temp;
        }

        public void SelectionSort()
        {
            int n = students.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (students[j].GeneralAverageCompare(students[i]) == 1)
                        Swap(ref students[i], ref students[j]);
        }

        public bool SearchForStudentsAfterSpecificAverage(double specificAverage, out Student student)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (specificAverage == students[i].CalculateTotalGeneralAverage())
                {
                    student = students[i];
                    return true;
                }
            }
            student = null;
            return false;
        }

        public bool SearchStudentsWithHighestGrade(out Student student)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].CountAllGradesOfTen() > students[i+1].CountAllGradesOfTen())
                {
                    student = students[i];
                    return true;
                }
            }
            student = null;
            return false;
        }

        public bool SearchStudentsWithLowestAverage(out Student student)
        {

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].CalculateTotalGeneralAverage() < students[i + 1].CalculateTotalGeneralAverage())
                {
                    student = students[i];
                    return true;
                }
            }
            student = null;
            return false;
        }
    }
}
