using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationListStudentNamesMeth
{
    class Program
    {
        static void Main(string[] args)
        {

            int userChoice = 0;

            List<string> studentNames = new List<string>() { "Mike_Smith", "Carlos_Jones", "Tom_Thompson" };

            do
            {
                userChoice = 0;

                Console.WriteLine();
                Console.WriteLine("STUDENT RECORDS - OPTIONS");
                Console.WriteLine("1 - Add another student\n2 - Clear out all students\n3 - List all students\n4 - Show count of students\n5 - Save to a file\n6 - Exit");
                int.TryParse(Console.ReadLine(), out userChoice);



                switch (userChoice)
                {

                    case 1:

                        AddStudentName(studentNames);
                        break;

                    case 2:

                        ClearStudents(studentNames);
                        break;

                    case 3:

                        PrintStudents(studentNames);
                        break;

                    case 4:

                        CountStudents(studentNames);
                        break;

                    case 5:
                        SaveToFile(studentNames);
                        break;

                    case 6:

                        break;

                    default:

                        break;

                }
            }

            while (userChoice != 6);
            Console.WriteLine();

        }

        static void AddStudentName(List<string> newNames)
        {
            Console.WriteLine("Add Student Name:");
            string studentName = Console.ReadLine();
            newNames.Add(studentName);
        }

        static void ClearStudents(List<string> newNames)
        {
            Console.WriteLine("Clear out all students:");
            newNames.Clear();           
        }
        static void PrintStudents(List<string> newNames)
        {
            for (int i = 0; i < newNames.Count; i++)
            {
                Console.WriteLine(newNames[i]);
            }
        }

        static void CountStudents(List<string> newNames)
        {
            Console.WriteLine("Show count of students?");
            Console.WriteLine(newNames.Count());
        }

        static void SaveToFile(List<string> newNames)
        {
            //StringBuilder stringbuildervar = new StringBuilder();

            StreamWriter writer = new StreamWriter("student_names.txt");
            using (writer)
            { 
                foreach (string name in newNames)                   
                {
                    writer.WriteLine(name);
                }
            }

            //StreamReader reader = new StreamReader("student_names.txt");
            //using (reader)
            //{
            //    Console.WriteLine(reader.ReadToEnd());1
            //}
        }

    }
}
