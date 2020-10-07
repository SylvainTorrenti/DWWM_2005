using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere
{
    public class Oeuf : StadeDEvolution
    {
        private DateTime dateTime;


        public override bool SeDeplacer()
        {
            Console.WriteLine("Je ne bouge pas");
            return true;
        }
    }
}
