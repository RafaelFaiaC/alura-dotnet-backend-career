/*User Authentication

You are responsible for implementing the authentication system for a corporate application. The system needs to differentiate between administrators, registered users, and visitors, ensuring appropriate access for each profile.

Create a program that:
- Requests the user to type their name.
- Checks if the name matches the administrator (e.g., "Admin").
- If it is not the administrator, display a "User not registered" message and present a menu with options:
  1. Register new user
  2. Access as guest
  3. Exit the system

Example Input:
Authentication System
-----------------------
Enter your username: Arthur Dent

Expected Output:
If the chosen option is to register a new user:
User not registered.
Available options:
[1] Register new user
[2] Access as guest
[3] Exit
1
New user 'Arthur Dent' registered successfully!

If the chosen option is to enter as a guest:
User not registered.
Available options:
[1] Register new user
[2] Access as guest
[3] Exit
2
Access granted as guest.

If the user is already registered:
Welcome, Arthur Dent!
*/

Console.WriteLine("Authentication System");
Console.WriteLine("-----------------------");
Console.Write("Enter your username: ");
string username = Console.ReadLine()!;

if (username == "Admin")
{
    Console.WriteLine("Welcome, Admin!");
}
else
{
    Console.WriteLine("\nUser not registered.");
    Console.WriteLine("Available options:");
    Console.WriteLine("[1] Register new user");
    Console.WriteLine("[2] Access as guest");
    Console.WriteLine("[3] Exit");
    Console.Write("\nEnter your option: ");
    string option = Console.ReadLine()!;
    switch (option)
    {
        case "1":
            Console.WriteLine($"New user '{username}' registered successfully!");
            break;
        case "2":
            Console.WriteLine("Access granted as guest.");
            break;
        case "3":
            Console.WriteLine("Exiting the system. Goodbye!");
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}