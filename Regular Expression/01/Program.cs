using System.Text.RegularExpressions;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 01
             * >>(?<name>[A-Za-z]+)<<(?<price>[0-9]+|[0-9]+.[0-9]+)!(?<quantity>[0-9]+)
             *
             *
             *
             * 02
             * name regex (?<name>[A-Za-z])
             * km regex (?<km>[0-9])
             *
             *
             *
             * 03
             * %(?<name>[A-Z][a-z]+)%[^\|\$\%\.]*<(?<product>[A-Z][a-z]+)>[^\|\$\%\.]*\|[^\|\$\%\.0-9]*(?<quantity>[0-9]+)\|[^\|\$\%\.0-9]*(?<price>[0-9]+|[0-9]+.[0-9])\$
             */
        }
    }
}