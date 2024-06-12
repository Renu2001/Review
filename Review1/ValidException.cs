using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    public class ValidException : ApplicationException
    {
        public ValidException(string message) : base(message)
        {

        }
    }
}
