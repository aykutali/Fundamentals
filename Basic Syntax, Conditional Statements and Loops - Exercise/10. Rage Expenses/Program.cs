namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double money = 0;
            int keyboardCount = 0;
            for (int i = 1; i <= gamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    money += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    money += mousePrice;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    money += keyboardPrice;
                    keyboardCount++;

                    if (keyboardCount % 2 == 0)
                    {
                        money += displayPrice;
                    }
                }

            }

            Console.WriteLine($"Rage expenses: {money:F2} lv.");
        }
    }
}