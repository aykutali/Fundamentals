namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split().Select(int.Parse).ToList();

            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command[0] == "end")
                {
                    break;
                }
                else if (command[0] == "Delete")
                {
                    int element = int.Parse(command[1]);

                    int i = 0;
                    while (true)
                    {
                        if (i>=numbers.Count)
                        {
                            break;
                        }
                        if (numbers[i]==element)
                        {
                            numbers.RemoveAt(i);
                            continue;
                        }
                        i++;
                    }
                }
                else if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    numbers.Insert(index,element);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}