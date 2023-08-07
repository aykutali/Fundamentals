namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> articleList= new List<Article>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine()
                    .Split(", ")
                    .ToList();

                Article currArticle = new Article(input[0], input[1], input[2]);

                articleList.Add(currArticle);
            }

            foreach (var item in articleList)
            {
                item.Print();
            }
        }

    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Print()
        {
            Console.WriteLine($"{Title} - {Content}: {Author}");
        }
    }
}