using System;

namespace ClassLibraryPaint
{
    public class Cercle : Figure
    {

        private int rayon;

        public Cercle(int x, int y, int rayon) : base(x, y)
        {
            this.rayon = rayon;
        }

        public override void SeDessiner()
        {
            Console.WriteLine("Je suis un cercle de rayon " + this.rayon.ToString() + ", au coordonés(" + this.x.ToString() + "," + this.y.ToString() + ").");
        }
    }
}