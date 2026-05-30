/*Medical Appointment Scheduling

You are creating a system for scheduling appointments in a clinic. Every appointment involves the patient's name, the doctor's name, and the scheduled date. It is common for appointments to be rescheduled — and your system must allow this.

You must create a class that represents an appointment with the essential data and a method to reschedule it, keeping track of the updated date.

Create a class called "Appointment" with:
- A public property "PatientName".
- A public property "DoctorName".
- A public property "AppointmentDate" (of type DateTime).
- A method "Reschedule(DateTime newDate)" to update the date.
- A method "DisplaySummary()" that shows the appointment information, using "Date:" in the first display and "New date:" if it has been rescheduled.

Example Input:
Appointment appointment = new Appointment("João Lima", "Dra. Renata", new DateTime(2025, 5, 20));
appointment.DisplaySummary();
appointment.Reschedule(new DateTime(2025, 5, 25));
appointment.DisplaySummary();

Expected Output:
Appointment scheduled with Dra. Renata for patient João Lima.
Date: 20/05/2025
Appointment scheduled with Dra. Renata for patient João Lima.
New date: 25/05/2025
*/

class Appointment
{
    public string PatientName { get; }
    public string DoctorName { get; }
    public DateTime AppointmentDate { get; private set; }
    private bool isRescheduled = false;
    public Appointment(string patientName, string doctorName, DateTime appointmentDate)
    {
        PatientName = patientName;
        DoctorName = doctorName;
        AppointmentDate = appointmentDate;
    }
    public void Reschedule(DateTime newDate)
    {
        AppointmentDate = newDate;
        isRescheduled = true;
    }
    public void DisplaySummary()
    {
        Console.WriteLine($"Appointment scheduled with {DoctorName} for patient {PatientName}.");
        if (isRescheduled)
        {
            Console.WriteLine($"New date: {AppointmentDate:dd/MM/yyyy}");
        }
        else
        {
            Console.WriteLine($"Date: {AppointmentDate:dd/MM/yyyy}");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Appointment appointment = new Appointment("João Lima", "Dra. Renata", new DateTime(2025, 5, 20));
        appointment.DisplaySummary();
        appointment.Reschedule(new DateTime(2025, 5, 25));
        appointment.DisplaySummary();
    }
}