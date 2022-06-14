using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn.Essentials
{
    public static class ComparingEqualityDriver
    {
        public static void Classes()
        {
            Console.WriteLine("\n=================Classes=================");
            CPoint p1 = new CPoint { X = 7, Y = 3 };
            CPoint p2 = p1;

            Console.WriteLine($"P1 == P2: {p1 == p2}");
            p2 = new CPoint { X = 7, Y = 3 };
            Console.WriteLine("p2 was pointed to another instance of CPoint... [p2] -> X = 7, Y = 3");
            Console.WriteLine($"P1 == P2: {p1 == p2}");

            CPoint p3 = new CPoint { X = 7, Y = 3 };

            Console.WriteLine($"P1 == P3: {p1 == p3}");
        }

        public static void Structs()
        {
            Console.WriteLine("\n=================Structs=================");
            SPoint p1 = new SPoint { X = 7, Y = 3 };
            SPoint p2 = p1;

            Console.WriteLine($"P1 == P2: {p1 == p2}");

            SPoint p3 = new SPoint { X = 7, Y = 3 };

            Console.WriteLine($"P1 == P3: {p1 == p3}");
        }

        public static void Records()
        {
            Console.WriteLine("\n=================Records=================");
            RPoint p1 = new RPoint(7, 3);
            RPoint p2 = p1;

            Console.WriteLine($"P1 == P2: {p1 == p2}");

            RPoint p3 = new RPoint(7, 3);

            Console.WriteLine($"P1 == P3: {p1 == p3}");
        }
    }
}
