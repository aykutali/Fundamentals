using System.Data;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> parkPlace = new Dictionary<string,string>();

            int commandCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandCount; i++)
            {
                List<string> command=Console.ReadLine()
                    .Split()
                    .ToList();

                string userName = command[1];
                switch (command[0])
                {
                    case "register":
                        string plateNumber= command[2];

                        if (!parkPlace.ContainsKey(userName))
                        {
                            parkPlace.Add(userName,plateNumber);
                            Console.WriteLine($"{userName} registered {plateNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {parkPlace[userName]}");
                        }
                        break;
                    case "unregister":
                        if (!parkPlace.ContainsKey(userName))
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                        }
                        else
                        {
                            parkPlace.Remove(userName);
                            Console.WriteLine($"{userName} unregistered successfully");
                        }
                        break;
                }
            }

            foreach (var park in parkPlace)
            {
                Console.WriteLine($"{park.Key} => {park.Value}");
            }
        }
    }
}