namespace Task4
{
    public class Player : Obj, IMoveable, IObject
    {
        public Player(string name, uint x, uint y) : base (x, y)
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
    }
}
