using System;
using System.Collections.Generic;

class Student
{
    public string Name;
    public List<double> Grades;

    public Student(string name)
    {
        Name = name;
        Grades = new List<double>();
    }

    public double GetAverage()
    {
        double total = 0;

        foreach (double grade in Grades)
        {
            total += grade;
        }

        return total / Grades.Count;
    }
}