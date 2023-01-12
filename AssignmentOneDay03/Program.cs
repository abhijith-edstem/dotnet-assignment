// Memory Based Address Book

var addressBook = new AddressBook();

List<Contact> cachedContacts = new List<Contact>();

for (int i = 0; i < 3; i++)  
{
    string firstName = string.Empty;
    string lastName = string.Empty;
    string phone = string.Empty;
    string email = string.Empty;

    Console.Write("Please enter your first name : ");
    firstName = Console.ReadLine();
    if (string.IsNullOrEmpty(firstName))
    {
        Console.WriteLine("you have not entered any value : ");
    }
    else
    {
        Console.Write("Please enter your last name : ");
        lastName = Console.ReadLine();

        Console.Write("Please enter your phone : ");
        phone = Console.ReadLine();

        Console.Write("Please enter your email : ");
        email = Console.ReadLine();

        var contact = new Contact(firstName, lastName, phone, email);
        addressBook.AddContact(contact);

        cachedContacts.Add(contact);
    }
}

Console.WriteLine("Printing contacts");
addressBook.PrintContacts();

Console.WriteLine("Sorting contacts");
addressBook.SortContacts();
addressBook.PrintContacts();

for (int i=0; i < 3; i++)
{
    Console.WriteLine("removing contacts ");
    addressBook.RemoveContact(cachedContacts[i]);
    addressBook.PrintContacts();
}

