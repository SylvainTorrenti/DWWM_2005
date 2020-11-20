using ClassLibraryTemp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHumain
{
    class Program
    {
        static void Main(string[] args)
        {
            Humain h1 = new Humain("Sylvain", 34.5);
            h1.OnDocteur += AllerChezLeDoc;
            while (h1.Temp < 38)
            {
                h1.Monter();
            }
        }
        private static void AllerChezLeDoc(Humain sender)
        {
            Console.WriteLine("Il faut aller chez le docteur! Car la temperature est de " + sender.Temp + "°C!");            
        }       
    }
}
