using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DocumentHTML : Document
{
    private string contenu { get; set; } = string.Empty;
    protected string getContenu()
    {
        return this.contenu;
    }

    public void setContenu(string contenu)
    {
        this.contenu = contenu;
    }
    public void dessine()
    {
        Console.WriteLine("Affichage du document HTML : " + contenu);
    }

    public void imprime()
    {
        Console.WriteLine("Impression du document HTML  :" + contenu);
    }


}
