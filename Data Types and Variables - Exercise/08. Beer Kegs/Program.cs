namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string bestKeg = "";
            double bestKegVolume = 0;


            for (int i = 0; i < n; i++)
            {
                string currKeg = Console.ReadLine();
                double radiusKeg = double.Parse(Console.ReadLine());
                uint heigtKeg = uint.Parse(Console.ReadLine());

                double currKegVolume = Math.PI * (Math.Pow(radiusKeg, 2) * heigtKeg);

                if (currKegVolume > bestKegVolume)
                {
                    bestKeg=currKeg;
                    bestKegVolume = currKegVolume;
                }
            }

            Console.WriteLine(bestKeg);
        }
    }
}