using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SocieteSansFiliale : Societe
{
    public override double calculeCoutEntretien()
    {
        if (vehicules.Count > 0)
        {
            double coutTotal = 0;
            foreach (Vehicule v in vehicules)
            {
                coutTotal += v.prix;
            }
            return coutTotal;
        }
        return 0;
    }
    public override void ajouteFiliale(Societe societe)
    {
        throw new InvalidOperationException(
          "Une société sans filiale ne peut pas en ajouter.");
    }
}
