using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTemp
{
    public class Humain
    {
        private double temp;
        private string name;
        public delegate void DelegateDocteur(Humain sender);
        public event DelegateDocteur OnDocteur;
        /// <summary>
        /// evenement qui se produit qd risque de gel 0 --- Gel
        /// evenement qui se produit qd on a de la fievre 38--- Fievre
        /// </summary>
        #region contructeur
        public Humain(string _name, double _temp)
        {
            name = _name;
            temp = _temp;
        }
        #endregion
        #region Monter
        public void Monter()
        {
            temp++;
            if (temp >= 38)
            {
                if (OnDocteur != null)
                {
                    OnDocteur(this);
                }
            }
            else
            {
                Console.WriteLine("Tout va bien!");
            }
        }
        #endregion
       
    }
}
    

