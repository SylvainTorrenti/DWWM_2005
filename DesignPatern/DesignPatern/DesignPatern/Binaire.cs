using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern
{
    public abstract class Binaire : Expression
    {
        protected Expression nombre1;
        protected Expression nombre2;
        protected Binaire(Expression op1, Expression op2)
        {
            nombre1 = op1;
            nombre2 = op2;
        }

    }
}
