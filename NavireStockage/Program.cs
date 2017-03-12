using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavireStockage
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Navire unNavire = new Navire(159, "Drogue", "Slice of Life", "1337AB");

                List<Stockage> Stockages = new List<Stockage>();
                Stockages.Add(new Stockage(60));
                Stockages.Add(new Stockage(100));

                Port unPort = new Port(Stockages);
                unPort.Dechargement(unNavire);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex);
            }

            Console.ReadLine();
        }
    }
}
