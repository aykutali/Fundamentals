using System.Security.Authentication;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(',')
                .Select(int.Parse)
                .ToArray();

            string input = "";

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputParts = input.Split();

                if (inputParts[0] == "exchange")
                {
                    int index = int.Parse(inputParts[1]);
                    Exchange(nums, index);
                }
            }
        }

        static void Exchange(int[] nums, int index)
        {
            if (index >= nums.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            int[] subNums1 = nums[..(index + 1)];
            int[] subNums2 = nums[(index + 1)..];

            for (int i = 0; i < subNums2.Length; i++)
            {
                nums[i] = subNums2[i];
            }

            int j = 0, k = 0;

            for (int i = subNums2.Length; i < nums.Length; i++)
            {
                for (; j < k + 1; j++)
                {
                    nums[i] = subNums1[j];
                }
                k++;
            }

            Console.WriteLine($"[{string.Join(", ", nums)}]");
        }
    }
}