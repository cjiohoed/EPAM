namespace Task2
{
    public class ArithmeticalProgression : ISeries
    {
        private double _start, _step;
        private int _currentIndex;

        public ArithmeticalProgression(double start, double step)
        {
            _start = start;
            _step = step;
            _currentIndex = 1;
        }

        public double GetCurrent()
        {
            return _start + _step * _currentIndex;
        }

        public bool MoveNext()
        {
            _currentIndex++;
            return true;
        }

        public void Reset()
        {
            _currentIndex = 1;
        }

        public double this[int index]
        {
            get
            {
                return _start + _step * index;
            }
        }
    }

}