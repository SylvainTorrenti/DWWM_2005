using ClassLibraryJardin;
using System;

namespace ConsoleAppMeteo
{
    class Program
    {
        static void Main(string[] args)
        {
            Jardin j1 = new Jardin("Le jardin des fleurs", 4);
            j1.OnJardinier += Appeljardinier;
            while (j1.Temp > 0)
            {
                j1.Diminuer();
            }
        }
        private static void Appeljardinier(Jardin sender)
        {
            Console.WriteLine("Attention le gel! faire appel à un jardinier! La temperature est de " + sender.Temp + "°C!");
            Console.ReadLine();
        }

    }

}
