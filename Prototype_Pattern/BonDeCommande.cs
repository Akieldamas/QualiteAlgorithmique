using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BonDeCommande : Document
{
    public override Document duplique()
    {
        return new BonDeCommande
        {
            Informations = this.Informations
        };
    }

    public override Document imprime()
    {
        Console.WriteLine($"Impression du Bon de Commande : {Informations}");
        return this;
    }

    public override Document affiche()
    {
        Console.WriteLine($"Affichage du Bon de Commande : {Informations}");
        return this;
    }

    public override Document remplit(string informations)
    {
        Informations = informations;
        return this;
    }
}
