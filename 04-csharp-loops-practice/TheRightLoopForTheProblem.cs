/*The Right Loop for the Problem

Imagine you are responsible for the system monitoring students' grades at a school. Each student has their grade monitored, and it is important to check if any student has a grade below the passing average. If a student's grade is below average, you need to generate an alert. The passing average is 7.0, meaning any student with a grade below that must trigger a warning.

Your challenge is to choose the most suitable repetition loop to traverse the list of students and check if their grades are within the passing range.

Example Input:
List<double> grades = new List<double> { 8.5, 6.2, 9.1, 5.8, 7.4 };

Expected Output:
The student with grade 8.5 is doing very well!
The student with grade 6.2 is below average!
The student with grade 9.1 is doing very well!
The student with grade 5.8 is below average!
The student with grade 7.4 is doing very well!
*/

List<double> grades = new List<double> { 8.5, 6.2, 9.1, 5.8, 7.4 };

foreach (double grade in grades)
{
    if (grade < 7.0)
    {
        Console.WriteLine($"The student with grade {grade} is below average!");
    }
    else
    {
        Console.WriteLine($"The student with grade {grade} is doing very well!");
    }
}