namespace ClassLibraryPaint
{
    public abstract class Figure
    {
        protected int x;


        protected int y;

        protected Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract void SeDessiner();

    }
}