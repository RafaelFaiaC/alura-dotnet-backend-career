using ByteBank_IO;

partial class Program
{
    static void UsingStreamWriter()
    {
        string fileName = "exportedAccounts.csv";

        using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
        using (StreamWriter streamWriter = new StreamWriter(fileStream))
        {
            streamWriter.Write("375;4644;2483,13;Jonatan Silva");
            streamWriter.Flush(); // Force the buffer to be written to the file
            Console.WriteLine("Written!"); // This will be printed before the file is actually written, because StreamWriter uses a buffer to optimize writing operations. The Flush() method is called to ensure that all buffered data is sent to the file immediately.
            Console.ReadLine();
        }
    }
}