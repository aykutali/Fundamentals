namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;


            switch (typeOfGroup)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        price = 8.45 * countPeople;
                    }
                    else if (day == "Saturday")
                    {
                        price = 9.8 * countPeople;
                    }
                    else if (day == "Sunday")
                    {
                        price = 10.46 * countPeople;
                    }

                    if (countPeople >= 30)
                    {
                        price -= price * 0.15;
                    }
                    break;
                case "Business":
                    if (countPeople >= 100)
                    {
                        countPeople -= 10;
                    }

                    if (day == "Friday")
                    {
                        price = 10.9 * countPeople;
                    }
                    else if (day == "Saturday")
                    {
                        price = 15.6 * countPeople;
                    }
                    else if (day == "Sunday")
                    {
                        price = 16 * countPeople;
                    }

                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        price = 15 * countPeople;
                    }
                    else if (day == "Saturday")
                    {
                        price = 20 * countPeople;
                    }
                    else if (day == "Sunday")
                    {
                        price = 22.5 * countPeople;
                    }

                    if (countPeople >= 10 && countPeople <= 20)
                    {
                        price -= price * 0.05;
                    }
                    break;
            }

            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}