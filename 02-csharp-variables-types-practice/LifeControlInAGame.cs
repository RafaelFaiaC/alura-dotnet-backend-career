/*Life Control in a Game

You are developing a life control system for a game. In this game, the player starts with an initial number of lives and loses one life with each mistake. On the other hand, when getting an answer right, they gain a life.

Your challenge is to create a program that simulates this mechanic using increment and decrement operators. To do this, the program must:
- Declare a variable with the initial number of lives.
- Simulate a situation where the player makes a mistake.
- Simulate the player getting an answer right twice.
- Store the final life count in a new variable.

Expected Output:
If the player starts with 5 lives, the program should display:
Final lives: 6
*/

int initialLives = 5;

--initialLives; // Player makes a mistake, loses one life
++initialLives; // Player gets an answer right, gains one life
++initialLives; // Player gets an answer right, gains one life

int finalLives = initialLives; // Store the final life count in a new variable

Console.WriteLine($"Final lives: {finalLives}");