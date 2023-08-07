namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            while (num%2==1)
            {
                num=int.Parse(Console.ReadLine());
                if (num%2==0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                    num = 1;
                }
                
            }
        }
    }
}