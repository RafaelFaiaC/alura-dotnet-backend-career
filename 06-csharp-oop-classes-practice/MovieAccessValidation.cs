/*Movie Access Validation

Imagine you are creating a recommendation system for a movie platform. Each movie has a title and an age rating. To ensure that people only see content appropriate for their age, the system must check if the person can watch the movie based on the provided age.

Create a class called "Movie" that has:
- Public properties "Title" and "AgeRating" (int).
- A method called "CanWatch(int userAge)" that returns true if the age is greater than or equal to the age rating, and false otherwise.
- A method "DisplayResult(int userAge)" that displays a friendly message informing whether the user can or cannot watch the movie.

Example Input:
Movie movie = new Movie("Matrix", 16);
movie.DisplayResult(14);
movie.DisplayResult(20);

Expected Output:
User who is 14 years old cannot watch the movie Matrix.
User who is 20 years old can watch the movie Matrix.
*/

class Movie
{
    public string Title { get; set; }
    public int AgeRating { get; set; }
    public bool CanWatch(int userAge)
    {
        return userAge >= AgeRating;
    }
    public void DisplayResult(int userAge)
    {
        if (CanWatch(userAge))
        {
            Console.WriteLine($"User who is {userAge} years old can watch the movie {Title}.");
        }
        else
        {
            Console.WriteLine($"User who is {userAge} years old cannot watch the movie {Title}.");
        }
    }
}

class Program
{
    static void Main()
    {
        Movie movie = new Movie { Title = "Matrix", AgeRating = 16 };
        movie.DisplayResult(14);
        movie.DisplayResult(20);
    }
}