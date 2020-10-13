using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForet
{
    public class Feuille
    {
        int nbNervures;
        EnumCouleur couleurFeuille;
        EnumFormeFeuille formeFeuille;

       
        public Feuille(int _nbNervures, EnumCouleur _couleurFeuille, EnumFormeFeuille _formeFeuille)
        {
            this.nbNervures = _nbNervures;
            this.couleurFeuille = _couleurFeuille;
            this.formeFeuille = _formeFeuille;
        }


        public int NbNervures
        {
            get => nbNervures;
            //set => nbNervures = value; 
        }



        public void ChangeCouleursAutomne()
        {
            switch (couleurFeuille)
            {
                case EnumCouleur.Vert:
                    couleurFeuille = EnumCouleur.Jaune;
                    break;
                case EnumCouleur.Jaune:
                    couleurFeuille = EnumCouleur.Orange;
                    break;
                case EnumCouleur.Orange:
                    couleurFeuille = EnumCouleur.Rouge;
                    break;
                default:
                    couleurFeuille = EnumCouleur.Rouge;
                    break;
            }

        }


        public override string ToString()
        {
            return base.ToString() + "\nNombre de nervures : " + nbNervures + "\nCouleur : " + couleurFeuille + "\nForme : " + formeFeuille;
        }
    }
}