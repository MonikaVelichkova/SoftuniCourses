using System;

namespace _2._Articles
{
    internal class Program
    {
        class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public Article()
            {

            }
            public void Edit(string content)
            {
                this.Content = content;
            }
            public void ChangeAuthor(string author)
            {
                this.Author = author;
            }
            public void Rename(string title)
            {
                this.Title = title;
            }
            public override string ToString()
            {
                return $"{this.Title} - {this.Content}: {this.Author}";
            }
        }

        static void Main(string[] args)
        {
            string[] articleRead = Console.ReadLine().Split(", ");
            Article article = new Article()
            {
                Title = articleRead[0],
                Content = articleRead[1],
                Author = articleRead[2]
            };

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                switch (command[0])
                {
                    case "Edit":
                        article.Edit(command[1]);
                        break;

                    case "ChangeAuthor":
                        article.ChangeAuthor(command[1]);
                        break;

                    case "Rename":
                        article.Rename(command[1]);
                        break;
                }
            }
            Console.WriteLine(article);
        }
    }
}
