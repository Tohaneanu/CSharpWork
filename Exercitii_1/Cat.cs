namespace Exercitii_1
{
    public class Cat : Animal
    {
        public string Color="Alb";

        public Cat(string color, string name): base(name)
        {
            this.Color = color;
        }

        public Cat():base("Cat")
        {
        }

        public override string ToString()
        {
            return "Pisica: "+ this.Color + " , "+ base.Name;
        }
    }
}