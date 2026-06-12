partial class Program
{
    static void UsingBinaryReader()
    {
        string fileName = "checkingAccounts.txt";
        using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
        using (BinaryReader binaryReader = new BinaryReader(fileStream))
        {
            int number = binaryReader.ReadInt32();
            int branch = binaryReader.ReadInt32();
            decimal balance = binaryReader.ReadDecimal();
            string holderName = binaryReader.ReadString();
            Console.WriteLine($"Number: {number}");
            Console.WriteLine($"Branch: {branch}");
            Console.WriteLine($"Balance: {balance}");
            Console.WriteLine($"Holder: {holderName}");
        }
    }
}