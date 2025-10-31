using System.Text.Json;
using ContactsJSON;

namespace ContactsJSON;

public class ContactRepository
{
    private const string FileName = "contacts.json";

    public Contact[] ReadContactsFromFile()
    {
        if (!File.Exists(FileName))
        {
            return new Contact[0];
        }

        string json = File.ReadAllText(FileName);
        Contact[] contacts = JsonSerializer.Deserialize<Contact[]>(json) ?? new Contact[0];
        return contacts;

    }

    public void writeContactToFile(Contact contact)
    {
        Contact[] existingContacts = ReadContactsFromFile();    // Get the Existing Contacts

        Contact[] updatedContacts = new Contact[existingContacts.Length + 1]; // Create a bigger array to hold new contacts

        // copy elements from existing to update
        for (int i = 0; i <existingContacts.Length; i++)
        {
            updatedContacts[i] = existingContacts[i];
        }

        // Add the new contact to the last elements 
        updatedContacts[updatedContacts.Length - 1] = contact;

        // Serialize and overwrite file
        string json = JsonSerializer.Serialize(updatedContacts, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(FileName, json);
    }
}