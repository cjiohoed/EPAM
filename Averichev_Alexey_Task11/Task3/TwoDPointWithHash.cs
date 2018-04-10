using System;
using System.Security.Cryptography;
using System.Collections.Generic;

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
            // 98.53% / 10000 points
            unchecked
            {
                var num = 953;
                int hashCode = 0;
                hashCode = (hashCode * num) ^ (int)X;
                hashCode = (hashCode * num) ^ (int)Y;
                return hashCode;
            }
        }

        public override string ToString()
        {
            return $"({X};{Y})";
        }
    }
}
