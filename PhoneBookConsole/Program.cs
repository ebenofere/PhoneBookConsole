// See https://aka.ms/new-console-template for more information

using PhoneBookConsole;

Console.WriteLine("Hello, from the Console PhoneBook App!");
Console.WriteLine("Select operation");
Console.WriteLine("1 Add Contact");
Console.WriteLine("2 Display contact by number");
Console.WriteLine("3 View all contacts");
Console.WriteLine("4 Search for contacts for a given name");
Console.WriteLine("Press 'x' to exit");

var userInput = Console.ReadLine();

var phoneBook = new PhoneBook();

while (true)
{
    switch (userInput)
    {
        case "1":
            Console.WriteLine("Contact name:");
            var name = Console.ReadLine();
            Console.WriteLine("Contact number;");
            var number = Console.ReadLine();

            var newContact = new Contact(name, number);
            phoneBook.AddContact(newContact);

            break;
        case "2":
            Console.WriteLine("Search for contact by number");
            var contactNo = Console.ReadLine();
            phoneBook.DisplayContact(contactNo);

            break;
        case "3":
            phoneBook.DisplayAllContact();

            break;
        case "4":
            Console.WriteLine("Search for contact by name");
            var contactName = Console.ReadLine();
            phoneBook.DisplayMatchingContacts(contactName);

            break;
        case "x":
            return;
        default:
            Console.WriteLine("Select valid operation");
            break;
    }

    Console.WriteLine("Select operation");
    userInput = Console.ReadLine();
}