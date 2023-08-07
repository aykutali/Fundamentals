namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            int sum = 0;
            int curr = 1;

            for (int i = 1; i <=n; i++)
            {
                if (curr % 2 == 1)
                {
                    Console.WriteLine(curr);
                    sum += curr;
                }
                curr += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}