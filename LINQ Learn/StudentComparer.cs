using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Learn
{
    class StudentComparer : IEqualityComparer<Student>
    {
        bool IEqualityComparer<Student>.Equals(Student x, Student y)
        {
            if (x.Age == y.Age)
                return true;
            return false;
           
           
        }

        int IEqualityComparer<Student>.GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
    }
}
