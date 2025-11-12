using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern
{
    public class LiasseVierge : Liasse
    {
        public static LiasseVierge Instance()
        {
            return new LiasseVierge();
        }

        public void ajoute(Document doc)
        {
            setDocuments(doc);
        }
        public void retireDocument(Document doc)
        {
            documents.Remove(doc);
        }

    }
}
