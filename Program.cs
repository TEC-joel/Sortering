using System;
using System.Collections.Generic;

namespace Sortering
{
    class Program
    {
        static void Main(string[] args)
        {
            Kunde k1 = new Kunde("Ole", "Olsen", 54);
            Kunde k2 = new Kunde("Anne", "Æblegrød", 14);
            Kunde k3 = new Kunde("Birger", "Larsen", 34);

            SortEnavn SEnv = new SortEnavn();
            SortAge SAge = new SortAge();

            List<Kunde> KundeListe = new List<Kunde>() { k1, k2, k3 };
            Console.WriteLine("Original liste");
            foreach (var item in KundeListe)
            {
                Console.WriteLine($"{item.Fnavn} {item.Enavn} {item.Alder}");
            }

            KundeListe.Sort();

            Console.WriteLine("Sorteret liste - fornavn");
            foreach (var item in KundeListe)
            {
                Console.WriteLine($"{item.Fnavn} {item.Enavn} {item.Alder}");
            }

            KundeListe.Sort(SEnv);

            Console.WriteLine("Sorteret liste - efternavn");
            foreach (var item in KundeListe)
            {
                Console.WriteLine($"{item.Fnavn} {item.Enavn} {item.Alder}");
            }

            KundeListe.Sort(SAge);

            Console.WriteLine("Sorteret liste - alder");
            foreach (var item in KundeListe)
            {
                Console.WriteLine($"{item.Fnavn} {item.Enavn} {item.Alder}");
            }
        }
    }
}
