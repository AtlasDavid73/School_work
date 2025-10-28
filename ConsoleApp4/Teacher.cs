using System;
using System.Linq;

public class Teacher
{
    // Fields
    private string name;
    private string subject;
    private string[] courses;

    // Properties - Public accessors
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Subject
    {
        get { return subject; }
        set { subject = value; }
    }

    public string[] Courses
    {
        get { return courses; }
        set { courses = value; }
    }

    // Constructor - Initializes all fields
    public Teacher(string name, string subject, string[] courses)
    {
        this.name = name;
        this.subject = subject;
        this.courses = courses;
    }

    // Method 1: Display teacher's name and subject
    public void DisplayTeacherInfo()
    {
        Console.WriteLine($"Teacher: {name}");
        Console.WriteLine($"Subject: {subject}");
    }

    // Method 2: Display all courses using a loop
    public void ListCourses()
    {
        Console.WriteLine($"\nCourses taught by {name}:");
        for (int i = 0; i < courses.Length; i++)
        {
            Console.WriteLine($"  {i + 1}. {courses[i]}");
        }
    }

    // Method 3: Search for a course containing the keyword
    public void FindCourse(string keyword)
    {
        Console.WriteLine($"\nSearching for courses containing '{keyword}':");
        bool found = false;

        foreach (string course in courses)
        {
            if (course.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"  - {course}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine($"  No courses found containing '{keyword}'");
        }
    }
}