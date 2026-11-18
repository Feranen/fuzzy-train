using System;
using System.Collections.Generic;
using System.Text;

namespace Hermetyzacja.Models
{
    public class Triangle
    {
        public Point2D A { get; private set; }
        public Point2D B { get; private set; }
        public Point2D C { get; private set; }
        public Triangle(Point2D a, Point2D b, Point2D c) {
            A = a;
            B = b;
            C = c;
        }
        private double _AB => A.Distance(B);
        private double _BC => B.Distance(C);
        private double _AC => A.Distance(C);
        private double _S => (_AB + _BC + _AC) / 2;
        public double Area => Math.Sqrt(_S*(_S-_AB)*(_S-_BC)*(_S - _AC));



    }
}
