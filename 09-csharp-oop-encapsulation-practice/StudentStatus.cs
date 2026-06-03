/*Student Status Based on Average using Encapsulation

You are developing a school report system. Each student has two grades, and the final status ("Approved" or "Failed") must not be entered manually. Instead, the status must be calculated automatically based on the average of the two grades.

Create a class called "Student" with:
- Public property "Name".
- Public properties "Grade1" and "Grade2", both with get and set.
- Public read-only property "Average".
- Public read-only property "Status", which returns:
  * "Approved" if the average is greater than or equal to 6.
  * "Failed" if it is lower.

Example Input:
Student student = new Student("Lucas Rocha");
student.Grade1 = 7.5;
student.Grade2 = 5.0;

Expected Output:
Student: Lucas Rocha
Average: 6.25
Status: Approved
*/

class Student
{
    public string Name { get; }
    public double Grade1 { get; set; }
    public double Grade2 { get; set; }
    public Student(string name)
    {
        Name = name;
    }
    public double Average => (Grade1 + Grade2) / 2;

    public string Status => Average >= 6 ? "Approved" : "Failed";

}

class Program
{
    static void Main()
    {
        Student student = new Student("Lucas Rocha");
        student.Grade1 = 7.5;
        student.Grade2 = 5.0;

        Console.WriteLine($"Student: {student.Name}");
        Console.WriteLine($"Average: {student.Average}");
        Console.WriteLine($"Status: {student.Status}");
    }
}