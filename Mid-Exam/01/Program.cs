/*
12
6
4430
9.8
5.5
620.3
840.2
960.1
220
340
674
365
345.5
212
412.12
258
496
 */
namespace _01_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            decimal groupEnergy = decimal.Parse(Console.ReadLine());
            decimal waterPerDay = decimal.Parse(Console.ReadLine());
            decimal foodPerDay = decimal.Parse(Console.ReadLine());

            decimal allWater = waterPerDay * players * days;
            decimal allFood = foodPerDay * players * days;

            for (int i = 1; i <= days; i++)
            {
                decimal energyLossForDay = decimal.Parse(Console.ReadLine());

                groupEnergy -= energyLossForDay;

                if (groupEnergy <= 0)
                {
                    break;
                }

                if (i % 2 == 0)
                {
                    allWater -= allWater * (decimal)0.3;
                    groupEnergy += groupEnergy * (decimal)0.05;
                }

                if (i % 3 == 0)
                {
                    allFood -=(allFood/players);
                    groupEnergy += groupEnergy * (decimal)0.1;
                }

            }

            if (groupEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:F2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {allFood:F2} food and {allWater:F2} water.");
            }
        }
    }
}