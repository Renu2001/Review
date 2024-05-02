namespace Review1
{
    internal class Program
    {
        List<School> students = new List<School>();
        public void AddStudent()
        {
            Console.WriteLine("Enter the patient");
            string name = Console.ReadLine();
            School patient = new School(name);
            students.Add(patient);
            Console.WriteLine("Patient Added");
        }

        public void SortStudents()
        {
            students.Sort();
            Console.WriteLine("Sorted List in Ascending");
            foreach (var i in students)
            {
                Console.WriteLine(i.ToString());
            }
        }

        /*static void Main(string[] args)
        {
            Program program = new Program();
            program.AddStudent();
            program.AddStudent();
            program.AddStudent();
            program.SortStudents();
        }*/
    }
}

