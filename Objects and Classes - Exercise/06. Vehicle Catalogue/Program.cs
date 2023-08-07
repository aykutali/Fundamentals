namespace _06._Vehicle_Catalogue
{
    internal class Program
    {

        static void Main()
        {
            List<Vehicle> allVehicles = new List<Vehicle>();

            string command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command
                    .Split()
                    .ToArray();

                Vehicle currVehicle = new Vehicle
                    (input[0], input[1], input[2]
                        , (int.Parse(input[3])));

                allVehicles.Add(currVehicle);
            }

            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (var vehicle in allVehicles)
                {

                    if (vehicle.Model==command)
                    {
                        Console.WriteLine($"Type: {vehicle.Type}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                        break;
                    }
                }
            }

            List<Vehicle> cars = new List<Vehicle>();
            List<Vehicle> trucks = new List<Vehicle>();

            foreach (Vehicle vehicle in allVehicles)
            {
                if (vehicle.Type == "Car")
                {
                    cars.Add(vehicle);
                }
                else
                {
                    trucks.Add(vehicle);
                }
            }
            int carsCount=cars.Count;
            int trucksCount=trucks.Count;
            if (carsCount<=0)
            {
                carsCount = 1;
            }

            if (trucksCount<=0)
            {
                trucksCount = 1;
            }

            double averageHPcars = cars.Sum(x => x.HorsePower) / (double)carsCount;
            double averageHPtrucks = trucks.Sum(x => x.HorsePower) / (double)trucksCount;

            Console.WriteLine($"Cars have average horsepower of: {averageHPcars:F2}.\nTrucks have average horsepower of: {averageHPtrucks:F2}.");
        }
    }

    public class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            string result = char.ToUpper(type[0]) + type.Substring(1);
            Type = result;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }
    }
}