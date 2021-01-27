using ClassLibraryPaint;
using System;

namespace ConsoleAppFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Cercle cercle1 = new Cercle(1, 2, 3);
            cercle1.SeDessiner();

            Rectangle rectangle1 = new Rectangle(1, 2, 3, 4);
            rectangle1.SeDessiner();

            Figures figures1 = new Figures(5, 6);
            Cercle cercle2 = new Cercle(7, 8, 9);
            Rectangle rectangle2 = new Rectangle(4, 3, 2, 1);
            figures1.AddFigure(cercle2);
            figures1.AddFigure(rectangle2);
            figures1.SeDessiner();

            Console.ReadLine();
        }
    }
}
