using System;
using System.Collections.Generic;

namespace ClassLibraryPaint
{
    public class Figures : Figure
    {
        public Figures(int x, int y) : base(x, y)
        {
            sesFigures = new List<Figure>();
        }

        private List<Figure> sesFigures { get; set; }

        public void AddFigure(Figure f)
        {
            this.sesFigures.Add(f);
        }
        public void DeleteFigure(Figure f)
        {
            this.sesFigures.Remove(f);
        }
        public override void SeDessiner()
        {
            Console.WriteLine("Je suis plusieurs figures:");
            foreach(Figure figu in sesFigures)
            {
                figu.SeDessiner();
            }
        }
    }
}