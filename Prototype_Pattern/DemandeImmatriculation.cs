using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern
{
    public class DemandeImmatriculation : Document
    {
        public override Document duplique()
        {
            return new DemandeImmatriculation
            {
                Informations = this.Informations
            };
        }

        public override Document imprime()
        {
            Console.WriteLine($"Impression de la demande d'immatriculation : {Informations}");
            return this;
        }

        public override Document affiche()
        {
            Console.WriteLine($"Affichage de la demande d'immatriculation : {Informations}");
            return this;
        }

        public override Document remplit(string informations)
        {
            Informations = informations;
            return this;
        }
    }
}
