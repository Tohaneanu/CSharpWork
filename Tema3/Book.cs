using System;

namespace Tema3
{
    public class Book : Article
    {
        public string PublishingHouse = "default";
        public int Year;
        public string CoverType;
        public string Author;

        public Book(int articleNumber, string title, string author, string publishingHouse, int pageNumber, int year,
            string coverType) : base(articleNumber, title, pageNumber, IsAvailable)
        {
            this.Author = author;
            this.PublishingHouse = publishingHouse;
            this.Year = year;
            this.CoverType = coverType;
        }

        protected Book()
        {
        }


        public Book(Book book)
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