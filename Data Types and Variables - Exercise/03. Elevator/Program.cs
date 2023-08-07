namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int elevetorCapacity = int.Parse(Console.ReadLine());

            double courses = ((double)people / elevetorCapacity);
            Console.WriteLine(Math.Ceiling(courses));
        }
        
    }
}