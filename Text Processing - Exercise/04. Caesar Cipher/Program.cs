namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string encryptedVersion = "";

            foreach (var symbol in input)
            {
                encryptedVersion += (char)((int)symbol + 3);
            }

            Console.WriteLine(encryptedVersion);
        }
    }
}