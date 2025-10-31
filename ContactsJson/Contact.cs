using System.Diagnostics.Contracts;

namespace ContactsJSON;

public class Contact
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public DateOnly DoB { get; set; }
}