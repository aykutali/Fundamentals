namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine()
                .Split();

            string bestSequence = "";
            int bestCount = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                string currBest = nums[i] + " ";
                int currCount = 0;

                for (int j = i; ; j++)
                {
                    if (j == nums.Length - 1)
                    {
                        break;
                    }
                    if ( nums[j] != nums[j + 1])
                    {
                        break;
                    }

                    currCount++;
                    currBest += nums[j] + " ";
                }

                if (currCount > bestCount)
                {
                    bestSequence = currBest;
                    bestCount = currCount;
                }
            }

            Console.WriteLine(bestSequence);
        }
    }
}