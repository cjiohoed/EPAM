namespace Task4
{
    public class Game
    {
        public uint Width { get; }

        public uint Height { get; }

        public Game(uint width, uint height)
        {
            Width = width;
            Height = height;
        }

        public void Start()
        {
            Reset();

            while (true);
        }

        public void Reset()
        {
            
        }
    }

    public class Field
    {

    }
}
