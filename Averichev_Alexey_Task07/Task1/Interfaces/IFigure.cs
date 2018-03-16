namespace Task1
{
    public interface IFigure
    {
        double X { get; set; }

        double Y { get; set; }

        void Draw(ICanvas canvas);

        string Name { get; }
    }
}
