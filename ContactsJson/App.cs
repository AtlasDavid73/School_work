namespace ContactsJSON;
public class App
{
    private ContactRepository _repository;

    public App()
    {
        _repository = new ContactRepository();
    }

    public void Run()
    {
        while (true)
        {
            Console.Clear();
            int choice = ConsoleIO.DisplayMenu();

            switch (choice)
            {
                case 1:
                    ViewContacts();
                    break;
                case 2:
                    AddContact();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            ConsoleIO.AnyKey();
            Console.WriteLine();
        }
    }

    private void ViewContacts()
    {
        Console.WriteLine("All Contacts:");

        Contact[] contacts = _repository.ReadContactsFromFile();

        if (contacts.Length == 0)
        {
            Console.WriteLine("No contacts found.");
        }
        else
        {
            foreach (Contact c in contacts)
            {
                ConsoleIO.DisplayContact(c);
            }
        }
    }

    private void AddContact()
    {
        Contact newContact = ConsoleIO.CreateContact();
        _repository.writeContactToFile(newContact);
        Console.WriteLine("Contact added successfully.");
    }
}