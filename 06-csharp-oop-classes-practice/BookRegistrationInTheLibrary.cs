/*Book Registration in the Library

Imagine you are developing an application for a library that needs to register books. Each book must have a title and an author.

Create a class called "Book" that has two public properties: "Title" and "Author". Then, create an object of this class, fill in the data with a title and author of your choice, and display the output.

Example Input:
myBook.Title = "Dom Casmurro";  
myBook.Author = "Machado de Assis";  

Expected Output:
Book: Dom Casmurro
Author: Machado de Assis
*/

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}

class Program
{
    static void Main()
    {
        Book mybook = new Book();
        mybook.Title = "Dom Casmurro";
        mybook.Author = "Machado de Assis";

        Console.WriteLine($"Book: {mybook.Title}");
        Console.WriteLine($"Author: {mybook.Author}");
    }
}
