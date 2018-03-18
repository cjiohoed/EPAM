namespace Task4
{
    public interface IGameObject
    {
        string Name { get; }

        int X { get; }
        int Y { get; }

        void Draw(IGameField gameField);
    }
}
