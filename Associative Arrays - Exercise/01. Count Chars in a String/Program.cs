namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Dictionary<char, int> text = new Dictionary<char, int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];

                if (currChar==' ')
                {
                    continue;
                }

                if (!text.ContainsKey(currChar))
                {
                    text.Add(currChar, 0);
                }

                text[currChar]++;
            }

            
            foreach (var item in text)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}