using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> racers = new Dictionary<string, int>();

            List<string> race = Console.ReadLine()
                .Split(", ").ToList();

            string nameP = @"(?<name>[A-Za-z])";
            Regex nameR = new Regex(nameP);

            string kmP = @"(?<km>[0-9])";
            Regex kmR = new Regex(kmP);

            string input = "";
            while ((input = Console.ReadLine()) != "end of race")
            {
                string currName = "";
                var matchName = nameR.Matches(input);
                if (matchName != null)
                {
                    for (int i = 0; i < matchName.Count; i++)
                    {
                        currName += char.Parse(matchName[i].Value);
                    }
                }

                int currKM = 0;
                if (race.Contains(currName))
                {
                    var matchKM = kmR.Matches(input);
                    for (int i = 0; i < matchKM.Count; i++)
                    {
                        currKM += int.Parse(matchKM[i].Value);
                    }

                    if (racers.ContainsKey(currName))
                    {
                        racers[currName] += currKM;
                    }
                    else
                    {
                        racers.Add(currName, currKM);
                    }
                }
            }
            var ordered = racers.OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
            
            int count = 0;
            foreach (var kvp in ordered)
            {
                if (count<3)
                {
                    if (count == 0)
                    {
                        Console.WriteLine($"1st place: {kvp.Key}");
                    }

                    if (count == 1)
                    {
                        Console.WriteLine($"2nd place: {kvp.Key}");
                    }

                    if (count==2)
                    {
                        Console.WriteLine($"3rd place: {kvp.Key}");
                    }

                    count++;
                }
            }
        }
    }
}