using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere
{
    public class Oeuf : StadeDEvolution
    {
      
        public override bool SeDeplacer()
        {
            Console.WriteLine("Je ne bouge pas");
            return false;
        }
        public override StadeDEvolution prochainStade()
        {
            return new Chenille();
        }
    }
}