// See https://aka.ms/new-console-template for more information


using System;

namespace Exercitii_1
{
    public static class main
    {
        public static void Main(string[] args)
        {
            AnimalShelter animalShelter = new AnimalShelter(5);
            Animal cat = new Cat();
            Animal cat1 = new Cat("Gri", "Cat");
            Animal dog = new Dog(12, "Dog");
            Cat cat2 = new Cat();
            Cat cat3 = new Cat();
            animalShelter.AddAnimal(cat);
            animalShelter.AddAnimal(cat1);
            animalShelter.AddAnimal(dog);
            animalShelter.AddAnimal(cat2);
            animalShelter.AddAnimal(cat3);

            animalShelter.SeeAnimals();
            animalShelter.Adopt(cat1);
            Console.WriteLine();
            Console.WriteLine("Dupa adoptie:");
            animalShelter.SeeAnimals();

            Console.WriteLine();
        }
    }
}