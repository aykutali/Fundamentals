namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();

            VowelsCount(input);
        }

        static void VowelsCount(string input)
        {
            int vowelCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i]=='A')
                {
                    vowelCount++;
                }
                if (input[i] == 'e' || input[i] == 'E')
                {
                    vowelCount++;
                }
                if (input[i] == 'o' || input[i] == 'O')
                {
                    vowelCount++;
                }
                if (input[i] == 'u' || input[i] == 'U')
                {
                    vowelCount++;
                }
                if (input[i] == 'i' || input[i] == 'I')
                {
                    vowelCount++;
                }
            }

            Console.WriteLine(vowelCount);
        }
    }
}