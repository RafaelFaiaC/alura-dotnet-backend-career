/*Rewards System

Imagine you are developing a quest system for a medieval game. Players can redeem secret coupons found in chests or by defeating enemies to obtain exclusive rewards. Each coupon unlocks a different benefit.

Create a program that:
- Receives the entered reward coupon.
- Returns a message according to the coupon.
- Informs that the reward is "Reward unavailable" if the coupon is invalid.

The rewards according to the coupon are:
- DOUBLE: Earn 2x EXP for 1 hour.
- HEAL: Healing potion.
- GOLD: 1000 gold coins.
- SPECIAL: Legendary item.

Your task is to use the switch expression syntax (simplified switch-case) to return the message directly in the variable assignment, making the code more concise and readable.

Example Input:
Enter the reward code (DOUBLE, HEAL, GOLD, SPECIAL): SPECIAL

Expected Output:
Legendary item unlocked!
*/

Console.Write("Enter the reward code (DOUBLE, HEAL, GOLD, SPECIAL): ");
string rewardCode = Console.ReadLine()!.ToUpper();

string message = rewardCode switch
{
    "DOUBLE" => "Earn 2x EXP for 1 hour.",
    "HEAL" => "Healing potion unlocked!",
    "GOLD" => "1000 gold coins added to your inventory.",
    "SPECIAL" => "Legendary item unlocked!",
    _ => "Reward unavailable."
};

Console.WriteLine(message);