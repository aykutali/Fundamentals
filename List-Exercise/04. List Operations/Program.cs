namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split().Select(int.Parse).ToList();

            while (true)
            {
                List<string> command = Console.ReadLine()
                    .Split().ToList();

                if (command[0] == "End")
                {
                    break;
                }

                int element = 0;
                int index = 0;
                if (command[0] =="Add")
                {
                    element = int.Parse(command[1]);
                    numbers.Add(element);
                }
                else if (command[0]=="Insert")
                {
                    element= int.Parse(command[1]);
                    index = int.Parse(command[2]);
                    if (index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, element);
                    }
                }
                else if (command[0]=="Remove")
                {
                    index= int.Parse(command[1]);
                    if (index>=numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (command[1]=="left")
                {
                    int count = int.Parse(command[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int first = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(first);
                    }
                }
                else if (command[1]=="right")
                {
                    int count = int.Parse(command[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int last= numbers[^1];
                        numbers.RemoveAt(numbers.Count-1);
                        numbers.Insert(0,last);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}