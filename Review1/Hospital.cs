using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    internal class Hospital
    {
        public string PatientName;

        public Hospital(string PatientName)
        {
            this.PatientName = PatientName;
        }

        public override string ToString()
        {
            return PatientName;
        }
    }
}
