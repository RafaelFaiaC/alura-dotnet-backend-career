/*Converting Hours to Minutes

Imagine you are developing a time management system for a productivity application. This system needs to convert the total activity time, recorded in minutes, into a more readable format (hours and minutes), making it easier for the user to visualize.

Create a program that:
- Declares a variable with an integer value representing the total minutes.
- Calculates how many full hours are in that value and how many minutes remain.
- Displays the result in the format: X hours and Y minutes.

Example Input:
int minutes = 250;

Expected Output:
Time: 4 hours and 10 minutes
*/

int minutes = 250;
int hours = minutes / 60;
int remainingMinutes = minutes % 60;

Console.WriteLine($"Time: {hours} hours and {remainingMinutes} minutes");