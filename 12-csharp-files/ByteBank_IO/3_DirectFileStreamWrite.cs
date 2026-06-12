using System.Text;

partial class Program
{
    static void DirectFileStreamWrite()
    {
        string fileName = "exportedAccounts.csv";

        using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
        {
            string AccountAsString = "375;4644;2483,13;Jonatan Silva";
            var bytes = Encoding.UTF8.GetBytes(AccountAsString);

            fileStream.Write(bytes, 0, bytes.Length);
        }
    }
}
