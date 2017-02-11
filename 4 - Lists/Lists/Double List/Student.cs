using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_List
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

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            Student other = obj as Student;
            return name == other.name && grade == other.grade;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode() | grade.GetHashCode();
        }

        public static bool operator ==(Student a, Student b)
        {
            if ((object)a == null)
                if ((object)b == null) return true;
                else return false;
            return (a.Equals(b));
        }

        public static bool operator !=(Student a, Student b)
        {
            return !(a == b);
        }
    }
}
