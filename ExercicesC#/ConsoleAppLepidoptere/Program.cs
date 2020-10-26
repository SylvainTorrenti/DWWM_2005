using ClassLibraryLepidoptere;
using System;

namespace ConsoleAppTestLepidoptere
{
    class Program
    {
        static void Main(string[] args)
        {
            Lepidoptere l = new Lepidoptere();
            l.SeDeplacer();
            l.SeMetamorphoser();


            Console.ReadLine();
        }
    }
}