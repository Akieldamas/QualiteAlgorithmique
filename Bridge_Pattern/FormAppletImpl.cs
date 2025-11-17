using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FormAppletImpl : FormulaireImpl
{
    public override void dessineTexte(string texte)
    {
        Console.WriteLine("Dessin du texte : " + texte);
    }
    public override bool gereZoneSaisie(string zone)
    {
        Console.WriteLine("Gestion de la zone de saisie Applet : " + zone);
        return true;
    }
}