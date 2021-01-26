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

        public List<Figure> sesFigures { get; set; }


        public override void SeDessiner()
        {
            foreach(Figure figu in sesFigures)
            {
                figu.SeDessiner();
            }
        }
    }
}