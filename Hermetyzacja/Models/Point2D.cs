using System;
using System.Collections.Generic;
using System.Text;

namespace Hermetyzacja.Models
{
    public class Point2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public void Move(double dx, double dy) {
            X += dx;
            Y += dy;
        }
        public double Distance(Point2D p)
        {
            double dx = X - p.X;
            double dy = Y - p.Y;
            return Math.Sqrt(dx * dx + dy * dy);

        }
    }
}
