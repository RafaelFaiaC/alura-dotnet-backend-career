/*Calculating Age

Imagine you are developing a user registration system. One of the features of this system is to calculate the user's age in order to offer content and services suitable for their age group.
Write a program in C# that, given a person's birth year, calculates their age based on the current year.

Example Input:
int birthYear = 1997;

Expected Output:
Your age is: 29 years old
*/

int birthYear = 1997; // Enter your birth year here
int currentYear = DateTime.Now.Year;
int age = currentYear - birthYear;

Console.WriteLine($"\nYour age is: {age} years old");