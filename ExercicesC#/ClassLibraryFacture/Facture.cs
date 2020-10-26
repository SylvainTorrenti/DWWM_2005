using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFacture
{
    public class Facture
    {

        private string nom;
        private DateTime date;
        private float montant;
        private string codePostal;

        public Facture()
        {
            nom = "";
            date = DateTime.Now;
            montant = 0;
            codePostal = "00000";
        }
        public Facture(string _nom, DateTime _date, float _montant, string _codePostal)
        {
            this.nom = _nom;
            this.date = _date;
            this.montant = _montant;
            this.codePostal = _codePostal;

        }

        public string Nom { get => nom; set => nom = value; }
        public DateTime Date { get => date; set => date = value; }
        public float Montant { get => montant; set => montant = value; }
        public string CodePostal { get => codePostal; set => codePostal = value; }

        public override string ToString()
        {
            return
                $"Name : {nom}\n" +
                $"Date : {date:dd/MM/yyyy}\n" +
                $"Amount : {Math.Round(montant, 2)}\n" +
                $"Zip Code : {codePostal}";
        }
    }
}
