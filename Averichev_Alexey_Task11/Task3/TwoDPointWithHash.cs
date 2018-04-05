using System;

namespace Task3
{
    public class TwoDPointWithHash : IEquatable<TwoDPointWithHash>
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public TwoDPointWithHash(double x, double y)
        {
            X = x;
            Y = y;
        }

        public bool Equals(TwoDPointWithHash other)
        {
            if (other == null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return X == other.X & Y == other.Y;

        }

        public override int GetHashCode()
        {
            //return unchecked(X.GetHashCode() ^ Y.GetHashCode());

            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ X.GetHashCode();
                hashCode = (hashCode * 397) ^ Y.GetHashCode();
                return hashCode;
            }
        }

        public override string ToString()
        {
            return $"({X};{Y})";
        }
    }
}
