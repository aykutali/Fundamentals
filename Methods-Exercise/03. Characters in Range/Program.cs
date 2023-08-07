namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c1 = char.Parse(Console.ReadLine());
            char c2 = char.Parse(Console.ReadLine());

            if (c2 < c1)
            {
                (c1, c2) = (c2, c1);
            }

            CharactersBetween(c1,c2);
        }

        static void CharactersBetween(char char1, char char2)
        {
            for (int i = char1 + 1; i < char2; i++)
            {
                Console.Write((char)i+" ");
            }
        }
    }
}