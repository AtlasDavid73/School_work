using ContactsJSON;

namespace ContactsJSON;

public static class ConsoleIO
{
    public static int DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("Contact Manager");
            Console.WriteLine("1. View all Contacts");
            Console.WriteLine("2. Add a Contact");
            Console.WriteLine("3. Exit\n");
            Console.Write("Enter your choice: ");

            string? input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 3)
            {
                return choice;
            }

            Console.WriteLine("Invalid choice. Please try again.");
            Console.WriteLine();
        }
    }

    public static Contact CreateContact()
    {
        Console.WriteLine("Create a new contact:");

        Contact newContact = new Contact();

        newContact.FirstName = GetRequiredString("Enter the contact's first name: ");
        newContact.LastName = GetRequiredString("Enter the contact's last name: ");
        newContact.Email = GetRequiredString("Enter the contact's email: ");
        newContact.DoB = GetPastDate("Enter the contact's date of birth (YYYY-MM-DD): ");

        return newContact;
    }

    public static void DisplayContact(Contact c)
    {
        Console.WriteLine("===========================================");
        Console.WriteLine($"First Name: {c.FirstName}");
        Console.WriteLine($"Last Name: {c.LastName}");
        Console.WriteLine($"Email: {c.Email}");
        Console.WriteLine($"Date of Birth: {c.DoB.ToShortDateString()}");
        Console.WriteLine();
        Console.WriteLine("===========================================\n");
    }

    public static void AnyKey()
    {
        Console.Write("Press any key to continue...");
        Console.ReadKey();
    }
    
    private static string GetRequiredString(string prompt)
    {
        string? input;

        while (true)
        {
            Console.Write(prompt);
            input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            Console.WriteLine("Input cannot be empty. Please try again.");
            Console.WriteLine();
        }
    }

    private static DateOnly GetPastDate(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (DateOnly.TryParse(input, out DateOnly date))
            {
                if (date <= DateOnly.FromDateTime(DateTime.Today))
                {
                    return date;
                }
                else
                {
                    Console.WriteLine("Date must be in the past. Please try again.");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter a valid date (YYYY-MM-DD).");
                Console.WriteLine();
            }
        }
    }
}