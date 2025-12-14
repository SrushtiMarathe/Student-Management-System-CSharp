using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n=== Student Management System ===");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Search Student by ID");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;

                    case 2:
                        ViewStudents();
                        break;

                    case 3:
                        SearchStudent();
                        break;

                    case 4:
                        DeleteStudent();
                        break;

                    case 5:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 5);
        }

        static void AddStudent()
        {
            Student s = new Student();

            Console.Write("Enter Student ID: ");
            s.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            s.Name = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            s.Age = Convert.ToInt32(Console.ReadLine());

            students.Add(s);
            Console.WriteLine("Student added successfully!");
        }

        static void ViewStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }

            Console.WriteLine("\n--- Student List ---");
            foreach (Student s in students)
            {
                s.Display();
            }
        }

        static void SearchStudent()
        {
            Console.Write("Enter Student ID to search: ");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach (Student s in students)
            {
                if (s.Id == id)
                {
                    s.Display();
                    return;
                }
            }

            Console.WriteLine("Student not found!");
        }

        static void DeleteStudent()
        {
            Console.Write("Enter Student ID to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Student studentToRemove = null;

            foreach (Student s in students)
            {
                if (s.Id == id)
                {
                    studentToRemove = s;
                    break;
                }
            }

            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                Console.WriteLine("Student deleted successfully!");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }
    }
}
