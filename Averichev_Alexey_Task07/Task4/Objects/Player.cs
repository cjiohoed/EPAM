namespace Task4
{
    public class Player : GameObject, IMoveable, IGameObject
    {
        public Player(string name, int x, int y)
        {
            Type = ObjectType.Player;
            Name = name;
            X = x;
            Y = y;
        }

        public override void Draw(IGameField gameField)
        {
            gameField.Draw(Name, X, Y);
        }

    }
}
