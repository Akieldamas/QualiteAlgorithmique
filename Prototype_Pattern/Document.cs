using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Document
{
    public string Informations { get; set; } = string.Empty;

    public abstract Document imprime();
    public abstract Document affiche();
    public Document remplit(string informations)
    {
        Informations = informations;
        return this;
    }
    public Document duplique()
    { 
        return (Document)this.MemberwiseClone();
    }

}