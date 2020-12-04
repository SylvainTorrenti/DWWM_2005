using System;

namespace ClassLibraryJardin
{
    public class Jardin
    {
        private double temp;
        private string name;
        public delegate void DelegateJardinier(Jardin sender);
        public event DelegateJardinier OnJardinier;
        #region contructeur
        public Jardin(string _name, double _temp)
        {
            name = _name;
            temp = _temp;
        }
        #endregion
        #region diminuer
        public double Temp
        {
            get => temp;
            //set => temp = value;
        }
        public void Diminuer()
        {
            temp--;
            if (temp <= 0)
            {
                if (OnJardinier != null)
                {
                    OnJardinier(this);
                }
            }
            else
            {
                Console.WriteLine("Il fait bon!");
            }
        }
        #endregion
    }
}
