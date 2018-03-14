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

        public virtual double X { get; set; }

        public virtual double Y { get; set; }

        public virtual double Area()
        {
            return 0;
        }
    }
}
