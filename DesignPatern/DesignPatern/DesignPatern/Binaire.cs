using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern
{
    public abstract class Binaire : Expression
    {
        protected int nombre1;
        protected int nombre2;
        protected Binaire(Expression op1, Expression op2)
        {
            nombre1 = op1.Evalue();
            nombre2 = op2.Evalue();
        }
    }
}
