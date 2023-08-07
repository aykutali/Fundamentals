namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> shopList = new Dictionary<string, Product>();

            string command = "";
            while ((command = Console.ReadLine()) != "buy")
            {
                List<string> item = command
                    .Split()
                    .ToList();
                string name = item[0];
                decimal price = decimal.Parse(item[1]);
                decimal quantity = decimal.Parse(item[2]);

                Product currProduct = new Product(name, price, quantity);

                if (!shopList.ContainsKey(name))
                {
                    shopList.Add(name,currProduct);
                }
                else
                {
                    shopList[name].Replace(quantity,price);
                }

            }

            foreach (var item in shopList)
            {
                Console.WriteLine(item.Value);
            }
        }
    }

    public class Product
    {
        public Product(string name, decimal price, decimal quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public void Replace(decimal quantity, decimal price)
        {
            Quantity += quantity;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} -> {Quantity * Price:F2}";
        }
    }
}