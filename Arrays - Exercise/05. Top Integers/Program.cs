namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArr=Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numArr.Length; i++)
            {
                bool isGreater = true;

                for (int j = i+1; j < numArr.Length; j++)
                {
                    if (numArr[i] <= numArr[j])
                    {
                        isGreater=false;
                    }
                }

                if (isGreater)
                {
                    Console.Write(numArr[i]+" ");
                }
            }
        }
    }
}