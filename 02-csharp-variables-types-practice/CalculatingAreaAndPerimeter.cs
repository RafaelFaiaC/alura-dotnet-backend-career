/*Calculating Area and Perimeter

You work for an engineering company that develops solutions for geometric calculations used in construction and design projects. One of the company's clients requested a system to calculate the area and perimeter (also known as circumference) of circles, which is essential information for planning circular structures such as tanks, floors, and gardens.

Your mission is to create a program that, given the radius of a circle, calculates its area and perimeter using the appropriate mathematical formulas.

Create a program that:
- Declares a variable to store the value of PI (consider PI to be equal to 3.14159).
- Declares a variable to receive the value of the circle's radius.
- Calculates and stores the area of the circle in a variable using the formula: area = pi * radius * radius.
- Calculates and stores the perimeter of the circle in a variable using the formula: perimeter = 2 * pi * radius.
- Displays the results in the console.

Example Input:
double radius = 5.0;

Expected Output:
You can use the .ToString("F2") method to format the value output in the console, for example: radius.ToString("F2")
Radius: 5.00
Circle area: 78.54
Circle perimeter: 31.42
*/

double pi = 3.14159;
double radius = 5.0;
double area = pi * radius * radius;
double perimeter = 2 * pi * radius;

Console.WriteLine($"Radius: {radius:F2}");
Console.WriteLine($"Circle area: {area:F2}");
Console.WriteLine($"Circle perimeter: {perimeter:F2}");