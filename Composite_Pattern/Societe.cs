using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Societe
{
    public List<Vehicule> vehicules = new List<Vehicule>();
    public void ajouteVehicule()
    {
        Console.WriteLine("Véhicule ajouté à la société.");

        Console.Write("Modèle : ");
        string modele = Console.ReadLine();

        Console.Write("Couleur : ");
        string couleur = Console.ReadLine();

        Console.Write("Prix : ");
        double prix;
        while (!double.TryParse(Console.ReadLine(), out prix))
        {
            Console.Write("Veuillez entrer un prix valide : ");
        }

        Vehicule vehicule = new Vehicule(modele, couleur, prix);
        vehicules.Add(vehicule);
    }
    public abstract double calculeCoutEntretien();
    public abstract void ajouteFiliale(Societe societe);
}
