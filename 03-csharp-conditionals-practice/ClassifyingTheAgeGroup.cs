/*Classifying the Age Group

Imagine you are developing a feature for a health insurance system. The idea is to classify a client according to their age into one of the following groups: child (0 to 12 years old), adolescent (13 to 17), adult (18 to 59), or senior (60 or older).

Create a program that:
- Receives the client's age as input.
- Classifies them into one of the groups:
  - Child (0 to 12 years old)
  - Adolescent (13 to 17 years old)
  - Adult (18 to 59 years old)
  - Senior (60 years old or older)
- Displays the corresponding category.

Example Input:
Enter the age: 18

Expected Output:
Classification: adult
*/

Console.Write("Enter the age: ");
int age = int.Parse(Console.ReadLine()!);

if (age >= 60)
{
    Console.WriteLine("Classification: senior");
}
else if (age >= 18)
{
    Console.WriteLine("Classification: adult");
}
else if (age >= 13)
{
    Console.WriteLine("Classification: adolescent");
}
else if (age >= 0)
{
    Console.WriteLine("Classification: child");
}
else
{
    Console.WriteLine("Invalid age entered.");
}