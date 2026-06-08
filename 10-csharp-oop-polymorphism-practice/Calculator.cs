/*Calculator using Method Overloading

You are developing a calculator for a checkout system. To make it easier to use, the system needs a sum method that works with two integers, three integers, and also with decimal numbers.

Your mission is to create a class called "Calculator" that has a method called "Sum". This method must be overloaded to allow the following versions:
- Sum two integers.
- Sum three integers.
- Sum two decimal numbers (double).

Then, create an instance of the class and call the three methods, displaying the results.

Example Input:
Calculator calc = new Calculator();
Console.WriteLine(calc.Sum(10, 20));
Console.WriteLine(calc.Sum(5, 10, 15));
Console.WriteLine(calc.Sum(3.5, 2.8));

Expected Output:
30
30
6.3
*/

class Calculator
{
    public int Sum(int a, int b)
    {
        return a + b;
    }
    public int Sum(int a, int b, int c)
    {
        return a + b + c;
    }
    public double Sum(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        Console.WriteLine(calc.Sum(10, 20)); // Output: 30
        Console.WriteLine(calc.Sum(5, 10, 15)); // Output: 30
        Console.WriteLine(calc.Sum(3.5, 2.8)); // Output: 6.3
    }
}