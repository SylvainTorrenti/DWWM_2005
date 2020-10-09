
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere
{
    public class Chrysalide : StadeDEvolution
    {
        public override bool SeDeplacer()
        {
            Console.WriteLine("Je bouge au grés du vent");
            return true;
        }
        public override StadeDEvolution prochainStade()
        {
            return new Papillon();
        }
    }
}