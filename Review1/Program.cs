namespace Review1
{
    internal class Program
    {
        //List<School> students = new List<School>();
        //public void AddStudent()
        //{
        //    Console.WriteLine("Enter the patient");
        //    string name = Console.ReadLine();
        //    School patient = new School(name);
        //    students.Add(patient);
        //    Console.WriteLine("Patient Added");
        //}

        //public void SortStudents()
        //{
        //    students.Sort();
        //    Console.WriteLine("Sorted List in Ascending");
        //    foreach (var i in students)
        //    {
        //        Console.WriteLine(i.ToString());
        //    }
        //}

        /*static void Main(string[] args)
        {
            Program program = new Program();
            program.AddStudent();
            program.AddStudent();
            program.AddStudent();
            program.SortStudents();
        }*/
        
        
            public static void Main(string[] args)
            {
                Filehandling f = new Filehandling();
                FileNameValidation fn = new FileNameValidation();
                string filepath = "";

                while (true)
                {
                    Console.WriteLine("Create file 1");
                    Console.WriteLine("Read file 2");
                    Console.WriteLine("Update file 3");
                    Console.WriteLine("Delete file 4");
                    Console.WriteLine("Exit 0");
                    Console.WriteLine("Choose Option");
                    string option = Console.ReadLine();
                    if (option == "1")
                    {
                        try
                        {
                            filepath = fn.Path();
                            f.CreateFile(filepath);
                            Console.WriteLine("File has been created!!");

                        }
                        catch (ValidException e)
                        {
                            Console.WriteLine(e.Message);
                        }

                    }
                    else if (option == "2")
                    {
                        f.ReadFile(filepath);

                    }
                    else if (option == "3")
                    {
                        f.UpdateFile(filepath);
                        Console.WriteLine("Updated");
                    }
                    else if (option == "4")
                    {
                        f.DeleteFile(filepath);
                        Console.WriteLine("Deleted");
                    }
                    else if (option == "0")
                    {
                        Console.WriteLine("exiting");
                        break;
                    }
                }



            }
        }
    }




