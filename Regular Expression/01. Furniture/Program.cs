using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>[0-9]+|[0-9]+.[0-9]+)!(?<quantity>[0-9]+)";
            Regex regex = new Regex(pattern);

            List<Furniture> furnitures = new List<Furniture>();
            decimal totalMoney = 0;

            string input = "";
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    Furniture currFurniture = new Furniture(name, quantity, price);

                    furnitures.Add(currFurniture);
                    totalMoney += currFurniture.TotalPrice();
                }
            }

            Console.WriteLine("Bought furniture:");
            foreach (var f in furnitures)
            {
                Console.WriteLine(f.Name);
            }
            Console.WriteLine($"Total money spend: {totalMoney:F2}");
        }
    }

    public class Furniture
    {
        public Furniture(string name, int quantity, decimal price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal TotalPrice()
        {
            return (decimal)Quantity * Price;
        }
    }
}