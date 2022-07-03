using Essentials2.Generics;
using System.Text.Json;

namespace Essentials2.Exceptions
{
    public class ExceptionDemo
    {
        public void BasicExceptions()
        {
            string wrongPath = "data.json";

            // string rightPath = "C:\\Users\\ErangaGayashanBISTEC\\csharp-workspace\\csharp-dev-path-linkedin\\LinkedIn.Essentials2\\LinkedIn.Essentials2\\Data.json";

            // Project is running at -> C:\Users\ErangaGayashanBISTEC\csharp-workspace\csharp-dev-path-linkedin\LinkedIn.Essentials2\LinkedIn.Essentials2\bin\Debug\net6.0\LinkedIn.Essentials2.exe

            // string rightPath = "..\\..\\..\\Data.json"; - Working
            string rightPath = "../../../Data.json";

            string filePath = rightPath;

            System.IO.Stream fileStream = null;

            Console.WriteLine($"Current Directory -> {Directory.GetCurrentDirectory()}");
            try
            {
                fileStream = File.OpenRead(filePath);

                var data = JsonSerializer.Deserialize<Worker>(fileStream);

                Console.WriteLine($"Worker read from file: {data.Id}, {data.FirstName} {data.LastName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Standard exception caught: {ex.Message}");
            }
            finally
            {
                if(fileStream != null)
                {
                    fileStream.Dispose();
                }
            }
        }
    }
}