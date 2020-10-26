using System;

namespace ClassLibraryZoo
{
    public class Perroquet : AnimalDuZoo
    {
        public Perroquet(DateTime dateDeNaissance, bool estNeeAuZoo) : base(dateDeNaissance, estNeeAuZoo)
        {
        }

        public void Manger()
        {
            throw new System.NotImplementedException();
        }

        public override bool SeDeplacer()
        {
            Console.WriteLine("Je vole!");
            return true;
        }
        public override bool Parler()
        {
            Console.WriteLine("Coco en danger!");
            return true;
        }
    }
}