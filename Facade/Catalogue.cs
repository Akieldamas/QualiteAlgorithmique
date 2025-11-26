using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Catalogue
    {
        public IList<string> retrouveVehicules(double prixMin, double prixMax)
        {
            // Dans une vraie application, cette méthode
            // interrogerait une base de données.
            IList<string> liste = new List<string>();
            if (prixMin <= 5000 && prixMax >= 5000)
            {
                liste.Add("Peugeot 206 - 5000 EUR");
            }
            if (prixMin <= 7000 && prixMax >= 7000)
            {
                liste.Add("Renault Clio - 7000 EUR");
            }
            if (prixMin <= 12000 && prixMax >= 12000)
            {
                liste.Add("Citroën C4 - 12000 EUR");
            }
            return liste;
        }
    }
}
