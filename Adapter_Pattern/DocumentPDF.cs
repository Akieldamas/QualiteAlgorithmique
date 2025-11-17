using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DocumentPDF : Document
{
    private string contenu { get; set; } = string.Empty;
    protected ComposantPDF composantPDF;
    public void setContenu(string contenu)
    {
        this.contenu = contenu;
    }
    public void dessine()
    {
        Console.WriteLine("Affichage du document PDF : " + contenu);
    }

    public void imprime()
    {
        Console.WriteLine("Impression du document PDF  :" + contenu);
    }
}