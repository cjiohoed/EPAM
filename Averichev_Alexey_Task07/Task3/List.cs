namespace Task3
{
    public class List : ISeries, IIndexable
    {
        private double[] _series;
        private int currentIndex;

        public List(double[] series)
        {
            _series = series;
            currentIndex = 0;
        }

        public double GetCurrent()
        {
            return _series[currentIndex];
        }

        public bool MoveNext()
        {
            currentIndex = currentIndex < _series.Length - 1 ? currentIndex + 1 : 0;
            return true;
        }

        public void Reset()
        {
            currentIndex = 0;
        }

        public double this[int index]
        {
            get { return _series[index]; }
        }
    }
}
