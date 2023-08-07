namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsTopNumber(int num)
        {
            if (IsSumOfDigitsAreDivisibleBy8(num) && IsHoldOddDigit(num))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsSumOfDigitsAreDivisibleBy8(int num)
        {
            int digitSum = 0;

            for (int i = 0; num > 0; i++)
            {
                int digit = num % 10;
                num /= 10;
                digitSum += digit;
            }

            if (digitSum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsHoldOddDigit(int num)
        {
            int digit = 0;

            for (int i = 0; num > 0; i++)
            {
                digit = num % 10;
                num /= 10;

                if (digit % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}