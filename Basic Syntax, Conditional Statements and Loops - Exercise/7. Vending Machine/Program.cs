namespace _7._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = 0;
            string command = Console.ReadLine();
            while (command!="Start")
            {
                
                double currCoin = double.Parse(command);
                if (currCoin == 0.1 || currCoin == 0.2 || currCoin == 0.5 || 
                    currCoin == 1 || currCoin == 2)
                {
                    money += currCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currCoin}");
                }
                command = Console.ReadLine();
            }
            
            command= Console.ReadLine();

            while (command != "End")
            {
                switch (command)
                {
                    case "Nuts":
                        if (money >= 2)
                        {
                            money -= 2;
                            Console.WriteLine($"Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (money >= 0.7)
                        {
                            money -= 0.7;
                            Console.WriteLine($"Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (money >= 1.5)
                        {
                            money -= 1.5;
                            Console.WriteLine($"Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (money >= 0.8)
                        {
                            money -= 0.8;
                            Console.WriteLine($"Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (money >= 1)
                        {
                            money -= 1;
                            Console.WriteLine($"Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Change: {money:F2}");
        }
    }
}