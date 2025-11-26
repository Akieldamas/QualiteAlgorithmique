using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class WebServiceAuto : RepriseVehicule, GestionDocument
    {
        Catalogue catalogue = new Catalogue();
        public IList<string> chercheVehicules(double prixMoyen, double ecartMax)
        {
            double prixMin = prixMoyen - ecartMax;
            double prixMax = prixMoyen + ecartMax;
            return catalogue.retrouveVehicules(prixMin, prixMax);
        }
        public string document(int id)
        {
            return $"Document avec ID {id} récupéré.";
        }
    }
}
