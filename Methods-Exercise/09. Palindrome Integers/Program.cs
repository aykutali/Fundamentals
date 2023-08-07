namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while ((input = Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsPalindrome(input));
            }
        }

        static string IsPalindrome(string input)
        {
            char[] orgInput = input.ToCharArray();
            char[] reversedInput = input.ToCharArray();

            Array.Reverse(reversedInput);

            for (int i = 0; i < input.Length; i++)
            {
                if (orgInput[i] != reversedInput[i])
                {
                    return "false";
                }
            }
            return "true";
        }
    }
}