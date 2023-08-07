using System.Security.Cryptography.X509Certificates;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<string>> companys=new Dictionary<string,List<string>>();

            string command = "";
            while ((command=Console.ReadLine())!="End")
            {
                List<string> argument=command
                    .Split(" -> ").ToList();

                string company = argument[0];
                string employeeId= argument[1];

                
                if (!companys.ContainsKey(company))
                {
                    companys.Add(company,new List<string>());
                }

                if (!companys[company].Contains(employeeId))
                {
                    companys[company].Add(employeeId);
                }

            }

            foreach (var x in companys)
            {
                Console.WriteLine(x.Key);

                foreach (var xValue in x.Value)
                {
                    Console.WriteLine($"-- {xValue}");
                }
            }
        }
    }
}