using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ComposantPDF
{
    public void pdfFileContenu(string contenu)
    {
        Console.WriteLine("Contenu du fichier PDF : " + contenu);
    }
    public void pdfPrepareAffichage()
    {
        Console.WriteLine("Préparation de l'affichage du PDF");
    }
    public void pdfRafraichit()
    {
        Console.WriteLine("Rafraîchissement de l'affichage du PDF");
    }
    public void pdfTermineAffichage()
    {
        Console.WriteLine("Terminaison de l'affichage du PDF");
    }
    public void pdfEnvoieImprimante()
    {
        Console.WriteLine("Envoi du PDF à l'imprimante");
    }
}