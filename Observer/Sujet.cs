using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class Sujet
    {
        protected List<Observateur> observateurs = new List<Observateur>();

        public void retire(Observateur observateur)
        {

        }
        public void ajoute(Observateur observateur)
        {
        }
        public void notifie()
        {
            foreach (Observateur o in observateurs)
            {
                o.actualise();
            }
        }
    }
}
