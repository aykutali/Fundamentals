namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var materials = new Dictionary<string, long>();

            string command = "";
            while ((command=Console.ReadLine())!="stop")
            {
                string currMaterial=command;
                long currQuantity=long.Parse(Console.ReadLine());

                if (!materials.ContainsKey(currMaterial))
                {
                    materials[currMaterial] = currQuantity;
                }
                else
                {
                    materials[currMaterial] += currQuantity;
                }
            }

            foreach (var kvp in materials)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}