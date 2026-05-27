/*Secret Number

Imagine you are developing a game where the player must try to guess what the secret number is. The challenge is to create a program that keeps prompting for attempts until the player guesses the number correctly, providing feedback with each attempt.

Create a program that:
- Declares a variable with an integer to be the secret number.
- Checks at each interaction if the entered number matches the secret number.
- If the player guesses wrong, the program informs them that the attempt is incorrect and requests a new attempt.
- If the player guesses the number correctly, the program displays a congratulations message and ends the game.

Example Input:
Try to guess the number between 1 and 10: 7

Expected Output:
Congratulations, you got it right!
*/

Random random = new Random();
int secretNumber = random.Next(1, 11);
int playerGuess;

while (true)
{
    Console.Write("Try to guess the number between 1 and 10: ");
    playerGuess = int.Parse(Console.ReadLine()!);

    if (playerGuess == secretNumber)
    {
        Console.WriteLine("Congratulations, you got it right!");
        break;
    }

    Console.WriteLine("Wrong! Try again.\n");
}