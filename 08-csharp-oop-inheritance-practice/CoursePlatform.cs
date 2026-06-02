/*Course Platform combining Interfaces and Composition

Imagine you are developing a system for an online course platform. There are different types of courses, such as programming and design, and all of them must be validated and published, with specific messages for each type.

Additionally, each course has an associated instructor, with a name and specialty area. Your challenge is to create a system using a single interface and composition.

Create a program that:
- Creates an interface "ICourse" (or "ICurso"), with the methods:
  * "ValidateContent()"
  * "PublishCourse()"
- Creates the "Instructor" class, with the attributes:
  * "Name"
  * "Specialty"
- Creates two classes:
  * "ProgrammingCourse" and "DesignCourse", which implement "ICourse" and receive an "Instructor" through composition.
- In each class, implement the methods with personalized messages.

In Program.cs, instantiate the courses and call both methods:
- "ValidateContent()"
- "PublishCourse()"

Example Input:
Instructor instructor1 = new Instructor("Carla", "Back-end");
ICourse course1 = new ProgrammingCourse("C# with OOP", instructor1);

Instructor instructor2 = new Instructor("Felipe", "UI/UX");
ICourse course2 = new DesignCourse("Interface Design", instructor2);

course1.ValidateContent();
course1.PublishCourse();

course2.ValidateContent();
course2.PublishCourse();

Expected Output:
Validating content of the programming course: C# with OOP
Course published successfully: C# with OOP - Instructor: Carla (Back-end)

Validating content of the design course: Interface Design
Course published successfully: Interface Design - Instructor: Felipe (UI/UX)
*/

interface ICourse
{
    void ValidateContent();
    void PublishCourse();
}

class Instructor
{
    public string Name { get; }
    public string Specialty { get; }
    public Instructor(string name, string specialty)
    {
        Name = name;
        Specialty = specialty;
    }
}

class ProgrammingCourse : ICourse
{
    private string CourseName { get; }
    private Instructor CourseInstructor { get; }
    public ProgrammingCourse(string courseName, Instructor instructor)
    {
        CourseName = courseName;
        CourseInstructor = instructor;
    }
    public void ValidateContent()
    {
        Console.WriteLine($"Validating content of the programming course: {CourseName}");
    }
    public void PublishCourse()
    {
        Console.WriteLine($"Course published successfully: {CourseName} - Instructor: {CourseInstructor.Name} ({CourseInstructor.Specialty})");
    }
}

class DesignCourse : ICourse
{
    private string CourseName { get; }
    private Instructor CourseInstructor { get; }
    public DesignCourse(string courseName, Instructor instructor)
    {
        CourseName = courseName;
        CourseInstructor = instructor;
    }
    public void ValidateContent()
    {
        Console.WriteLine($"Validating content of the design course: {CourseName}");
    }
    public void PublishCourse()
    {
        Console.WriteLine($"Course published successfully: {CourseName} - Instructor: {CourseInstructor.Name} ({CourseInstructor.Specialty})");
    }
}

class Program
{
    static void Main()
    {
        Instructor instructor1 = new Instructor("Carla", "Back-end");
        ICourse course1 = new ProgrammingCourse("C# with OOP", instructor1);

        Instructor instructor2 = new Instructor("Felipe", "UI/UX");
        ICourse course2 = new DesignCourse("Interface Design", instructor2);

        course1.ValidateContent();
        course1.PublishCourse();

        Console.WriteLine();

        course2.ValidateContent();
        course2.PublishCourse();
    }
}