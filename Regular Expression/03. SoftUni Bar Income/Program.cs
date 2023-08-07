using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%(?:[^\|\$\%\.]*)?<(?<product>[a-zA-Z0-9_]+)>(?:[^\|\$\%\.]*)?\|(?<quantity>[0-9]+)\|(?:[^\|\$\%\.0-9]*)?((?<price>[0-9]+|[0-9]+.[0-9]+)\$)";
            Regex r = new Regex(pattern);

            decimal total = 0;

            string input = "";
            while ((input = Console.ReadLine()) != "end of shift")
            {
                MatchCollection matches = r.Matches(input);

                foreach (Match match in matches)
                {
                    string customer = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);

                    decimal currTotal = (decimal)quantity * price;

                    Console.WriteLine($"{customer}: {product} - {currTotal:F2}");

                    total += currTotal;
                }
            }

            Console.WriteLine($"Total income: {total:F2}");
        }
    }
}