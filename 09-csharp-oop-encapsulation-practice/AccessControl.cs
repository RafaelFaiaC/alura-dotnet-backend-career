/*Access Control using Access Modifiers

You are developing an access system for medical data. Sensitive information, such as a medical record code, must not be accessed from outside the application, but can still be read by classes within the same project.

Create two classes:
- "Patient" (public), with public properties "Name" and "Age".
- "MedicalHistory" (internal), containing a property "MedicalRecordCode" and a method "DisplayCode()" that prints the code on the console.

In the main program, create a patient and a medical history, and display the data.

Example Input:
Patient patient = new Patient("Luiz Costa", 42);
MedicalHistory history = new MedicalHistory("XPT-9987");
history.DisplayCode();

Expected Output:
Medical record code: XPT-9987
*/

public class Patient
{
    public string Name { get; }
    public int Age { get; }
    public Patient(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class MedicalHistory
{
    private string MedicalRecordCode { get; }
    public MedicalHistory(string code)
    {
        MedicalRecordCode = code;
    }
    public void DisplayCode()
    {
        Console.WriteLine($"Medical record code: {MedicalRecordCode}");
    }
}

class Program
{
    static void Main()
    {
        Patient patient = new Patient("Luiz Costa", 42);
        MedicalHistory history = new MedicalHistory("XPT-9987");
        history.DisplayCode();
    }
}