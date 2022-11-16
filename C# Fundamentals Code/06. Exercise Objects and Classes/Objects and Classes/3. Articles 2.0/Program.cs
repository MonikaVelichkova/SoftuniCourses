using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Articles_2._0
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
            public override string ToString()
            {
                return $"{this.Title} - {this.Content}: {this.Author}";
            }
        }

        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] articleRead = Console.ReadLine().Split(", ");
                Article article = new Article()
                {
                    Title = articleRead[0],
                    Content = articleRead[1],
                    Author = articleRead[2]
                };

                articles.Add(article);
            }

            string command = Console.ReadLine();
            switch (command)
            {
			case "title":
				articles = articles.OrderByDescending(a => a.Title).ToList();
                break;

			case "content":
				articles = articles.OrderByDescending(a => a.Content).ToList();
                break;

			case "author":
				articles = articles.OrderByDescending(a => a.Author).ToList();
                break;
            }

            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }
}
