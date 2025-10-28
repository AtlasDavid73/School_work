using System;

public class Student
{
    // Fields
    private string name;
    private int[] grades;

    // Properties - Public accessors
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int[] Grades
    {
        get { return grades; }
        set { grades = value; }
    }

    // Constructor
    public Student(string studentName, String lastName, string email, string[] hobbies, int[] grades)
    {
        name = studentName;
        this.grades = grades;

    }

    // Method: Display student information
    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Student Name: {name}");
        Console.WriteLine($"Number of Grades: {grades.Length}");
    }

    // Method: Calculate average grade
    public double CalculateAverage()
    {
        if (grades.Length == 0)
        {
            return 0.0;
        }

        int sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }

        return (double)sum / grades.Length;
    }

    // Method: Convert numeric grades to letter grades
    public string[] FindLetterGrades()
    {
        string[] letterGrades = new string[grades.Length];

        for (int i = 0; i < grades.Length; i++)
        {
            int grade = grades[i];

            if (grade >= 90)
            {
                letterGrades[i] = "A";
            }
            else if (grade >= 80)
            {
                letterGrades[i] = "B";
            }
            else if (grade >= 70)
            {
                letterGrades[i] = "C";
            }
            else if (grade >= 60)
            {
                letterGrades[i] = "D";
            }
            else
            {
                letterGrades[i] = "F";
            }
        }

        return letterGrades;
    }
}

