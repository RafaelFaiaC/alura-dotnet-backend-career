/*Searching a List

Imagine you are developing a school roll call system for an educational institution. The person in charge needs to quickly verify if a specific student is present on the roll call list. Your program must traverse the list of names and, upon finding the sought-after student, interrupt immediately.

Create a program that:
- Defines a list of student names.
- Uses a loop to traverse the list.
- Interrupts the search when the desired name is found.
- Informs if the name is not found.

Example Input: For the following list of names: { "Ana", "Carlos", "Bianca", "João", "Marina" }.
Enter the student's name: João

Expected Output (if found):
Student found at position: 3

Expected Output (if not found):
Student is not present on the list
*/

List<string> studentNames = new List<string> { "Ana", "Carlos", "Bianca", "João", "Marina" };
bool found = false;

Console.WriteLine(@"Example Input: For the following list of names: { ""Ana"", ""Carlos"", ""Bianca"", ""João"", ""Marina"" }.");
Console.Write("Enter the student's name: ");
string studentToFind = Console.ReadLine()!;

int i = 0;

while (i < studentNames.Count)
{
    if (studentNames[i] == studentToFind)
    {
        Console.WriteLine($"Student found at position: {i + 1}");
        found = true;
        break; 
    }

    i++;
}

if (!found)
{
    Console.WriteLine("Student is not present on the list");
}