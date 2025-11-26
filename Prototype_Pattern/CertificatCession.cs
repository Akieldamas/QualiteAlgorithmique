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
    public override Document imprime()
    {
        Console.WriteLine("Impression du certificat de cession");
        return this;
    }
}
