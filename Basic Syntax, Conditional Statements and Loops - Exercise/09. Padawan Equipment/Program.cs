namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double studensCountSabres = double.Parse(Console.ReadLine());
            double priceLightSabres = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            double robes = priceRobes * studensCountSabres;

            double studensCountBelts = studensCountSabres;

            studensCountSabres += Math.Ceiling(studensCountSabres * 0.1);
            studensCountBelts -= Math.Floor(studensCountBelts / 6);

            double price = (studensCountSabres * priceLightSabres) +
                (studensCountBelts * priceBelts) + robes;

            if (money >= price)
            {
                Console.WriteLine($"The money is enough - it would cost {price:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(price - money):F2}lv more.");
            }

        }
    }
}