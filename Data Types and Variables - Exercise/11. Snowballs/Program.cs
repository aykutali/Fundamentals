using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ballsCount=int.Parse(Console.ReadLine());

            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;
            BigInteger bestValue = 0;

            for (int i = 0; i < ballsCount; i++)
            {
                int currSnow=int.Parse(Console.ReadLine());
                int currTime=int.Parse(Console.ReadLine());
                int currQuality=int.Parse(Console.ReadLine());

                BigInteger currValue = BigInteger.Pow(currSnow / currTime, currQuality);

                if (currValue > bestValue)
                {
                    bestSnow = currSnow;
                    bestTime = currTime;
                    bestQuality = currQuality;
                    bestValue = currValue;
                }
            }
            BigInteger a = 1.2676506E30;
            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }
    }
}