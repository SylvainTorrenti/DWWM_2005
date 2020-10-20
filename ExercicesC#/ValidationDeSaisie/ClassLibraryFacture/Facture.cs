using System;

namespace ClassLibraryFacture
{
    public class Facture
    {

        private string nom;
        private DateTime date;
        private float montant;
        private string codePostal;


        public Facture(string _nom, DateTime _date, float _montant, string _codePostal)
        {
            this.nom = _nom;
            this.date = _date;
            this.montant = _montant;
            this.codePostal = _codePostal;

        }
    }
}