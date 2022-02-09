using System;
using System.Collections.Generic;

namespace Exercitii2
{
    public class Lottery
    {
        public List<Player> jucatori;
        public SortedSet<int> numereCastigatoare;

        public Lottery()
        {
            jucatori = new List<Player>();
            numereCastigatoare = new SortedSet<int>();

            Random random = new Random();
            while (numereCastigatoare.Count != 6)
            {
                this.numereCastigatoare.Add(random.Next(1, 10));
            }
        }

        public void AddPlayer(Player p)
        {
            jucatori.Add(p);
        }

        public List<Player> FindWinner()
        {
            List<Player> winn = new List<Player>();
            foreach (var pl in jucatori)
            {
                if (pl.Numere.Equals(numereCastigatoare))
                {
                    winn.Add(pl);
                }
            }

            return winn;
        }

        public string printNr()
        {
            string pr = " ";
            foreach (var nr in numereCastigatoare)
            {
                pr = pr + " " + nr;
            }

            return pr;
        }
    }
}