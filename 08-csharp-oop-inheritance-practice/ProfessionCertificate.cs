/*Profession Certificate with Abstraction

You are developing a system for an institution that issues professional validation certificates. Each registered profession needs to be recognized as a valid type, but the base entity (Profession) must not be instantiated directly, as it represents only an abstract concept.

Create a program that:
- Defines an abstract class "Profession" with a "title" attribute.
- Creates two classes that inherit from "Profession":
  * "Analyst": must receive the title via constructor.
  * "Teacher": must receive the title via constructor.
- Implements a "Certificate" class that:
  * Accepts any object of type "Profession" in its constructor.
  * Displays the formatted message: "Certificate issued for: <title>".

Example Input:
Analyst analyst = new Analyst("Systems Analyst");
Teacher teacher = new Teacher("Mathematics Teacher");

Certificate cert1 = new Certificate(analyst); 
Certificate cert2 = new Certificate(teacher);

Expected Output:
Certificate issued for: Systems Analyst
Certificate issued for: Mathematics Teacher
*/

abstract class Profession
{
    public string Title { get; }
    protected Profession(string title)
    {
        Title = title;
    }
}

class Analyst : Profession
{
    public Analyst(string title) : base(title) { }
}

class Teacher : Profession
{
    public Teacher(string title) : base(title) { }
}

class Certificate
{
    public Profession Profession { get; }
    public Certificate(Profession profession)
    {
        Profession = profession;
        Console.WriteLine($"Certificate issued for: {profession.Title}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Analyst analyst = new Analyst("Systems Analyst");
        Teacher teacher = new Teacher("Mathematics Teacher");

        Certificate cert1 = new Certificate(analyst);
        Certificate cert2 = new Certificate(teacher);
    }
}