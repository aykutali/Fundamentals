namespace _03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> items = Console.ReadLine()
                .Split(", ").Select(int.Parse).ToList();

            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();

            int leftSide = 0;
            int rightSide = 0;

            for (int i = 0; i < items.Count; i++)
            {
                if (typeOfItems == "cheap")
                {
                    if (entryPoint - i - 1 >= 0)
                    {
                        if (items[entryPoint - i - 1] < items[entryPoint])
                        {
                            leftSide += items[entryPoint - i - 1];
                        }
                    }

                    if (entryPoint + i + 1 < items.Count)
                    {
                        if (items[entryPoint + i + 1] < items[entryPoint])
                        {
                            rightSide += items[entryPoint + i + 1];
                        }
                    }
                }

                if (typeOfItems == "expensive")
                {
                    if (entryPoint - i - 1 >= 0)
                    {
                        if (items[entryPoint - i - 1] >= items[entryPoint])
                        {
                            leftSide += items[entryPoint - i - 1];
                        }
                    }

                    if (entryPoint + i + 1 < items.Count)
                    {
                        if (items[entryPoint + i + 1] >= items[entryPoint])
                        {
                            rightSide += items[entryPoint + i + 1];
                        }
                    }
                }
            }

            if (rightSide>leftSide)
            {
                Console.WriteLine($"Right - {rightSide}");
            }
            else
            {
                Console.WriteLine($"Left - {leftSide}");
            }
        }
    }
}