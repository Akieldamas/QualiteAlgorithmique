using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    public abstract class FormulaireImpl
    {
        public abstract void dessineTexte(string texte);
        public abstract bool gereZoneSaisie(string zone);
    }
}
