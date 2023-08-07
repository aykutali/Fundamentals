namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> location=Console.ReadLine()
                .Split('\\').ToList();

            List<string> file = location[^1].Split('.').ToList();

            string fileName = file[0];
            string extension = file[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}