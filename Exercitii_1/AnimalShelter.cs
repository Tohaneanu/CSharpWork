using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercitii_1
{
    public class AnimalShelter
    {
        public int MaximLength;
        public List<Cat?> CatsList;
        public List<Dog?> DogList;

        public AnimalShelter(int maximLength)
        {
            MaximLength = maximLength;
            this.CatsList = new List<Cat?>();
            this.DogList = new List<Dog?>();
        }

        public void AddAnimal(Animal a)
        {
            if (CatsList.Count + DogList.Count < MaximLength)
            {
                if (a is Cat)
                {
                    CatsList.Add(a as Cat);
                }
                else
                {
                    DogList.Add(a as Dog);
                }
            }
            else
            {
                Console.WriteLine(" animal shelter is full!");
            }
        }

        public void Adopt(Animal a)
        {
            if (a is Cat)
            {
                foreach (var cat in CatsList.Where(cat => cat.Equals(a as Cat)))
                {
                    CatsList.Remove(cat);
                    return;
                }
            }
            else
            {
                foreach (var dog in DogList.Where(dog => dog.Equals(a as Dog)))
                {
                    DogList.Remove(dog);
                    return;
                }
            }
        }

        public void SeeAnimals()
        {
            foreach (var cat in CatsList)
            {
                Console.WriteLine(cat);
            }
            foreach (var dog in DogList)
            {
                Console.WriteLine(dog);
            }
        }
    }
}