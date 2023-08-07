namespace _02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split().Select(int.Parse).ToList();

            string input = "";
            while ((input=Console.ReadLine()) != "Finish")
            {
                string[] command=input.Split(' ');

                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;

                    case "Remove":
                        numbers.Remove(int.Parse(command[1]));
                        break;

                    case "Replace":
                        int valueIndex = numbers.IndexOf(int.Parse(command[1]));
                        numbers.RemoveAt(valueIndex);
                        numbers.Insert(valueIndex, int.Parse(command[2]));
                        break;

                    case "Collapse":
                        int value = int.Parse(command[1]);

                        for (int i = numbers.Count-1; i>=0; i--)
                        {
                            if (numbers[i] < value)
                            {
                                numbers.Remove(numbers[i]);
                            }
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}