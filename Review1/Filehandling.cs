using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Review1
{
    
    internal class Filehandling
    {
        
        public void CreateFile(string path)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.Write("This is an example");
            }
            
            

        }
        public void ReadFile(string path)
        {
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string content = reader.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
            else
            {
                Console.WriteLine("File Doesn't Exists");
            }
        }

        public void UpdateFile(string path)
        {
            if (File.Exists(path))
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.Write("Append the text");
                }
            }
            else
            {
                Console.WriteLine("File Doesn't Exists");
            }
        }
        public void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                Console.WriteLine("File Doesn't Exists");
            }
        }
       
    }
}
