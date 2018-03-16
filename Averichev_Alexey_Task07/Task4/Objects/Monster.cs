namespace Task4
{
    public class Monster : Obj, IMoveable, IObject
    {
        public Monster(string name, uint x, uint y) : base(x, y)
        {
            Name = name;
        }

        public void Start()
        {
            Reset();
        }

        public void Reset()
        {
            _x = 0;
            _y = 0;
        }

        public void Move(Direction to)
        {
            switch (to)
            {
                case Direction.Up:
                    _y--;
                    break;
                case Direction.Right:
                    _x++;
                    break;
                case Direction.Down:
                    _y++;
                    break;
                case Direction.Left:
                    _x--;
                    break;
            }
        }
    }
}
