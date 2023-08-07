namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split().Select(int.Parse).ToList();

            List<int> command= Console.ReadLine()
                .Split().Select(int.Parse).ToList();

            int bombNum = command[0];
            int power = command[1];

            while (numbers.Contains(bombNum))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i]==bombNum)
                    {
                        for (int j = 0; j < power; j++)
                        {
                            if (i-1>=0)
                            {
                                numbers.RemoveAt(i - 1);
                                i--;
                            }

                            if (i+1<numbers.Count)
                            {
                                numbers.RemoveAt(i + 1);
                            }
                        }

                        numbers.Remove(bombNum);
                    }
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}