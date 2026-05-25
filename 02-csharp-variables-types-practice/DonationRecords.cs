/*Donation Records

You have been hired by a charitable organization that receives donations from individuals and corporations to help underprivileged communities. Some of these donations are anonymous, and others are registered with the donor's information. In addition, donations are deposited into two types of accounts: checking or savings. Recently, an anonymous donation of R$500 was made to the company's savings account.

Create a program that:
- Declares a variable to store the donation amount received.
- Declares a variable to indicate whether the donation was anonymous (true for anonymous, false for non-anonymous).
- Declares a variable to indicate the type of account where the amount was deposited: Use P for savings account, Use C for checking account.

Expected Output:
Received amount: R$500
Anonymous donation: True
Account type: P
*/

decimal donationAmount = 500m;
bool isAnonymous = true;
char accountType = 'P';

Console.WriteLine($"Received amount: R${donationAmount}");
Console.WriteLine($"Anonymous donation: {isAnonymous}");
Console.WriteLine($"Account type: {accountType}");