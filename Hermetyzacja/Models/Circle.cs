using System;
using System.Collections.Generic;
using System.Text;

namespace Hermetyzacja.Models
{
    public class Circle
    {
        public double Radius { get; set; }
        public double Area => Math.PI * Radius * Radius; // Funkcja strzałkowa - "=>"
        public double Diameter => 2 * Radius;
        public double Circumfence => Math.PI * Diameter;

        public Circle( double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
