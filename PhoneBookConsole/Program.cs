// See https://aka.ms/new-console-template for more information

using PhoneBookConsole;

Console.WriteLine("Hello, from the Console PhoneBook App!");
Console.WriteLine("Select operation");
Console.WriteLine("1 Add Contact");
Console.WriteLine("2 Display contact by number");
Console.WriteLine("3 View all contacts");
Console.WriteLine("4 Search for contacts for a given name");

var userInput = Console.ReadLine();

var phoneBook = new PhoneBook();

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
        break;
    case "4":
        break;
    default:
        Console.WriteLine("Select valid operation");
        break;

}