namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int water = 0;
            for (int i = 0; i < n; i++)
            {
                int currWater = int.Parse(Console.ReadLine());
                if (currWater + water <= 255)
                {
                    water += currWater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(water);
        }
    }
}