﻿using System;

namespace ClassLibraryLepidoptere
{
    public class Papillon : StadeDEvolution
    {
        public override bool SeDeplacer()
        {
            Console.WriteLine("Je vole");
            return true;
        }
        public override StadeDEvolution prochainStade()
        {
            return this;
        }
    }
}