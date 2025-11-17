using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    public abstract class FormulaireImmatriculation
    {
        public void affiche()
        {
            Console.WriteLine("Affichage du formulaire d'immatriculation");
        }
        public void genereDocument()
        {
            Console.WriteLine("Génération du document d'immatriculation");
        }
        public bool gereSaisie()
        {
            return controleSaisie();
        }
        protected abstract bool controleSaisie();
    }
}
