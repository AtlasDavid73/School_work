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
    public Student(string studentName, int[] studentGrades)
    {
        name = studentName;
        grades = studentGrades;
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

// Example usage:
class Program
{
    static void Main()
    {
        // Create a student with grades
        int[] myGrades = { 85, 92, 78, 95, 88 };
        Student student = new Student("David Smith", myGrades);

        // Display student information
        student.DisplayStudentInfo();

        // Calculate and display average
        double average = student.CalculateAverage();
        Console.WriteLine($"Average Grade: {average:F2}");

        // Get and display letter grades
        string[] letterGrades = student.FindLetterGrades();
        Console.WriteLine("\nLetter Grades:");
        for (int i = 0; i < letterGrades.Length; i++)
        {
            Console.WriteLine($"Grade {i + 1}: {student.Grades[i]} = {letterGrades[i]}");
        }
    }
}
