using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DocumentHTML : Document
{
    protected string getContenu()
    {
        return this.contenu;
    }

    public override void setContenu(string contenu)
    {
        this.contenu = contenu;
    }
    public override void dessine()
    {
        Console.WriteLine("Affichage du document HTML : " + contenu);
    }

    public override void imprime()
    {
        Console.WriteLine("Impression du document HTML  :" + contenu);
    }


}
