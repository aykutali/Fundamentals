namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> arguments = Console.ReadLine()
                .Split().ToList();

            string firstArgument = arguments[0];
            string secondArgument = arguments[1];

            string longerString = firstArgument;
            string shorterString = secondArgument;

            if (secondArgument.Length > firstArgument.Length)
            {
                longerString = secondArgument;
                shorterString = firstArgument;
            }

            int sum = 0;

            for (int i = 0; i < shorterString.Length; i++)
            {
                sum += (int)shorterString[i] * (int)longerString[i];
            }

            for (int i = shorterString.Length; i < longerString.Length; i++)
            {
                sum += (int)longerString[i];
            }

            Console.WriteLine(sum);
        }
    }
}