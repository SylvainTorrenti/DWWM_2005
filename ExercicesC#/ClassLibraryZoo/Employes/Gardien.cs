using System;

namespace ClassLibraryZoo
{
    public class Gardien : IDeplacable, IParler
    {
        public Gardien()
        {
        }

        public bool SeDeplacer()
        {
            Console.WriteLine("Je marche lentement aussi , je ne suis pas tout jeune");
            return true;
        }
        public bool Parler()
        {
            Console.WriteLine("allo les pompiers");
            return true;
        }
    }
}