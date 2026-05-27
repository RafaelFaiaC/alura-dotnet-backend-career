/*Service Queue Tickets

Imagine you work at a customer service branch, such as a bank or a service store. Your task is to create a ticket system to organize customer service. The system must allow new tickets to be generated when a customer arrives and tickets to be called when an attendant is available. The challenge is to ensure the system works efficiently, keeping track of generated tickets and already served tickets, providing an organized and fair experience for all customers.

Create a program that:
- Displays a menu with the options: Generate new ticket, Call next ticket, and Exit.
- For the "Generate new ticket" option, the system should generate a new sequential ticket (for example, 001, 002, 003, etc.).
- For the "Call next ticket" option, the system should call the next available ticket in the queue, following the arrival order.
- The menu must be displayed repeatedly until the user chooses the Exit option.

Tip: You can use the ToString("D3") method to format the output like 001, 002, 003. For example:
Console.WriteLine("Generated ticket: " + generatedTicket.ToString("D3"));

Example Input / Expected Output:

1 - Generate new ticket
2 - Call next ticket
3 - Exit
Choose an option: 1
Generated ticket: 001
 
1 - Generate new ticket
2 - Call next ticket
3 - Exit
Choose an option: 1
Generated ticket: 002
 
1 - Generate new ticket
2 - Call next ticket
3 - Exit
Choose an option: 2
Called ticket: 001
 
1 - Generate new ticket
2 - Call next ticket
3 - Exit
Choose an option: 2
Called ticket: 002

1 - Generate new ticket
2 - Call next ticket
3 - Exit
Choose an option: 4
Invalid option.
 
1 - Generate new ticket
2 - Call next ticket
3 - Exit
Choose an option: 3
Shutting down system.
*/

int generatedTicket = 0;
int calledTicket = 0;
int option;

do
{
    Console.WriteLine("1 - Generate new ticket");
    Console.WriteLine("2 - Call next ticket");
    Console.WriteLine("3 - Exit");
    Console.Write("Choose an option: ");
    option = int.Parse(Console.ReadLine()!);

    switch (option)
    {
        case 1:
            generatedTicket++;
            Console.WriteLine($"Generated ticket: {generatedTicket:D3}");
            break;
        case 2:
            calledTicket++;
            Console.WriteLine($"Called ticket: {calledTicket:D3}");
            break;
        case 3:
            Console.WriteLine("Shutting down system.");
            break;
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
} while (option != 3);
