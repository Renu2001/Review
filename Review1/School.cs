using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    internal class School : IComparable<School>
    {
        public string StudentName;


        public School(string StudentName)
        {
            this.StudentName = StudentName;

        }

        public int CompareTo(School newstudent)
        {
            if (newstudent == null)
                return 1;
            return string.Compare(this.StudentName, newstudent.StudentName);
        }

        public override string ToString()
        {
            return $"Name of the patient is : {StudentName} ";
        }

    }

}
