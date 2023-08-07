namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();

            string filteredInput = "";
            filteredInput += input[0];

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != filteredInput[^1])
                {
                    filteredInput += input[i];
                }
            }

            Console.WriteLine(filteredInput);
        }
    }
}