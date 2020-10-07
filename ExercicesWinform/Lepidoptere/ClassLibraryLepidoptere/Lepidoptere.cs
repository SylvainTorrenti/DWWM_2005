using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    public class Lepidoptere
    {
        private StadeDEvolution monStadeCourant;
        private DateTime dateDeNaissance;

        public Lepidoptere(DateTime _dateDeNaissance)
        {
            dateDeNaissance = _dateDeNaissance;
            monStadeCourant = new Oeuf();
        }

        public virtual bool SeDeplacer()
        {
            if (monStadeCourant is Oeuf)
            {
                Console.WriteLine("je peux pas bouger");
            }
            else if (monStadeCourant is Chrysalide)
            {
                Console.WriteLine("Je bouge au grés du vent");
            }
            else if (monStadeCourant is Chenille)
            {
                Console.WriteLine("Je rampe");
            }
            else if (monStadeCourant is Papillon)
            {
                Console.WriteLine("Je vol");
            }
            return true;
        }

        public void SeMetamorphoser()
        {
            if (monStadeCourant is Oeuf)
            {
                monStadeCourant = new Chenille();
                Console.WriteLine("Je suis une chenille");
            }
            else if (monStadeCourant is Chenille)
            {
                monStadeCourant = new Chrysalide();
                Console.WriteLine("Je suis une chrysalide");
            }
            else if (monStadeCourant is Chrysalide)
            {
                monStadeCourant = new Papillon();
                Console.WriteLine("Je suis un papillon");
            }
            else
            {
                Console.WriteLine("J'ai bien vécu");
            }
        }
    }
}