using System;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace Task3
{
    public class HashTest
    {
        private int count;
        private TwoDPointWithHash[,] arr;
        int[] hashArr;
        Stopwatch timer = new Stopwatch();

        public double Uniqueness
        {
            get
            {
                timer.Start();

                CreateTestArray();
                CreateHashArray();
                CalculateHashes();
                var result = GetPercent();

                timer.Stop();

                return result;
            }
        }

        public int NumberOfObjects
        {
            get
            {
                return count * count;
            }
        }

        public string ElapsedTime
        {
            get
            {
                TimeSpan ts = timer.Elapsed;
                return ts.TotalMilliseconds < 1000 ?
                    String.Format($"{ts.TotalMilliseconds:0}ms") :
                    String.Format($"{ts.TotalSeconds:0}s {ts.Milliseconds:0}ms");
            }
        }

        public HashTest(int count)
        {
            this.count = count;
        }

        private void CreateTestArray()
        {
            arr = new TwoDPointWithHash[count, count];
            for (var x = 0; x < count; x++)
            {
                for (var j = 0; j < count; j++)
                {
                    for (var i = 0; i < count; i++)
                    {
                        arr[i, j] = new TwoDPointWithHash(i, j);
                    }
                }
            }
        }

        private void CreateHashArray()
        {
            hashArr = new int[count * count];
        }

        private void CalculateHashes()
        {
            var counter = 0;
            for (var j = 0; j < count; j++)
            {
                for (var i = 0; i < count; i++)
                {
                    hashArr[counter] = arr[i, j].GetHashCode();
                    counter++;
                }
            }
        }

        private double GetPercent()
        {
            double rightResults = hashArr.Distinct().Count();
            double resultProcent = rightResults / hashArr.Length * 100;
            return resultProcent;
        }

    }
}
