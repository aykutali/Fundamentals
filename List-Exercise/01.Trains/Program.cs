namespace _01.Trains
/*
32 54 21 12 4 0 23
75
Add 10
Add 0
30
10
75
end
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split().Select(int.Parse).ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            List<string> command = Console.ReadLine()
                .Split().ToList();

            while (true)
            {
                if (command[0] == "end")
                {
                    break;
                }

                if (command[0] == "Add")
                {
                    int newWagon = int.Parse(command[1]);
                    wagons.Add(newWagon);
                }
                else
                {
                    int newPassengers = int.Parse(command[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + newPassengers <= maxCapacity)
                        {
                            wagons[i] += newPassengers;
                            break;
                        }
                    }
                }

                command = Console.ReadLine()
                   .Split().ToList();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}