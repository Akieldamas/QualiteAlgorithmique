using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Document
{
    public string Informations { get; set; } = string.Empty;

    public abstract Document duplique();
    public abstract Document imprime();
    public abstract Document affiche();
    public abstract Document remplit(string informations);

}