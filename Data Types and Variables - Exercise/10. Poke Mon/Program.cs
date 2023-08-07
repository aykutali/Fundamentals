namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceBetweenPokes = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int originalPokePower = pokePower;
            int reachedPokes = 0;
            while (pokePower >= distanceBetweenPokes)
            {
                reachedPokes++;
                pokePower -= distanceBetweenPokes;

                if (pokePower == originalPokePower / 2d && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine($"{pokePower}\n{reachedPokes}");
        }
    }
}