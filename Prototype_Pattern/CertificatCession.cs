using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CertificatCession : Document
{
    public override Document affiche()
    {
        Console.WriteLine("Affichage du certificat de cession");
        return this;
    }
    public override Document duplique()
    {
        Console.WriteLine("Duplication du certificat de cession");
        return (Document)this.MemberwiseClone();
    }
    public override Document imprime()
    {
        Console.WriteLine("Impression du certificat de cession");
        return this;
    }
    public override Document remplit(string informations)
    {
        Informations = informations;
        Console.WriteLine("Remplissage du certificat de cession");
        return this;
    }
}
