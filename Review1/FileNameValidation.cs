using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Review1
{
    internal class FileNameValidation
    {
        public string validate()
        {
            string pattern = "^([A-Z][a-z])(?=.*\\d){8}";
            Regex r = new Regex(pattern);
            Console.WriteLine("Enter Filename");
            string name = Console.ReadLine();
            if (r.IsMatch(name))
            {
                Console.WriteLine("Valid Name");
                return name;

            }
            else
            {
                throw new ValidException("Enter Valid Name");
            }
        }
        public string Path()
        {
            string path = $"D:\\{validate()}.txt";
            return path;
        }
    }
}
