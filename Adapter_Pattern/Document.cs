using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public abstract class Document
    {
        protected string contenu { get; set; } = null;
        public abstract void setContenu(string contenu);

        public abstract void dessine();
        public abstract void imprime();
    }
}
