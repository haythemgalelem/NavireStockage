using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavireStockage
{
    class Stockage
    {
        private Int32 capaDispo;

        /// <summary>
        /// Retourner la capacité disponible dans la zone de stockage
        /// </summary>
        /// <returns></returns>
        public Int32 ObtenirCapaDispo()
        {
            return capaDispo;
        }

        /// <summary>
        /// Stocke la quantité qté et met a jour la capacité disponible
        /// </summary>
        /// <param name="pQté"></param>
        public void Stocker(Int32 pQté)
        {
            this.capaDispo = capaDispo + pQté; 
        }

        /// <summary>
        /// Indique si la zone de stockage est vide ou non
        /// </summary>
        /// <returns></returns>
        public Boolean EstVide()
        {
            if(this.capaDispo == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
        
        /// <summary>
        /// Indique si la zone de stockage est remplie ou non
        /// </summary>
        /// <returns></returns>
        public Boolean EstRemplie()
        {
            if (this.capaDispo == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
