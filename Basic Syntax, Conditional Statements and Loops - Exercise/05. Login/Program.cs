namespace _05._Login
{/*
  * Acer
login
go
let me in
recA
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = "";

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];
            }

            string currPass = "";
            int attemps = 0;
            while (currPass != password)
            {
                currPass= Console.ReadLine();
                if (currPass != password)
                {
                    attemps++;
                    if (attemps == 4)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                    
                }
               
                if (currPass==password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                }
            }


        }
    }
}