﻿namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintTheMiddleChar(input);
        }

        static void PrintTheMiddleChar(string input)
        {
            if (input.Length % 2 == 0)
            {
                Console.WriteLine($"{input[(input.Length / 2)-1]}{input[(input.Length / 2)]}");
            }
            else
            {
                Console.WriteLine(input[input.Length / 2]);
            }
        }
    }
}