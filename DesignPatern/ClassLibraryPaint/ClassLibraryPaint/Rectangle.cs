using System;

namespace ClassLibraryPaint
{
    public class Rectangle : Figure
    {
        public Rectangle(int x, int y, int largeur, int longueur) : base(x, y)
        {
            this.largeur = largeur;
            this.longueur = longueur;
        }

        private int largeur;


        private int longueur;


        public override void SeDessiner()
        {
            Console.WriteLine("Je suis un rectangle de largeur et longueur de " + this.largeur.ToString() +" et "+ this.longueur.ToString()+ " au coordonés(" + this.x.ToString() + "," + this.y.ToString() + ")");
        }
    }
}