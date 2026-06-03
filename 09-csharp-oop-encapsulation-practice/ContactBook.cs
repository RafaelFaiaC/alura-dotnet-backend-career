/*Contact Book with Duplicate Control using Encapsulation

You are developing a personal contact book system. Each contact book can contain multiple contacts, but you want to ensure that:
- The contact list cannot be accessed or modified directly from outside the class.
- No contact with the same name is added twice.
- The system informs whether the contact was successfully added or rejected, so other parts can react.

To do this, create:
- A class "Contact", with:
  * Public properties "Name" and "Phone".
- A class "ContactBook", with:
  * Public property "Owner".
  * A private and readonly field "contacts" (of type List<Contact>).
  * A public method "bool AddContact(Contact contact)", which checks if the name already exists.
  * A method "DisplayContacts()", which prints the contacts.
  * A public read-only property "ContactCount".

Example Input:
ContactBook book = new ContactBook("Marina Souza");
book.AddContact(new Contact("Carlos", "11998887777"));
book.AddContact(new Contact("Carlos", "11991112222")); // duplicate
book.AddContact(new Contact("Julia", "21988776655"));
book.DisplayContacts();

Expected Output:
A contact with this name is already in the contact book.
Contact Book of: Marina Souza
Contacts:
- Carlos | 11998887777
- Julia  | 21988776655
Total contacts: 2
*/

class Contact
{
    public string Name { get; }
    public string Phone { get; }
    public Contact(string name, string phone)
    {
        Name = name;
        Phone = phone;
    }
}

class ContactBook
{
    public string Owner { get; }
    private readonly List<Contact> contacts = new List<Contact>();
    public ContactBook(string owner)
    {
        Owner = owner;
        contacts = new List<Contact>();
    }
    public bool AddContact(Contact contact)
    {
        if (contacts.Any(c => c.Name == contact.Name))
        {
            Console.WriteLine("A contact with this name is already in the contact book.");
            return false;
        }
        contacts.Add(contact);
        return true;
    }
    public void DisplayContacts()
    {
        Console.WriteLine($"Contact Book of: {Owner}");
        Console.WriteLine("Contacts:");
        foreach (var contact in contacts)
        {
            Console.WriteLine($"- {contact.Name} | {contact.Phone}");
        }
        Console.WriteLine($"Total contacts: {contacts.Count}");
    }
    public int ContactCount => contacts.Count;
}

class Program
{
    static void Main()
    {
        ContactBook book = new ContactBook("Marina Souza");
        book.AddContact(new Contact("Carlos", "11998887777"));
        book.AddContact(new Contact("Carlos", "11991112222")); // duplicate
        book.AddContact(new Contact("Julia", "21988776655"));
        book.DisplayContacts();
    }
}