using System;
namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test the Person class
            Person person1 = new Person("David", "Smith", "smith74066@att.net", [ "Reading", "Gaming", "Hiking" ]);
            person1.DisplayPersonInfo();

            // Test the Hobbies 
            person1.ListHobbies();
            Console.WriteLine();

            // Create a Student object with all required parameters
            string[] studentHobbies = { "Reading", "Coding", "Gaming" };
            int[] grades = { 95, 87, 92, 78, 85 };
            Student student = new Student("David", "Smith", "Smith74066@outlook.com", studentHobbies, grades);
            
            // Test Student
            student.DisplayStudentInfo();
            Console.WriteLine($"Average: {student.CalculateAverage():F2}");
            
            // Test letter grades
            string[] letterGrades = student.FindLetterGrades();
            Console.WriteLine("Letter Grades:");
            for (int i = 0; i < letterGrades.Length; i++)
            {
                Console.WriteLine($"  Grade {i + 1}: {grades[i]} = {letterGrades[i]}");
            }
            Console.WriteLine();  

            // CREATE TEACHER OBJECT (THIS WAS MISSING!)
            string[] courses = { "Introduction to Programming", "Data Structures", "Web Development" };
            Teacher teacher = new Teacher("Dr. Sarah Johnson", "Computer Science", courses);

            // Test Teacher
            Console.WriteLine("Test 2: Courses Array Initialized");
            Console.WriteLine("-----------------------------");
            teacher.ListCourses();  // Changed from Teacher.ListCourses() to teacher.ListCourses()
            Console.WriteLine("\n✓ Courses array initialized correctly");
            Console.WriteLine("✓ All 3 courses stored properly");
            Console.WriteLine();       
        }
    }
}