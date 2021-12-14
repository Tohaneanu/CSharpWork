using System;
using System.Collections.Generic;
using System.Threading.Channels;


namespace Tema3 // Note: actual namespace depends on the project name.
{
    public static class Program
    {
        static int Sum(int a, int b)
        {
            Console.WriteLine("~int~");
            return a + b;
        }

        static decimal Sum(decimal a, decimal b)
        {
            Console.WriteLine("~decimal~");
            return a + b;
        }

        static int Sum(params int[] ints)
        {
            Console.WriteLine("~variable number of params~");
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                sum = sum + ints[i];
            }

            return sum;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Sum(1.43m, 2.5m));
            Console.WriteLine(Sum(1, 2, 4, 5, 6));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t EX2:");
            Console.WriteLine();
            Console.WriteLine();

            List<Article> Articles = new List<Article>()
            {
                (new Article(1, "Article1", 120, true)),
                (new Article(2, "Article2", 444, false)),
                (new Article(3, "Article3", 74, true))
            };
            List<Book> Books = new List<Book>()
            {
                new Book(4, "Title1", "Author1", publishingHouse: null, 1231, 1880, "normal"),
                new Book(5, "Title2", "Author2", "adaafa", 55, 1900, "normal2")
            };
            List<Magazine> Magazines = new List<Magazine>()
            {
                new Magazine(56, "Magazine1", 33, true, 0, "spring edition", "rare", "good"),
                new Magazine(55, "Magazine2", 2, false, 22, "summer edition", "common", "big frq ")
            };
            Library lib = new Library("Libr", "str lunga", "Brasov", 30, 8, 16, Articles, Books, Magazines);
            Console.WriteLine($"Details for first article: {Articles[0].DisplayDetails()}\n");
            Console.WriteLine(Articles[0].ReadIt("Clean Code: A Handbook of Agile Software Craftsmanship"));
            Console.WriteLine();
            Console.WriteLine($"All articles from library: ");
            foreach (var art in lib.GetAllArticles)
            {
                Console.WriteLine(art.Title);
            }

            Console.WriteLine("Library program: ");
            lib.DisplaySchedule();
            Console.WriteLine(lib.HasSubscribers("Article1"));
            Console.WriteLine(lib.HasSubscribers("Article2"));
            Console.WriteLine("\n All authors from lib: ");
            foreach (var str in lib.GetAllAutthors())
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("\n All books: ");
            lib.DisplayAllBooks();

            Console.WriteLine("\n All magazines: ");
            lib.DisplayAllMagazines();
        }
    }
}