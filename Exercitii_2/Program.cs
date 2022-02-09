using System;
using Exercitii_1;

namespace Exercitii_2
{
    public static class main
    {
        public static void Main(string[] args)
        {
            MyStorage storage = new MyStorage(10);
            storage.Add(0, "zero");
            storage.Add(1, "unu");
            storage.Add(3, 2);
            storage.Add(0, "modified");
            storage.Add(5, 5);
            storage.Add(8, new Cat("Alb", "Tom"));

            Console.WriteLine($"Elementul de pe pozitia 5: {storage.GetData(5)}");
            Console.WriteLine("\n \t \t All elements: \n ");
            storage.ToString();

            storage.Remove(5);

            Console.WriteLine("\n \t \t Dupa stergere: \n");
            
            storage.ToString();
            Console.WriteLine($"\n Indexul elementului 2 este: {storage.Find(2)} ");
            
            storage.Swap(0,1);

            Console.WriteLine("\n \t SWAP: \n");
            storage.ToString();
            
        }
    }
}