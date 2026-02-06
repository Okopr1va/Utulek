using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utulek.Model;

namespace utulek.Services
{
    internal class Evidence
    {
        List<Zvire> seznam = new List<Zvire>();
        int dalsiId = 1;

        public void Pridej(Zvire z)
        {
            z.Id = dalsiId;
            z.DatumPrijmu = DateTime.Now;
            z.Adoptovano = false;
            z.DatumAdopce = null;

            seznam.Add(z);
            dalsiId++;
        }

        public void VypisVse()
        {
            Console.WriteLine("ID | Jmeno | Druh | Vek | Adoptovano");

            for (int i = 0; i < seznam.Count; i++)
            {
                Zvire z = seznam[i];
                Console.WriteLine(
                    z.Id + " | " +
                    z.Jmeno + " | " +
                    z.Druh + " | " +
                    z.Vek + " | " +
                    (z.Adoptovano ? "ano" : "ne")
                );
            }
        }

        public void VyhDruh(string druh)
        {
            for (int i = 0; i < seznam.Count; i++)
            {
                if (seznam[i].Druh.ToLower() == druh.ToLower())
                {
                    Console.WriteLine(seznam[i].Jmeno + " (" + seznam[i].Druh + ")");
                }
            }
        }

        public void Adoptuj(int id)
        {
            for (int i = 0; i < seznam.Count; i++)
            {
                if (seznam[i].Id == id)
                {
                    seznam[i].Adoptovano = true;
                    seznam[i].DatumAdopce = DateTime.Now;
                }
            }
        }

        public void Statistiky()
        {
            int adoptovani = 0;

            for (int i = 0; i < seznam.Count; i++)
            {
                if (seznam[i].Adoptovano)
                {
                    adoptovani++;
                }
            }

            Console.WriteLine("Celkem zvirat: " + seznam.Count);
            Console.WriteLine("Adoptovano: " + adoptovani);
        }
    }
}
