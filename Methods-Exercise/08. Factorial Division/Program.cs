namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long num1 = long.Parse(Console.ReadLine());
            long num2 = long.Parse(Console.ReadLine());

            
            Console.WriteLine($"{(Factorial(num1) / Factorial(num2)):f2}");
        }

        static double Factorial(long num)
        {
            long sum = num;
            for (long i = num - 1; i > 0; i--)
            {
                sum *= i;
            }


            return sum;
        }
    }
}