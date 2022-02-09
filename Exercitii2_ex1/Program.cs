using System;
using System.Collections.Generic;

namespace Exercitii2
{
    public class main
    {
        public static void Main(string[] args)
        {
            Lottery lot = new Lottery();
            Player pl = new Player("Player1");
            SortedSet<int> l1 = new SortedSet<int>() {1, 2, 3, 4, 5, 6};
            Player pl2 = new Player("Player2", l1);
            SortedSet<int> l2 = new SortedSet<int>() {1, 2, 3, 7, 8, 9};
            Player pl3 = new Player("Player3", l2);
            SortedSet<int> l3 = new SortedSet<int>() {4, 5, 6, 7, 8, 9};
            Player pl4 = new Player("Player3", l3);
            SortedSet<int> l4 = new SortedSet<int>() {2, 3, 4, 7, 8, 9};
            Player pl5 = new Player("Player3", l4);
            lot.AddPlayer(pl);
            lot.AddPlayer(pl2);
            lot.AddPlayer(pl3);
            lot.AddPlayer(pl4);
            lot.AddPlayer(pl5);

            List<Player> list = lot.FindWinner();
            if (list.Count > 0)
            {
                foreach (var w in list)
                {
                    Console.WriteLine(w.Name);
                }
            }
            else
            {
                Console.WriteLine("Nu a castigat nimeni!");
                Console.WriteLine($"Numerele norocoase erau: {lot.printNr()}");
            }


            Console.WriteLine();
        }
    }
}