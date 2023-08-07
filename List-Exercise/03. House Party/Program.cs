namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfCommands = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < numbersOfCommands; i++)
            {
                List<string> currGuest = Console.ReadLine()
                    .Split().ToList();

                string currName = currGuest[0];

                if (currGuest[2] == "not")
                {
                    if (names.Contains(currName))
                    {
                        names.Remove(currName);
                    }
                    else
                    {
                        Console.WriteLine($"{currName} is not in the list!");
                    }
                }
                else if (currGuest[2] == "going!")
                {
                    if (names.Contains(currName))
                    {
                        Console.WriteLine($"{currName} is already in the list!");
                    }
                    else
                    {
                        names.Add(currName);
                    }
                }
            }

            Console.WriteLine(string.Join("\n", names));
        }
    }
}