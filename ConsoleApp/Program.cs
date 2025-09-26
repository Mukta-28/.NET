using System;
using System.Collections.Generic;
namespace StudentsManagementSystem
{

    class Student
    { 
      public int Id { get; set; }
      public string Name { get; set; }

      public int Age { get; set; }

        public void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}");
        }
    }
    internal class Program
    {
        static List<Student> students = new List<Student>();
        static int nextId = 1;
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== Student Management System ===");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Search Student by ID");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        ViewStudents();
                        break;
                    case "3":
                        SearchStudent();
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("Exiting... Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
        }
        static void AddStudent()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter student age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Student student = new Student { Id = nextId++, Name = name, Age = age };
            students.Add(student);

            Console.WriteLine("Student added successfully!");
        }
        static void ViewStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            Console.WriteLine("\n--- Student List ---");
            foreach (var student in students)
            {
                student.Display();
            }
        }
        static void SearchStudent()
        {
            Console.Write("Enter Student ID to search: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Student student = students.Find(s => s.Id == id);

            if (student != null)
                student.Display();
            else
                Console.WriteLine("Student not found.");
        }




    }
}
