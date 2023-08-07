namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int endChar = 97 + n;

            for (int i = 97; i < endChar; i++)
            {
                for (int j = 97; j < endChar; j++)
                {
                    for (int k = 97; k < endChar; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }

            }
        }
    }
}