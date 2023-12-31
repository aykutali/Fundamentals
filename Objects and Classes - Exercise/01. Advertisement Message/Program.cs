﻿namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string>
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product",
                "Best product of its category.",
                "Exceptional product",
                "I can't live without this product."
            };

            List<string> events = new List<string>
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            List<string> names = new List<string>
            {
                "Diana", "Petya","Stella","Elena","Katya","Iva","Annie","Eva"
            };

            List<string> cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random randomIndex = new Random();

            int phraseIndex= randomIndex.Next(0,phrases.Count-1);
            int eventIndex = randomIndex.Next(0, phrases.Count-1);
            int nameIndex = randomIndex.Next(0, phrases.Count - 1);
            int cityIndex = randomIndex.Next(0, phrases.Count - 1);

            Console.WriteLine($"{phrases[phraseIndex]} {events[eventIndex]} {names[nameIndex]} - {cities[cityIndex]}.");

        }
    }
}