/*Minimum Grade Validation using Encapsulation

You are developing a grading system for a school. A teacher can only assign grades greater than or equal to 0 and less than or equal to 10. No other part of the system can directly alter a student's grade.

Create a class called "Grading" with:
- A public property "Student".
- A property "Grade", with a public get and a private set.
- A public method "AssignGrade(double grade)" that only allows values between 0 and 10. If the value is invalid, display an error message.

Example Input:
Grading grading = new Grading("Carla Silva");
grading.AssignGrade(11);   // invalid
grading.AssignGrade(8.5);  // valid

Expected Output:
Error: The grade must be between 0 and 10.
Student: Carla Silva
Assigned grade: 8.5
*/

class Grading
{
    public string Student { get; }
    public double Grade { get; private set; }
    public Grading(string student)
    {
        Student = student;
    }
    public void AssignGrade(double grade)
    {
        if (grade < 0 || grade > 10)
        {
            Console.WriteLine("Error: The grade must be between 0 and 10.");
        }
        else
        {
            Grade = grade;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Grading grading = new Grading("Carla Silva");
        grading.AssignGrade(11);   // invalid
        grading.AssignGrade(8.5);  // valid

        Console.WriteLine($"Student: {grading.Student}");
        Console.WriteLine($"Assigned grade: {grading.Grade}");
    }
}