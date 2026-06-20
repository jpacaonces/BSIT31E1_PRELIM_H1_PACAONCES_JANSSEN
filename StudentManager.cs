using System;
using System.Collections.Generic;

class StudentManager
{
    private List<Student> students;

    public StudentManager()
    {
        students = new List<Student>();
    }

    public void AddStudent()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Student student = new Student(name);

        Console.Write("How many grades? ");
        int count = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter grade " + (i + 1) + ": ");
            double grade = Convert.ToDouble(Console.ReadLine());

            student.Grades.Add(grade);
        }

        students.Add(student);

        Console.WriteLine("Student added successfully.");
    }

    public void ViewStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        Console.WriteLine("\nStudent List:");

        foreach (Student student in students)
        {
            Console.WriteLine(student.Name);
        }
    }

    public void ViewStudentAverage()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        Console.Write("Enter student name: ");
        string search = Console.ReadLine();

        foreach (Student student in students)
        {
            if (student.Name.ToLower() == search.ToLower())
            {
                Console.WriteLine(
                    "Average of " +
                    student.Name +
                    ": " +
                    student.GetAverage().ToString("F2"));

                return;
            }
        }

        Console.WriteLine("Student not found.");
    }

    public void ViewClassAverage()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        double total = 0;

        foreach (Student student in students)
        {
            total += student.GetAverage();
        }

        double classAverage = total / students.Count;

        Console.WriteLine(
            "Class Average: " +
            classAverage.ToString("F2"));
    }

    public void ViewTopStudent()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        Student topStudent = students[0];

        foreach (Student student in students)
        {
            if (student.GetAverage() > topStudent.GetAverage())
            {
                topStudent = student;
            }
        }

        Console.WriteLine("Top Student: " + topStudent.Name);
        Console.WriteLine(
            "Average Grade: " +
            topStudent.GetAverage().ToString("F2"));
    }
}