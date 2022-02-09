using System;
using System.Collections.Generic;

namespace Exercitii2
{
    public class Player
    {
        public string Name;
        public SortedSet<int> Numere;

        public Player(string name)
        {
            this.Name = name;
            Console.WriteLine("INERATI 6 NUMERE IN INTERVALUL 0-10");
            Numere = new SortedSet<int>();
            while (Numere.Count != 6)
            {
                int number;

                bool success = int.TryParse(Console.ReadLine(), out number);
                if (success == true)
                {
                    this.Numere.Add(number);
                }
                else
                {
                    continue;
                }
            }
        }

        public Player(string name, SortedSet<int> numere)
        {
            Name = name;
            Numere = numere;
        }
    }
}