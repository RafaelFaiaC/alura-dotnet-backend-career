/*Salary Increase

You work developing a human resources system for a company. One of the features of this system is to calculate the salary increase of employees based on a percentage defined by the company. Your challenge is to create a program that facilitates this calculation.

Create a program that:
- Defines a variable for the current salary (decimal).
- Defines a variable for the increase percentage (decimal).
- Calculates the new salary and saves it in a new variable (decimal).
- Finally, displays the new salary.

The formula for the calculation is:
currentSalary + (currentSalary * increasePercentage / 100)

Expected Output:
You can use the .ToString("F2") method to format the value output in the console, for example: newSalary.ToString("F2").
If the current salary is 1500.00 and the increase percentage is 10%, the program should display:
The new salary is R$1650.00
*/

decimal currentSalary = 1500.00m;
decimal increasePercentage = 10.0m;
decimal newSalary = currentSalary + (currentSalary * increasePercentage / 100);

Console.WriteLine($"The new salary is R${newSalary:F2}");