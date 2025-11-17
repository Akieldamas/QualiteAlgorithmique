using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ModeleDecorateur : Decorateur
{
    public ModeleDecorateur(ComposantGraphiqueVehicule composantGraphiqueVehicule) : base(composantGraphiqueVehicule)
    {
        this.composantGraphiqueVehicule = composantGraphiqueVehicule;
    }

    protected void afficheInfosTechniques()
    {
        Console.WriteLine("Affichage des infos techniques du modèle décoré.");
    }
    public override void affiche()
    {
        base.affiche();
        this.afficheInfosTechniques();
    }
}