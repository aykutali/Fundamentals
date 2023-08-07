using System.Reflection.Metadata.Ecma335;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input=Console.ReadLine()
                .Split(", ")
                .ToList();

            Article currArticle = new Article(input[0], input[1], input[2]);

            int commandsCount=int.Parse(Console.ReadLine());

            for (int i = 0; i <commandsCount; i++)
            {
                List<string> currCommand=Console.ReadLine()
                    .Split(": ")
                    .ToList();

                switch (currCommand[0])
                {
                    case "Edit":
                        currArticle.Edit(currCommand[1]);
                        break;
                    case "ChangeAuthor":
                        currArticle.ChangeAuthor(currCommand[1]);
                        break;
                    case "Rename":
                        currArticle.Rename(currCommand[1]);
                        break;
                }
            }

            currArticle.Print();
        }
    }

    public class Article
    {
        public Article(string title,string content,string author)
        {
            Title=title;
            Content=content;
            Author=author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string newContent)
        {
            Content=newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author=newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title=newTitle;
        }

        public void Print()
        {
            Console.WriteLine($"{Title} - {Content}: {Author}");
        }
    }
}