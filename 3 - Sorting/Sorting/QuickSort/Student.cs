using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Student
    {
        private string name;
        private double grade;
        public Student(string name, double grade)
        {
            this.name = name;
            this.grade = grade;
        }
        public override string ToString()
        {
            return name + ": " + grade;
        }
        public static bool CompareName(object a, object b)
        {
            Student s1 = (Student)a;
            Student s2 = (Student)b;
            if (s1.name.CompareTo(s2.name) < 0)
                return true;
            else
                return false;
        }
        public static bool CompareGrade(object a, object b)
        {
            Student s1 = (Student)a;
            Student s2 = (Student)b;
            return s1.grade > s2.grade;
        }
    }
}
