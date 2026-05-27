/*Multiplication Table

Imagine you are creating a program to show the multiplication table of a specific number. In this exercise, the chosen number will be 7, and the idea is to generate the multiplication table of 7, from 1 to 10, using a repetition loop. What you must do is write a program that uses a loop to print the multiplication table of the number 7. The program must display the result of each multiplication, as shown in the example below.

Expected Output:
7 x 1 = 7
7 x 2 = 14
7 x 3 = 21
7 x 4 = 28
7 x 5 = 35
7 x 6 = 42
7 x 7 = 49
7 x 8 = 56
7 x 9 = 63
7 x 10 = 70
*/

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"7 x {i} = {7 * i}");
}