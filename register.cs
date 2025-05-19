using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRegistro
{
    class Register
    {
        private List<Student> students;

        public Register()
        {
            students = new List<Student>();
        }

        public void Add(string name, double grade, int schoolId)
        {
            students.Add(new Student(name, grade, schoolId));
        }

        public void Show()
        {
            foreach (var student in students)
            {
                Console.Write("Alumno: " + student.Name + " Matricula: " + student.SchoolId + " Promedio: " + student.Grade);
                Console.WriteLine();
            }
        }

        public void QuickSortName()
        {
            QuickSortName(0, students.Count - 1);
        }

        public void QuickSortID()
        {
            QuickSortID(0, students.Count - 1);
        }

        public void QuickSortGrade()
        {
            QuickSortGrade(0, students.Count - 1);
        }

        private void QuickSortName(int left, int right)
        {
            Stack<(int, int)> stack = new Stack<(int, int)>();
            stack.Push((left, right));

            while (stack.Count > 0)
            {
                (left, right) = stack.Pop();

                while (left < right)
                {
                    int pivot = PartitionName(left, right);
                    stack.Push((pivot + 1, right));
                    right = pivot - 1;
                }
            }
        }

        private void QuickSortID(int left, int right)
        {
            Stack<(int, int)> stack = new Stack<(int, int)>();
            stack.Push((left, right));

            while (stack.Count > 0)
            {
                (left, right) = stack.Pop();

                while (left < right)
                {
                    int pivot = PartitionID(left, right);
                    stack.Push((pivot + 1, right));
                    right = pivot - 1;
                }
            }
        }

        private void QuickSortGrade(int left, int right)
        {
            Stack<(int, int)> stack = new Stack<(int, int)>();
            stack.Push((left, right));

            while (stack.Count > 0)
            {
                (left, right) = stack.Pop();

                while (left < right)
                {
                    int pivot = PartitionGrade(left, right);
                    stack.Push((pivot + 1, right));
                    right = pivot - 1;
                }
            }
        }

        private int PartitionName(int left, int right)
        {
            string pivot = students[right].Name;
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (students[j].Name.ToLower()[0] < pivot.ToLower()[0])
                {
                    i++;
                    Exchange(i, j);
                }
            }

            Exchange(i + 1, right);
            return i + 1;
        }

        private int PartitionID(int left, int right)
        {
            int pivot = students[right].SchoolId;
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (students[j].SchoolId < pivot)
                {
                    i++;
                    Exchange(i, j);
                }
            }

            Exchange(i + 1, right);
            return i + 1;
        }

        private int PartitionGrade(int left, int right)
        {
            double pivot = students[right].Grade;
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (students[j].Grade < pivot)
                {
                    i++;
                    Exchange(i, j);
                }
            }

            Exchange(i + 1, right);
            return i + 1;
        }

        private void Exchange(int i, int j)
        {
            var temp = students[i];
            students[i] = students[j];
            students[j] = temp;
        }

        public void BinarySearch(int schoolId)
        {
            BinaryTree tree = new BinaryTree();
            foreach (var node in students)
            {
                tree.Add(node.SchoolId, node);
            }
            tree.SearchAndPrint(schoolId);
        }

        public void BinarySearch(string name)
        {
            BinaryTree tree = new BinaryTree();

            foreach (var node in students)
            {
                tree.Add(SumLetters(node.Name), node);
            }
            tree.SearchAndPrint(SumLetters(name));
        }

        public static int SumLetters(string text)
        {
            int sum = 0;
            foreach (char c in text.ToUpper())
            {
                if (char.IsLetter(c))
                    sum += c - 'A' + 1;
            }
            return sum;
        }
    }
}