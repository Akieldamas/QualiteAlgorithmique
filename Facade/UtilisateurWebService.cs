using Facade;
using System;
using System.Collections.Generic;

public class UtilisateurWebService
{
  static void Main(string[] args)
  {
        //   WebServiceAuto webServiceAuto = new WebServiceAutoImpl();
    WebServiceAuto webServiceAuto = new WebServiceAuto();
    Console.WriteLine(webServiceAuto.document(0));
    Console.WriteLine(webServiceAuto.document(1));
    IList<string> resultats = webServiceAuto.chercheVehicules(6000, 1000);
    if (resultats.Count > 0)
    {
        Console.WriteLine(
        "Véhicule(s) dont le prix est compris "+
        "entre 5000 et 7000");
        foreach (string resultat in resultats)
        Console.WriteLine("   " + resultat);
    }
  }
}
