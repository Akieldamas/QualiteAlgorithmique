using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FormImmatriculationLuxembourg : FormulaireImmatriculation
{
    public FormImmatriculationLuxembourg(FormulaireImpl formulaireImpl)
    { }
    protected override bool controleSaisie()
    {
        Console.WriteLine("Contrôle des saisies spécifiques au formulaire d'immatriculation au Luxembourg");
        return true;
    }
}