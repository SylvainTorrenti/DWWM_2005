﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern
{
    public class Nombre : Expression
    {
        private int valeur;

        public Nombre(int valeur)
        {
            this.valeur = valeur;
        }

        public override int Evalue()
        {
            return valeur;
        }

        public override string Formate()
        {
            return valeur.ToString();
        }

        public override string ToString()
        {
            return valeur.ToString();
        }
    }
}
