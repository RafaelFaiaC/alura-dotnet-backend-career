/*Representing Rectangles and Calculating Area

You are developing a geometric calculation tool to assist students in a mathematics course. One of the features is to represent a rectangle, allowing its area to be calculated according to the provided height and width.

Create a class called "Rectangle" that has:
- Two public properties: "Height" and "Width".
- A method called "CalculateArea()" that returns the area of the rectangle (height × width).

Then, create an object of the class, assign the values, and show the area result on the screen.

Example Input:
Rectangle rectangle = new Rectangle();
rectangle.Height = 5;
rectangle.Width = 8; 

Expected Output:
Rectangle Area: 40
*/

class Rectangle
{
    public double Height { get; set; }
    public double Width { get; set; }
    public double CalculateArea()
    {
        return Height * Width;
    }
}

class Program
{
    static void Main()
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Height = 5;
        rectangle.Width = 8;
        double area = rectangle.CalculateArea();
        Console.WriteLine($"Rectangle Area: {area}");
    }
}