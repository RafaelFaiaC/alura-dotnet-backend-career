using ByteBank_IO;

partial class Program
{
    static void UsingStreamReader()
    {
        string fileLocation = "contas.txt";

        using (FileStream fileStream = new FileStream(fileLocation, FileMode.Open))
        {
            StreamReader streamReader = new StreamReader(fileStream);

            //Console.WriteLine(streamReader.ReadLine()); Read a single line
            //Console.WriteLine(streamReader.ReadToEnd()); Read the entire file
            //Console.WriteLine(streamReader.Read()); Read the NEXT SINGLE CHARACTER and returns its int ID

            while (!streamReader.EndOfStream) // Returns true when the end of the stream is reached.
            {
                string line = streamReader.ReadLine()!;
                Console.WriteLine(line);
                CheckingAccount account = ConvertStringToCheckingAccount(line);
                Console.WriteLine($"Number: {account.Number}");
                Console.WriteLine($"Branch: {account.Branch}");
                Console.WriteLine($"Balance: {account.Balance}");
                Console.WriteLine($"Holder: {account.Holder.Name}");
                Console.WriteLine();
            }
        }

        static CheckingAccount ConvertStringToCheckingAccount(string line)
        {
            //375;4644;2483,13;Jonatan Silva

            var parts = line.Split(';');
            int number = int.Parse(parts[0]);
            int branch = int.Parse(parts[1]);
            decimal balance = decimal.Parse(parts[2]);
            string holderName = parts[3];

            CheckingAccount account = new CheckingAccount(number, branch);
            account.Deposit(balance);
            account.Holder = new Customer { Name = holderName };
            return account;
        }
    }
}