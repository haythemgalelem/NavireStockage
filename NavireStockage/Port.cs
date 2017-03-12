using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NavireStockage
{

    class Port
    {
        private List<Stockage> Stockages;

        public Port(List<Stockage> Stockages)
        {
            this.Stockages = Stockages;
        }

        /// <summary>
        /// On décharge le bateau
        /// </summary>
        /// <param name="unNavire"></param>
        public void Dechargement(Navire unNavire)
        {
            int i = 0;
            while (!unNavire.EstDéchargé() && i < this.Stockages.Count())
            {
                if (this.Stockages[i].ObtenirCapaDispo() > 0)
                // Si la capacité de stockage dispo est supérieure a 0
                {
                    Console.WriteLine(unNavire.ObtenirQtéFret() + " frets a décharger");
                    Console.WriteLine("Déchargement de " + Stockages[i].ObtenirCapaDispo() + " frets dans le stockage n° " + i);
                    if (this.Stockages[i].ObtenirCapaDispo() < unNavire.ObtenirQtéFret())
                    // Si la capacité de la zone de stockage est plus petite que la quantité de fret du navire
                    {
                        unNavire.Décharger(Stockages[i].ObtenirCapaDispo());
                        this.Stockages[i].Stocker(this.Stockages[i].ObtenirCapaDispo());
                    } else
                    {
                        this.Stockages[i].Stocker(unNavire.ObtenirQtéFret());
                        unNavire.Décharger(unNavire.ObtenirQtéFret());
                    }
                    Console.WriteLine("Capacité restante dans le stockage " + i + " : " + Stockages[i].ObtenirCapaDispo() + "\n");
                }
                i++;
            }
            if (unNavire.EstDéchargé())
            {
                Console.WriteLine("Le navire est déchargé");
            }
            else
            {
                Console.WriteLine("La quantité de fret du bateau était plus grande que la capacité de stockages des zones de stockage");
            }
        }
    }
}
