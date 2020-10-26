using System;

namespace ClassLibraryZoo
{
    public class Lapin : AnimalDuZoo
    {
        private int lgOreilleEnCm;


        public Lapin(DateTime dateDeNaissance, bool estNeeAuZoo) : base(dateDeNaissance, estNeeAuZoo)
        {
            this.lgOreilleEnCm = 10;
        }

        public void Manger()
        {
            throw new System.NotImplementedException();
        }

        public override bool SeDeplacer()
        {
            Console.WriteLine("Je saute");
            return true;
        }
        public override bool Parler()
        {
            return false;
        }
    }
}
