using System;

namespace ContactsProject.Contacts;

public class CreateUpdateContactDto
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime Birthday { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? StreetAddress { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public int Zip { get; set; }
}
