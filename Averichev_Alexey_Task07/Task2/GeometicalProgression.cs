namespace Task2
{
    public class GeometicalProgression : ISeries
    {
        private double _start, _step;
        private int _currentIndex;
        private double _currentResult;

        public GeometicalProgression(double start, double step)
        {
            _start = start;
            _step = step;
            _currentIndex = 1;
            _currentResult = 0;
        }

        public double GetCurrent()
        {
            _currentResult += _start * _step * _currentIndex;
            return _currentResult;
        }

        public bool MoveNext()
        {
            _currentIndex++;
            return true;
        }

        public void Reset()
        {
            _currentIndex = 1;
            _currentResult = 0;
        }

        public double this[int index]
        {
            get
            {
                _currentResult += _start * _step * _currentIndex;
                return _currentResult;
            }
        }
    }
}