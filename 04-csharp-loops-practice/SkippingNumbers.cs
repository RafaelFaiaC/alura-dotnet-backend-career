/*Skipping Numbers

You are developing a selection system for a technology event where participants are identified by numbers from 1 to 20. However, multiples of 3 are reserved for a special stage of the event, where participants will be directed to exclusive activities. To avoid confusion, these numbers should not be displayed in the initial participant list.

Your task is to create a program that displays all numbers from 1 to 20, but skips multiples of 3.

Expected Output:
1
2
4
5
7
8
10
11
13
14
16
17
19
20
*/

for (int i = 1; i <= 20; i++)
{
    if (i % 3 == 0)
    {
        continue;
    }
    Console.WriteLine(i);
}