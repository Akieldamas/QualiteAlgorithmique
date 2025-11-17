using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class VueVehicule : ComposantGraphiqueVehicule
{
    public void affiche()
    {
        Console.WriteLine("Affichage de la vue véhicule.");
        Console.WriteLine("    ______");
        Console.WriteLine("   /|_||_\\`.__");
        Console.WriteLine("  (   _    _ _\\");
        Console.WriteLine("  =`-(_)--(_)-'");
        Console.WriteLine("---------------");
    }
}