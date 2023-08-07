namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int rangeNum = int.Parse(Console.ReadLine());

            if (rangeNum <= 10)
            {
                for (int i = rangeNum; i < 11; i++)
                {
                    Console.WriteLine($"{num} X {i} = {num * i}");
                }
            }
            else
            {
                Console.WriteLine($"{num} X {rangeNum} = {num * rangeNum}");
            }
        }
    }
}