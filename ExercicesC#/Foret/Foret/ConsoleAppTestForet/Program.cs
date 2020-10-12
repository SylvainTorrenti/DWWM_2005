using ClassLibraryForet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestForet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Arbre arbre1 = new Arbre(5);
            Feuille feuille1 = new Feuille(5, EnumCouleur.Vert, EnumFormeFeuille.triangulaire);
            Feuille feuille2 = new Feuille(6, EnumCouleur.Vert, EnumFormeFeuille.triangulaire);
            Feuille feuille3 = new Feuille(7, EnumCouleur.Vert, EnumFormeFeuille.triangulaire);

            arbre1.AddFeuille(feuille1);
            arbre1.AddFeuille(feuille2);
            arbre1.AddFeuille(feuille3);

            Console.WriteLine(arbre1.ToString());
            Console.ReadLine();
        }
    }
}