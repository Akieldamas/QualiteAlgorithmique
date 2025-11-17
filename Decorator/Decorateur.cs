using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Decorateur : ComposantGraphiqueVehicule
{
    protected ComposantGraphiqueVehicule composantGraphiqueVehicule;
    public Decorateur(ComposantGraphiqueVehicule composantGraphiqueVehicule)
    {
        this.composantGraphiqueVehicule = composantGraphiqueVehicule;
    }
    public virtual void affiche()
    {
        composantGraphiqueVehicule.affiche();
    }
}