using System.Text;

partial class Program
{
    static void DirectFileStreamRead()
    {
        string fileLocation = "contas.txt";

        using (FileStream fileStream = new FileStream(fileLocation, FileMode.Open))
        {
            var buffer = new byte[1024]; // 1KB
            int bytesRead;

            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                WriteBuffer(buffer, bytesRead);
            }
        }

        static void WriteBuffer(byte[] buffer, int bytesRead)
        {
            string text = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Console.Write(text);

            //foreach(byte b in buffer)
            //{
            //    Console.Write(b);
            //}
        }
    }
}
