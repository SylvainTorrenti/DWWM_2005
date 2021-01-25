using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern
{
    public class Soustraction : Binaire
    {
        public Soustraction(Expression op1, Expression op2) : base(op1, op2)
        {
        }

        public override int Evalue()
        {
            return nombre1.Evalue() - nombre2.Evalue();
        }
        public override string ToString()
        {
            return nombre1.ToString() + "-" + nombre2.ToString();
        }
        public override string Formate()
        {
            return this.ToString() + "=" + this.Evalue().ToString();

        }
    }
}
