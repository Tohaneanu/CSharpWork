namespace Tema3
{
    public class Article
    {
        public int ArticleNumber;
        public string Title;
        public int PageNumber;
        public static bool IsAvailable;

        public string DisplayDetails()
        {
            return $"Number of article : {ArticleNumber} \n" +
                   $"Title : {Title} \n" +
                   $"PageNumber : {PageNumber} \n" +
                   $"IsAvailable : {IsAvailable}";
        }

        public string ReadIt(string title)
        {
            return $"Titlul: {title} a fost citit.";
        }

        public Article(int articleNumber, string title, int pageNumber, bool isAvailable)
        {
            ArticleNumber = articleNumber;
            this.Title = title;
            this.PageNumber = pageNumber;
            Article.IsAvailable = isAvailable;
        }

        protected Article()
        {
        }

        public void Deconstruct(out int articleNumber, out string title, out int pageNumber,out bool isAvailable)
        {
            articleNumber = ArticleNumber;
            title = this.Title;
            pageNumber = this.PageNumber;
            isAvailable = Article.IsAvailable;
        }

        public bool IsAvailable1
        {
            get => IsAvailable;
            set => IsAvailable = value;
        }
    }
}