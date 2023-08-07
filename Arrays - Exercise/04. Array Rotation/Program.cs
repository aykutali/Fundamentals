namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int n = arr.Length;
            int rotation = int.Parse(Console.ReadLine());

            /* moving arr to -->
            for (int i = 0; i < rotation; i++)
            {
                int j, last;
                last = arr[n - 1];

                for (j = n - 1; j > 0; j--)
                    arr[j] = arr[j - 1];

                arr[0] = last;
            }
            */

            // moving arr to <--
            for (int i = 0; i < rotation; i++)
            {
                int j, first;
                first = arr[0];

                for (j = 0; j < arr.Length-1; j++)
                {
                    arr[j] = arr[j+1];
                }
                arr[^1]=first;
            }
            
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }
    }
}