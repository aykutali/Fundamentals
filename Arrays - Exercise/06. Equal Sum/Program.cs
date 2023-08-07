namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool ifExists = false;
            int i = 0;

            for (i = 0; i <= arr.Length - 1; i++)
            {

                int leftSum = arr[..i].Sum();
                int rightSum = arr[(i + 1)..].Sum();

                if (i == 0)
                {
                    leftSum = 0;
                }

                if (i == arr.Length - 1)
                {
                    rightSum = 0;
                }

                if (leftSum == rightSum)
                {
                    ifExists = true;

                    break;
                }

            }


            if (ifExists)
            {
                Console.WriteLine(i);
            }
            else if (arr.Length < 1)
            {

            }
            else if (arr.Length == 1)
            {
                Console.Write("0");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}