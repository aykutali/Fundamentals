namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonCount = int.Parse(Console.ReadLine());
            int[] train = new int[wagonCount];

            for (int i = 0; i < wagonCount; i++)
            {
                train[i] = int.Parse(Console.ReadLine());

            }

            int sum = 0;
            foreach (var i in train)
            {
                sum += i;
                Console.Write(i + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine(sum);


        }
    }
}