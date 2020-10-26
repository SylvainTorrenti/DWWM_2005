using ClassLibraryZoo;
using System;
using System.Collections.Generic;

namespace ConsoleAppTestZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AnimalDuZoo> mesAnimauxDuZoo = new List<AnimalDuZoo>();
            mesAnimauxDuZoo.Add(new Lapin(new DateTime(1994, 07, 21), true));
            mesAnimauxDuZoo.Add(new Lapin(new DateTime(1990, 07, 20), true));
            mesAnimauxDuZoo.Add(new Lion(new DateTime(1991, 06, 08), true));
            mesAnimauxDuZoo.Add(new Perroquet(new DateTime(2019, 03, 25), true));
            Gardien georges = new Gardien();
            //le feu arrive, il faut deplacer tout le monde
            foreach (AnimalDuZoo a in mesAnimauxDuZoo)
            {
                a.SeDeplacer();
            }




            //il faut mettre un peu d'ordre dans l'evacuation...du plus vieux au plus jeune


            mesAnimauxDuZoo.Sort();

            foreach (AnimalDuZoo a in mesAnimauxDuZoo)
            {
                a.SeDeplacer();
            }

            //mais que fait le gardien? il reste sur place?

            georges.SeDeplacer();

            //et qui va appeller les secours? 


            foreach (AnimalDuZoo a in mesAnimauxDuZoo)
            {
                a.Parler();
            }
            georges.Parler();

            Console.ReadLine();
        }
    }
}