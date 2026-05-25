/*Grade Average

Imagine you are developing a report card system for a school that wants to modernize how it tracks student performance. The goal is to create a program capable of calculating the average of grades, making the job easier and providing immediate results.

For this activity, you must create a program that:
- Declares three variables of type float to store the student's grades. The school provided the following values: 7.2, 8.3, and 9.1.
- Calculates the arithmetic average of the three grades.
- Displays the calculated average.

Expected Output:
The average of the grades is: 8.2
*/

double grade1 = 7.2;
double grade2 = 8.3;
double grade3 = 9.1;

double calculatedAverage = (grade1 + grade2 + grade3) / 3;

Console.WriteLine($"The average of the grades is: {calculatedAverage:f1}");