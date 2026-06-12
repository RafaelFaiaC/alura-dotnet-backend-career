partial class Program
{
    static void UsingBinaryWriter()
    {
        string fileName = "checkingAccounts.txt";
        using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
        using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
        {
            binaryWriter.Write(375); // Account number
            binaryWriter.Write(4644); // Branch number
            binaryWriter.Write(2483.13m); // Balance
            binaryWriter.Write("Jonatan Silva"); // Account holder's name
        }
    }
}