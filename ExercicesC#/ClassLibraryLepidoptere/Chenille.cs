using System;

namespace ClassLibraryLepidoptere
{
    public class Chenille : StadeDEvolution
    {
        public override bool SeDeplacer()
        {
            Console.WriteLine("Je rampe");
            return true;
        }
        public override StadeDEvolution prochainStade()
        {
            return new Chrysalide();
        }
    }
}