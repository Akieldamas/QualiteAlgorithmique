using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class DocumentPDF : Document
    {
        public override void setContenu(string contenu)
        {
            this.contenu = contenu;
        }
        public override void dessine()
        {
            Console.WriteLine("Affichage du document PDF : " + contenu);
        }

        public override void imprime()
        {
            Console.WriteLine("Impression du document PDF  :" + contenu);
        }
    }
}
