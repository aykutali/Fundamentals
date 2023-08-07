namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> userNames = Console.ReadLine()
                .Split(", ")
                .ToList();

            foreach (var userName in userNames)
            {
                if (isBetween(userName) && isContains(userName))
                {
                    Console.WriteLine(userName);
                }
            }
        }

        static bool isBetween(string userName)
        {
            if (userName.Length is >= 3 and <= 16)
            {
                return true;
            }

            return false;
        }

        static bool isContains(string userName)
        {
            userName = userName.ToLower();

            foreach (var symbol in userName)
            {
                if (((int)symbol >= 48 && (int)symbol <= 57) ||
                    ((int)symbol >= 97 && (int)symbol <= 122) ||
                    (int)symbol == 95 ||
                    (int)symbol == 45)
                {

                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
