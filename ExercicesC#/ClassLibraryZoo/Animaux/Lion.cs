using System;

namespace ClassLibraryZoo
{
    public class Lion : AnimalDuZoo
    {
        public Lion(DateTime dateDeNaissance, bool estNeeAuZoo) : base(dateDeNaissance, estNeeAuZoo)
        {
        }

        public void Manger()
        {
            throw new System.NotImplementedException();
        }

        public override bool SeDeplacer()
        {
            Console.WriteLine("Je marche lentemmment");
            return true;
        }
        public override bool Parler()
        {

            return false;
        }
    }
}