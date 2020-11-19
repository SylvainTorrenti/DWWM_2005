using ClassLibraryJardin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMeteo
{
    class Program
    {
        static void Main(string[] args)
        {
            Jardin j1 = new Jardin("Le jardin des fleurs", 0);
            j1.OnJardinier += Appeljardinier;
            j1.Diminuer();

        }
        private static void Appeljardinier(Jardin sender)
        {
            Console.WriteLine("Attention le gel! faire appel à un jardinier!");
            Console.ReadLine();
        }

    }

}
