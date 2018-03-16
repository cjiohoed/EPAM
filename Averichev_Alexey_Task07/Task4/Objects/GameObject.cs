namespace Task4
{
    public abstract class GameObject : IObject
    {
        protected string _name = string.Empty;
        protected uint _x;
        protected uint _y;

        public string Name { get; set; }

        public uint X
        {
            get
            {
                return _x;
            }
        }
        public uint Y
        {
            get
            {
                return _y;
            }
        }

        protected GameObject(uint x, uint y)
        {
            _x = x;
            _y = y;
        }
    }
}
