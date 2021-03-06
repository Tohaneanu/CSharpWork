namespace Tema3
{
    public class Magazine : Article
    {
        public int MagazineNumber;
        public string Edition;
        public string Frequency { get; set; }

        public Magazine(int articleNumber, string title, int pageNumber, bool isAvailable, int magazineNumber,
            string edition, string frequency) : base(articleNumber, title, pageNumber, isAvailable)
        {
            MagazineNumber = magazineNumber == 0 ? 1 : magazineNumber;
            Edition = edition;
            Frequency = frequency;
        }


        public int MagazineNumber1
        {
            get => MagazineNumber;
            set => MagazineNumber = value == 0 ? 1 : value;
        }

        protected Magazine()
        {
        }

        public override string ToString()
        {
            return $"Magazine Number : {MagazineNumber} \n" +
                   $"Edition : {Edition} \n" +
                   $"Frequency : {Frequency} ";
        }
    }
}