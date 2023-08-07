namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = SumOfFirstTwoNums(num1,num2);

            int result = SubstractsFromSum(sum,num3);

            Console.WriteLine(result);
        }

        static int SumOfFirstTwoNums(int n1, int n2)
        {
            return n1 + n2;
        }

        private static int SubstractsFromSum(int sum, int n3)
        {
            return sum - n3;
        }
    }
}