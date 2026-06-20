using System;
using System.Collections.Generic;
class Program
{
    static List<string> studentNames = new List<string>();
    static List<double> studentGrades = new List<double>();
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n===== STUDENT MANAGEMENT SYSTEM =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. View Individual Student Average");
            Console.WriteLine("4. View Class Average");
            Console.WriteLine("5. View Top Student");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
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
                    ViewStudentAverage();
                    break;
                case "4":
                    ViewClassAverage();
                    break;
                case "5":
                    ViewTopStudent();
                    break;
                case "6":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
    static void AddStudent()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();
        Console.Write("Enter student's grade: ");
        double grade = Convert.ToDouble(Console.ReadLine());
        studentNames.Add(name);
        studentGrades.Add(grade);
        Console.WriteLine("Student added successfully.");
    }
    static void ViewStudents()
    {
        if (studentNames.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }
        Console.WriteLine("\nStudent List:");
        for (int i = 0; i < studentNames.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " +
                              studentNames[i] +
                              " - Grade: " +
                              studentGrades[i]);
        }
    }
    static void ViewStudentAverage()
    {
        if (studentNames.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }
        Console.Write("Enter student name: ");
        string search = Console.ReadLine();
        for (int i = 0; i < studentNames.Count; i++)
        {
            if (studentNames[i].ToLower() == search.ToLower())
            {
                Console.WriteLine("Average of " +
                                  studentNames[i] +
                                  ": " +
                                  studentGrades[i]);
                return;
            }
        }
        Console.WriteLine("Student not found.");
    }
    static void ViewClassAverage()
    {
        if (studentGrades.Count == 0)
        {
            Console.WriteLine("No grades available.");
            return;
        }
        double total = 0;
        foreach (double grade in studentGrades)
        {
            total += grade;
        }
        double average = total / studentGrades.Count;
        Console.WriteLine("Class Average: " + average);
    }
    static void ViewTopStudent()
    {
        if (studentGrades.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }
        double highest = studentGrades[0];
        string topStudent = studentNames[0];
        for (int i = 1; i < studentGrades.Count; i++)
        {
            if (studentGrades[i] > highest)
            {
                highest = studentGrades[i];
                topStudent = studentNames[i];
            }
        }
        Console.WriteLine("Top Student: " + topStudent);
        Console.WriteLine("Highest Grade: " + highest);
    }
}