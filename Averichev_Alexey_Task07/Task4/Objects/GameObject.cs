namespace Task4
{
    public class GameObject : IGameObject, IMoveable
    {
        public ObjectType Type { get; protected set; }
        public string Name { get; protected set; }
        public int X { get; protected set; }
        public int Y { get; protected set; }

        public void MoveTo(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    Y--;
                    break;
                case Direction.Right:
                    X++;
                    break;
                case Direction.Down:
                    Y++;
                    break;
                case Direction.Left:
                    X--;
                    break;
            }
        }

        public virtual void Draw(IGameField gameField)
        //public virtual void Draw(GameObject gameField)
        {
            
        }
    }
}
