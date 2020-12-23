namespace ClassLibraryMetierProducts
{
    public class Fournisseur
    {
        static IPersistance maPersistance;

        public static IPersistance MaPersistance { get => maPersistance; set => maPersistance = value; }

        public int fournisseur_id;
        public string fournisseur_nom;
        public string fournisseur_adresse;
    }
}
