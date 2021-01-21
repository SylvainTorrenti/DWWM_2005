using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern
{
    public abstract class Expression
    {
        protected Expression()
        {
        }

        public abstract int Evalue();
    }
}
