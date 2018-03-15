namespace Task1
{
    public abstract class Figure
    {
        public virtual Figures Type
        {
            get
            {
                return Figures.Empty;
            }
        }

        public virtual double X { get; protected set; }

        public virtual double Y { get; protected set; }

        public virtual double Area()
        {
            return 0;
        }

        public virtual void Draw()
        {

        }
    }
}
