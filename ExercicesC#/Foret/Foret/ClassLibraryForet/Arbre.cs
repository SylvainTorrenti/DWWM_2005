using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForet
{
    public class Arbre
    {
        int hauteur;
        private List<Feuille> feuilles;

        public Arbre(int hauteur)
        {
            this.hauteur = hauteur;
            feuilles = new List<Feuille>();

        }

        public Arbre(int hauteur, List<Feuille> _feuilles) //ouvre porte aggregation
        {
            this.hauteur = hauteur;
            feuilles = _feuilles;
        }

        public void AddFeuille(Feuille f)
        {
            this.feuilles.Add(f);
        }

        public int Hauteur
        {
            get => hauteur;
            //set => hauteur = value; 
        }

        public override string ToString()
        {
            string str = base.ToString() + "\nHauteur : " + hauteur + "M";

            if (this.feuilles.Count() > 0)
            {
                str += "\nFeuilles :";
                foreach (Feuille f in feuilles)
                {
                    str += "\n" + f.ToString();
                }
            }
            
            return str;
        }
    }
}
