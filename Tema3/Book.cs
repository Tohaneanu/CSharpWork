using System;

namespace Tema3
{
    public class Book : Article
    {
        public string PublishingHouse { get; set; } = "default";
        public int Year;
        public string CoverType;
        public string Author { get; set; }

        public Book(int articleNumber, string title, string author, string publishingHouse, int pageNumber, int year,
            string coverType) : base(articleNumber, title, pageNumber, IsAvailable)
        {
            this.Author = author;
            this.PublishingHouse = publishingHouse is "" ? "default" : publishingHouse;
            this.Year = year;
            this.CoverType = coverType;
        }

        public Book(int articleNumber, string title, int pageNumber, bool isAvailable, int year, string coverType,
            string author) : base(articleNumber, title, pageNumber, isAvailable)
        {
            Year = year;
            CoverType = coverType;
            Author = author;
        }


        protected Book()
        {
        }


        public Book(Book book) : base(book.ArticleNumber, book.Title, book.PageNumber, book.IsAvailable1)
        {
            Author = book.Author;
            PublishingHouse = book.PublishingHouse;
            Year = book.Year;
            CoverType = book.CoverType;
        }

        public string DisplayDetails()
        {
            return $"Publishing House : {PublishingHouse} \n" +
                   $"Year : {Year} \n" +
                   $"CoverType : {CoverType} \n" +
                   $"Author : {Author}";
        }
    }
}