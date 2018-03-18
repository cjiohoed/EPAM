namespace Task4
{
    public class Monster : GameObject, IMoveable, IGameObject
    {
        public Monster(string name, int x, int y)
        {
            Type = ObjectType.Enemy;
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
