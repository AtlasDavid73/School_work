using System;

public class Person
{
    // Fields
    private string firstName;
    private string lastName;
    private string email;
    private string[] hobbies;

    // Properties with public get and set accessors
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public string[] Hobbies
    {
        get { return hobbies; }
        set { hobbies = value; }
    }

    // Constructor
    public Person(string firstName, string lastName, string email, string[] hobbies)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
        this.hobbies = hobbies;
    }

    // Method 1: Display person's name and email
    public void DisplayPersonInfo()
    {
        Console.WriteLine($"Name: {firstName} {lastName}");
        Console.WriteLine($"Email: {email}");
    }

    // Method 2: List all hobbies using a loop
    public void ListHobbies()
    {
        Console.WriteLine("Hobbies:");
        for (int i = 0; i < hobbies.Length; i++)
        {
            Console.WriteLine($"  - {hobbies[i]}");
        }
    }

    // Method 3: Search for a hobby by keyword
    public void SearchHobby(string keyword)
    {
        Console.WriteLine($"Searching for hobbies containing '{keyword}':");
        bool found = false;

        for (int i = 0; i < hobbies.Length; i++)
        {
            if (hobbies[i].ToLower().Contains(keyword.ToLower()))
            {
                Console.WriteLine($"  - {hobbies[i]}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("  No matching hobbies found.");
        }
    }
}

