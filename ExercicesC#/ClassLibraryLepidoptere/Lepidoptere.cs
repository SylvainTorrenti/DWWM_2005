using System;

namespace ClassLibraryLepidoptere
{
    public class Lepidoptere
    {
        private StadeDEvolution monStadeCourant;


        public Lepidoptere()
        {

            monStadeCourant = new Oeuf();
        }

        public bool SeDeplacer()
        {
            return monStadeCourant.SeDeplacer();
        }

        public void SeMetamorphoser()
        {
            monStadeCourant = monStadeCourant.prochainStade();
            Console.WriteLine(monStadeCourant);
        }
    }
}
