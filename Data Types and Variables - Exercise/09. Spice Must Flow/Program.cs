namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());

            int days = 0;
            long totalAmount = 0;

            while (yield >= 100)
            {
                days++;
                totalAmount += yield;
                totalAmount -= 26;
                yield -= 10;
            }
            totalAmount -= 26;

            if (totalAmount < 0)
            {
                totalAmount = 0;
            }

            Console.WriteLine($"{days}\n{totalAmount}");

        }
    }
}