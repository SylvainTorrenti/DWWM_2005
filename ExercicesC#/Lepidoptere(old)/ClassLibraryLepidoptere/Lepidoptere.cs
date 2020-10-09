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
            return monStadeCourant.SeDeplacer();
        }

        public void SeMetamorphoser()
        {
            monStadeCourant=monStadeCourant.DonneTonProchainEtat();
            
        }
    }
}