using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern
{
    public class Soustraction : Binaire
    {
        protected int nombre1;
        protected int nombre2;
        public Soustraction(Expression op1, Expression op2) : base(op1, op2)
        {
            nombre1 = op1.Evalue();
            nombre2 = op2.Evalue();
        }

        public override int Evalue()
        {
            return nombre1 - nombre2;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
