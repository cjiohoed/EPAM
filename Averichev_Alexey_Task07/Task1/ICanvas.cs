namespace Task1
{
    public interface ICanvas
    {
        void Draw(Figure[] col);
        void DrawLine(Line obj);
        void DrawRectangle(Rectangle obj);
        void DrawRound(Round obj);
        void DrawRing(Ring obj);
    }

}
