/*Number Classification

You are developing an answer validation system for an online quiz. The system receives a list of participant scores (from 0 to 10) and needs to classify them as "Failed" (if the score is less than 6) or "Passed" (if the score is greater than or equal to 6).

To do this, you will need a program that:
- Stores the participants' scores in a list.
- Traverses each score using a loop.
- Uses a conditional structure to classify and display the status of each participant.

Example Input:
List<int> scores = new List<int> { 4, 7, 5, 9, 6 };

Expected Output:
Score 4 - Failed
Score 7 - Passed
Score 5 - Failed
Score 9 - Passed
Score 6 - Passed
*/

List<int> scores = new List<int> { 4, 7, 5, 9, 6 };

foreach (int score in scores)
{
    if (score < 6)
    {
        Console.WriteLine($"Score {score} - Failed");
    }
    else
    {
        Console.WriteLine($"Score {score} - Passed");
    }
}