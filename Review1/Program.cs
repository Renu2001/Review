namespace Review1
{
    internal class Program
    {
        List<Hospital> patients = new List<Hospital>();


        int numPatients;

        public void AddPatient()
        {
            Console.WriteLine("Enter the patient");
            string name = Console.ReadLine();
            Hospital patient = new Hospital(name);
            patients.Add(patient);
            Console.WriteLine("Patient Added");
        }
        public void RemovePatient()
        {
            Console.WriteLine("Enter name to delete");
            string name = Console.ReadLine();
            Hospital patient = patients.Find(x => x.PatientName == name);
            patients.Remove(patient);
            Console.WriteLine("Patient Removed");

        }
        public void SearchPatient()
        {
            Console.WriteLine("Enter name to search");
            string name = Console.ReadLine();
            foreach (var i in patients)
            {
                if (i.PatientName == name)
                {
                    Console.WriteLine("Record Found");
                    Console.WriteLine(i);
                    break;
                }
            }

        }

        public void Display()
        {
            Console.WriteLine("Patients Are :");
            foreach (var i in patients)
            {
                Console.WriteLine(i.ToString());
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            while (true)
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("Enter 1 to add");
                Console.WriteLine("Enter 2 to search");
                Console.WriteLine("Enter 3 to display");
                Console.WriteLine("Enter 4 to remove");
                string i = Console.ReadLine();

                if (i == "1")
                    program.AddPatient();
                else if (i == "2")
                    program.SearchPatient();
                else if (i == "3")
                    program.Display();
                else if (i == "4")
                    program.RemovePatient();
                else if (i == "0")
                    break;
            }



        }
    }
}

