using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavireStockage
{
    class Navire
    {
        private string noLloyds;
        private string nomNavire;
        private string libelleFret;
        private Int32 qtéFret;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="pQteFret">Quantité du fret du navire</param>
        /// <param name="pNomNavire">Nom du navire</param>
        /// <param name="pNoLloyds">Numéro du navire</param>
        /// <param name="pLibelleFret">Libelleé du fret</param>
        public Navire(Int32 pQteFret, string pLibelleFret, string pNomNavire, string pNoLloyds)
        // Quantité fret, libellé du fret, nom du navire, numéro du navire
        {
            this.qtéFret = pQteFret;
            this.libelleFret = pLibelleFret;
            this.nomNavire = pNomNavire;
            this.noLloyds = pNoLloyds;
        }

        /// <summary>
        /// Obtenir la quantité restante de Fret du navire;
        /// </summary>
        /// <returns>Quantité restante</returns>
        public Int32 ObtenirQtéFret()
        {
            return this.qtéFret;
        }

        public string ObtenirNomNavire()
        {
            return this.nomNavire;
        }

        /// <summary>
        /// Fonction pour vérifier si le navire est déchargé
        /// </summary>
        /// <returns>True or False</returns>
        public Boolean EstDéchargé()
        {
            if(this.qtéFret <= 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        /// <summary>
        /// Fonction pour décharger du navire la pQuantité
        /// </summary>
        /// <param name="pQté">Quantité a décharger</param>
        public void Décharger(int pQté)
        {
            if(pQté <= this.qtéFret)
            {
                this.qtéFret = this.qtéFret - pQté;
            } else
            {
                throw new Exception("La quantité a décharger est plus grande que la quantité de fret du navire");
            }
        }
    }
}
