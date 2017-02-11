using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparables
{
    class Student : IComparable
    {
        private string name;
        private double grade;

        public Student(string name, double grade)
        {
            this.name = name;
            this.grade = grade;
        }

        public int CompareTo(object obj)
        {
            Student other = obj as Student;
            return this.grade.CompareTo(other.grade);
        }

        public override string ToString()
        {
            return name + " " + grade;
        }
    }
}
