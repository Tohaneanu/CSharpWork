namespace Exercitii_1
{
    public class Dog: Animal
    {
        public int Weight=10;

        public Dog(int weight, string name): base(name)
        {
            this.Weight = weight;
        }

        public Dog(): base("Dog")
        {
        }
        public override string ToString()
        {
            return "Caine : "+ this.Weight + " , "+ base.Name;
        }
    }
}