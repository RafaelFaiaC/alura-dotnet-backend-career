/*Distance Conversion

You work for a tourism company that organizes international trips and tours. Many of the destinations offered by the company use the imperial system of measurement, where distances are provided in miles. However, Brazilian customers are more familiar with the metric system, which uses kilometers.

To facilitate communication with customers, your mission is to create a distance conversion system that converts miles to kilometers, using the formula:
1 mile = 1.60934 kilometers.

Create a program that:
- Declares a variable that receives the value in miles.
- Calculates the distance in kilometers and stores the result in a new variable.
- Displays the result in the console.

Expected Output:
10 miles are equivalent to 16.0934 kilometers.
*/

double miles = 10;
double kilometers = miles * 1.60934;

Console.WriteLine($"{miles} miles are equivalent to {kilometers} kilometers");