using System;

public class ServeurWeb
{
  static void Main(string[] args)
  {
    Document document1, document2;
    document1 = new DocumentHTML();
    document1.setContenu("Hello");
    document1.dessine();
    Console.WriteLine("////");
    document2 = new DocumentPDF();
    document2.setContenu("Bonjour");
    document2.dessine();
  }
}
