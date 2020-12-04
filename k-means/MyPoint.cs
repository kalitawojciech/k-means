using System;

namespace k_srednich
{
    public class MyPoint : IComparable
    {
        public double X { get; set; }

        public double Y { get; set; }

        public MyPoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        public int CompareTo(object obj)
        {
            if(obj == null)
            {
                return 1;
            }

            MyPoint otherPoint = obj as MyPoint;

            if(otherPoint.X == this.X)
            {
                return this.Y.CompareTo(otherPoint.Y);
            }

            return this.X.CompareTo(otherPoint.X);
        }
    }
}
