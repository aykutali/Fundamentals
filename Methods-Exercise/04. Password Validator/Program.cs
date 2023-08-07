namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();

            bool isInRange = false;
            isInRange = IsLenghtIsBeetween6and10(pass);

            bool isOnly = false;
            isOnly = IsOnlyLetterAndDigits(pass);

            bool is2digit = false;
            is2digit = IsContainMin2Digits(pass);

            if (isInRange && isOnly && is2digit)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool IsLenghtIsBeetween6and10(string input)
        {
            if (input.Length < 6 || input.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
            return true;
        }

        static bool IsOnlyLetterAndDigits(string input)
        {

            for (int i = 0; i < input.Length; i++)
            {

                if ((input[i] >= 48 && input[i] <= 57) 
                    || (input[i] >= 65 && input[i] <= 90)
                    || (input[i] >= 97 && input[i] <= 122))
                {

                }

                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;
                }
            }

            return true;

        }

        static bool IsContainMin2Digits(string input)
        {
            int digitsCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 48 && input[i] <= 57)
                {
                    digitsCount++;
                }
            }

            if (digitsCount < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }

            return true;
        }
    }
}