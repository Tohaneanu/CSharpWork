using System;
using System.Collections.Generic;

namespace Tema3
{
    public class Library
    {
        public string Name;
        public string Address;
        public string City;
        public int EmployeesNumber;
        public int OpenHour;
        public int ClosingHour;
        public List<Article> Articles;
        public List<Book> Books;
        public List<Magazine> Magazines;

        public List<Article> GetAllArticles
        {
            get => Articles;
        }

        public void DisplaySchedule()
        {
            Console.WriteLine($"Program: {OpenHour} -- {ClosingHour}");
        }

        public Library(string name, string address, string city, int employeesNumber, int openHour, int closingHour,
            List<Article> articles, List<Book> books, List<Magazine> magazines)
        {
            Name = name;
            Address = address;
            City = city;
            EmployeesNumber = employeesNumber;
            OpenHour = openHour;
            ClosingHour = closingHour;
            Articles = articles;
            Books = books;
            Magazines = magazines;
        }

        public Library()
        {
        }

        public bool HasSubscribers(string title)
        {
            bool result = false;
            foreach (Article article in Articles)
            {
                if (string.Equals(article.Title, title) && article.IsAvailable1 == false)
                {
                    result = true;
                }
            }

            return result;
        }

        public List<string> GetAllAutthors()
        {
            List<string> result = new List<string>();
            foreach (Book book in Books)
            {
                if (result.Count == 0 || !result.Contains(book.Author))
                {
                    result.Add(book.Author);
                }
            }

            return result;
        }

        public void DisplayAllBooks()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine(book.DisplayDetails());
            }
        }

        public void DisplayAllMagazines()
        {
            foreach (Magazine magazine in Magazines)
            {
                Console.WriteLine(magazine.ToString());
            }
        }
    }
}