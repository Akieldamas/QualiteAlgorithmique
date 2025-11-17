using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MarqueDecorateur : Decorateur
{
    public MarqueDecorateur(ComposantGraphiqueVehicule composantGraphiqueVehicule) : base(composantGraphiqueVehicule)
    {
        this.composantGraphiqueVehicule = composantGraphiqueVehicule;
    }
    protected void afficheLogo()
    {
        Console.WriteLine("Brand Logo:");
        Console.WriteLine("  ____   ____  ");
        Console.WriteLine(" |  _ \\|  _ \\ ");
        Console.WriteLine(" | | | || | | |");
        Console.WriteLine(" | |_| || |_| |");
        Console.WriteLine(" |____/ |____/ ");

    }
    public override void affiche()
    {
        base.affiche();
        this.afficheLogo();
    }
}