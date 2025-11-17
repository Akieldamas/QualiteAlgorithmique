using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SocieteMere : Societe
{
    public List<Societe> filiales = new List<Societe>();
    public override double calculeCoutEntretien()
    {
        if (vehicules.Count > 0)
        {
            double coutTotal = 0;
            foreach (Vehicule v in vehicules)
            {
                coutTotal += v.prix;
            }
            if (filiales.Count > 0)
            {
                foreach (Societe s in filiales)
                {
                    foreach (Vehicule v in s.vehicules)
                    {
                        coutTotal += v.prix;
                    }
                }
            }
            return coutTotal;
        }
        return 0;
    }
    public override void ajouteFiliale(Societe societe)
    {
        filiales.Add(societe);
    }
}
