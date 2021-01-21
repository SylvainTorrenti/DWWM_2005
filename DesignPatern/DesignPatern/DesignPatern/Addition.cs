﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern
{
    public class Addition : Binaire
    {
        
        public Addition(Expression op1, Expression op2) : base(op1, op2)
        {         
        }

        public override int Evalue()
        {
            return nombre1 + nombre2;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
