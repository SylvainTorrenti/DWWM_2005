using System;

namespace ClassLibraryEmprunt
{
    public class Emprunt
    {
        private float taux;
        int nombreDeMois;
        private int montant;
        public enum PeriodeCouranteRemboursement { Mensuelle = 1, Bimensuelle = 2, Trimestrielle = 3, Semestrielle = 6, Annuelle = 12 };
        private PeriodeCouranteRemboursement remboursementActuel;

        public Emprunt()
        {
            taux = 7;
            nombreDeMois = 1;
            montant = 0;
            remboursementActuel = PeriodeCouranteRemboursement.Mensuelle;
        }
        public float Taux
        {
            get => taux;
            set => taux = value;
        }
        public PeriodeCouranteRemboursement RemboursementActuel
        {
            get => remboursementActuel;
            set => remboursementActuel = value;
        }
        public int NombreDeMois
        {
            get => nombreDeMois;
            set => nombreDeMois = value;
        }
        public int Montant
        {
            get => montant;
            set => montant = value;
        }
        public double Calcul()
        {
            double tauxParMois = taux / 100;
            double montantParMois = (montant * (tauxParMois / (1 - Math.Pow((1 + tauxParMois), -this.CalculMois()))));
            return Math.Round(montantParMois, 2);
        }
        public int CalculMois()
        {
            return nombreDeMois / (int)remboursementActuel;
        }
    }


}
