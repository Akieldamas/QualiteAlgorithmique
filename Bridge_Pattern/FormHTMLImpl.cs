using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    public class FormHTMLImpl : FormulaireImpl
    {
        public override void dessineTexte(string texte)
        {
            Console.WriteLine("Dessin du texte : " + texte);
        }
        public override bool gereZoneSaisie(string zone)
        {
            Console.WriteLine("Gestion de la zone de saisie Html : " + zone);
            return true;
        }
    }
}
