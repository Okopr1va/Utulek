using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utulek.Model;
using utulek.Services;

namespace utulek.UI
{
    internal class KonzoleUI
    {
        Evidence evidence = new Evidence();

        public void Spust()
        {
            string volba = "";

            while (volba != "0")
            {
                Console.WriteLine();
                Console.WriteLine("===== UTULEK PRO ZVIRATA =====");
                Console.WriteLine("1 - Pridat zvire");
                Console.WriteLine("2 - Vypsat vsechna zvirata");
                Console.WriteLine("3 - Vyhledat podle druhu");
                Console.WriteLine("4 - Oznacit adopci");
                Console.WriteLine("5 - Statistiky");
                Console.WriteLine("0 - Konec");

                volba = Console.ReadLine();

                if (volba == "1") PridatZvire();
                else if (volba == "2") evidence.VypisVse();
                else if (volba == "3") Vyhledat();
                else if (volba == "4") Adopce();
                else if (volba == "5") evidence.Statistiky();
            }
        }

        void PridatZvire()
        {
            Zvire z = new Zvire();

            Console.Write("Jmeno: ");
            z.Jmeno = Console.ReadLine();

            Console.Write("Druh (pes/kocka/jine): ");
            z.Druh = Console.ReadLine();

            Console.Write("Vek: ");
            int vek = int.Parse(Console.ReadLine());
            if (vek < 0) vek = 0;
            z.Vek = vek;

            Console.Write("Zdravotni stav: ");
            z.ZdravotniStav = Console.ReadLine();

            Console.Write("Poznamka (muze byt prazdna): ");
            z.Poznamka = Console.ReadLine();

            evidence.Pridej(z);
            Console.WriteLine("Zvire pridano.");
        }

        void Vyhledat()
        {
            Console.Write("Zadej druh: ");
            string druh = Console.ReadLine();
            evidence.VyhDruh(druh);
        }

        void Adopce()
        {
            Console.Write("Zadej ID: ");
            int id = int.Parse(Console.ReadLine());
            evidence.Adoptuj(id);
        }
    }
}
