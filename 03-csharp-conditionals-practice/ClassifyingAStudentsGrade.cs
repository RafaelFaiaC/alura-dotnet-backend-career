/*Classifying a Student's Grade

You are responsible for developing the evaluation system for a technology school. Your program needs to analyze students' performance in each module and assign a grade classification that reflects their achievement.

Create a system that:
- Receives the student's final grade.
- Classifies the performance according to the table:
  - A (grades ≥ 9)
  - B (grades ≥ 7 and < 9)
  - C (grades ≥ 5 and < 7)
  - D (grades < 5)
- Displays the obtained classification.

Example Input:
Enter the student's final grade: 8.5

Expected Output:
The student received grade B.
*/

Console.Write("Enter the student's final grade: ");
double grade = double.Parse(Console.ReadLine()!);

if (grade >= 9)
{
    Console.WriteLine("The student received grade A.");
}
else if (grade >= 7)
{
    Console.WriteLine("The student received grade B.");
}
else if (grade >= 5)
{
    Console.WriteLine("The student received grade C.");
}
else
{
    Console.WriteLine("The student received grade D.");
}