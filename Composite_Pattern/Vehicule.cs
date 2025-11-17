using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vehicule
{
    public string modele;
    public string couleur;
    public double prix;

    public Vehicule(string modele, string couleur, double prix)
    {
        this.modele = modele;
        this.couleur = couleur;
        this.prix = prix;
    }
}