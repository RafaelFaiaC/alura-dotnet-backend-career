/*Enrollment Control using Encapsulation and Relationships

You are developing an enrollment control system for a school. In this system, a student can only be enrolled if the course still has available slots. The rule is clear: if the number of already enrolled students reaches the limit, new enrollments must be rejected.

You need to model two classes:
- "Course" class:
  * Public property "Name".
  * Public property "TotalSlots" (set in the constructor).
  * Private field "enrollments" (list of students).
  * Method "bool Enroll(Student student)" that:
    - Adds the student if there is an available slot.
    - Displays an error message and returns false otherwise.
  * Method "DisplayEnrolled()", which shows all enrolled students.
  * Read-only property "AvailableSlots".
- "Student" class:
  * Public property "Name" (set via constructor).

Example Input:
Course course = new Course("Programming Logic", 2);
course.Enroll(new Student("Rafaela"));
course.Enroll(new Student("João"));
course.Enroll(new Student("Mirela")); // exceeds the limit
course.DisplayEnrolled();

Expected Output:
Student enrolled successfully.
Student enrolled successfully.
Error: There are no available slots for this course.

Students enrolled in Programming Logic:
- Rafaela
- João
Available slots: 0
*/

class Course
{
    public string Name { get; }
    public int TotalSlots { get; }
    private List<Student> enrollments;
    public Course(string name, int totalSlots)
    {
        Name = name;
        TotalSlots = totalSlots;
        enrollments = new List<Student>();
    }
    public bool Enroll(Student student)
    {
        if (enrollments.Count < TotalSlots)
        {
            enrollments.Add(student);
            Console.WriteLine("Student enrolled successfully.");
            return true;
        }
        else
        {
            Console.WriteLine("Error: There are no available slots for this course.");
            return false;
        }
    }
    public void DisplayEnrolled()
    {
        Console.WriteLine($"Students enrolled in {Name}:");
        foreach (var student in enrollments)
        {
            Console.WriteLine($"- {student.Name}");
        }
        Console.WriteLine($"Available slots: {AvailableSlots}");
    }
    public int AvailableSlots => TotalSlots - enrollments.Count;
}

class Student
{
    public string Name { get; }
    public Student(string name)
    {
        Name = name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Course course = new Course("Programming Logic", 2);
        course.Enroll(new Student("Rafaela"));
        course.Enroll(new Student("João"));
        course.Enroll(new Student("Mirela")); // exceeds the limit
        course.DisplayEnrolled();
    }
}