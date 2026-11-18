using Hermetyzacja.Models;

namespace Hermetyzacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var k1 = new Circle(12.5);
            Console.WriteLine($"Pole: {k1.Area}, Obwód: {k1.Circumfence}");

            Point2D p1 = new Point2D { X = -2, Y = -1 };
            Point2D p2 = new Point2D { X = 3, Y = 4.5 };
            Point2D p3 = new Point2D { X = -1.5, Y = 3.5 };

            Console.WriteLine($"Odległość: {p1.Distance(p2)}");

            Triangle tr = new Triangle(p1,p2,p3);
            Console.WriteLine($"Pole: {tr.Area}");

            // PARADYGMY

            /*
             1. Hermetyzacja (Enkapsulacja)
                Wszystrkie pola muszą być private. Muszą być dostępnę przez gettery i settery
                Klasa - czarna skrzyńka
            
                public - widoczna z zewnętrz klasy
                private - nie widoczna z zewnętrz klasy (Musze zaczynac z _field)
                protected
             
                
             */


        }
    }
}
