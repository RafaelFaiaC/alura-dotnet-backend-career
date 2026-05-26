/*Verifying Access to a Restricted Area

Imagine you are developing an access control system for a highly secure research laboratory. Your task is to create a program that validates the credentials of anyone attempting to enter, ensuring that only authorized personnel gain access.

Create a program that:
- Receives a password.
- Receives an access level.
- Checks if:
  - The password is correct (Consider the correct password to be 42).
  - The access level is equal to or greater than 5.
- Displays "Access granted" if both criteria are met, or "Access denied" otherwise.

Example Input:
Enter the password: 1234
Enter the access level: 6

Expected Output:
Access denied.
*/

Console.Write("Enter the password: ");
int password = int.Parse(Console.ReadLine()!);

Console.Write("Enter the access level: ");
int accessLevel = int.Parse(Console.ReadLine()!);

if (password == 42 && accessLevel >= 5)
{
    Console.WriteLine("Access granted.");
}
else
{
    Console.WriteLine("Access denied.");
}