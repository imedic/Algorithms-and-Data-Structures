using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparers
{
    enum StudentComparerType { Name, Grade }

    class StudentComparer : IComparer
    {
        private StudentComparerType criterion;

        public StudentComparer(StudentComparerType criterion)
        {
            this.criterion = criterion;
        }

        public int Compare(object x, object y)
        {
            Student first = x as Student;
            Student second = y as Student;

            if (criterion == StudentComparerType.Name)
            {
                return first.Name.CompareTo(second.Name);
            }

            return first.Grade.CompareTo(second.Grade);
        }
    }
}
